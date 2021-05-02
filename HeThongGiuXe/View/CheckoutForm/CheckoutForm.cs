using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace HeThongGiuXe
{
    public partial class CheckoutForm : Form
    {
        private VideoCapture Capture;
        private ArduinoSerial ArduinoSerial;
        // This property use to make decision of checkout
        private string DetectedPlate;
        private string SavedPlate;
        private Customer CurentCustomer;
        public CheckoutForm()
        {
            InitializeComponent();
            InitializeVideo("0");
            InitializeSerial("COM7", 9600);
            InitializeParkingList();
        }
        private void InitializeSerial(string port, int baud)
        {
            try
            {
                this.ArduinoSerial = new ArduinoSerial(port, baud, this.HandleNewCardID);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không thể kết nối với đầu đọc thẻ từ, vui lòng kiểm tra và khởi động lại ứng dụng",
                                "Lỗi thiết bị");
                Console.WriteLine(err.Message);
            }
        }
        private void InitializeVideo(string cam)
        {
            this.lbPlate.Text = "";
            // Cam is device or file ?
            if (cam.All(c => Char.IsDigit(c)))
            {
                Capture = new VideoCapture(Convert.ToInt32(cam));
            } else
            {
                Capture = new VideoCapture(cam);
            }
            // Is camera connected ? 
            if (!Capture.IsOpened)
            {
                MessageBox.Show("Không thể kết nối đến camera, hãy thử chọn một thiết bị khác", "Lỗi thiết bị");
                return;
            }
            // What thing to do when have frame?
            Capture.ImageGrabbed += ShowFrame;
            // Start camera thread
            Capture.Start();
        }
        private void InitializeParkingList()
        {
            this.tableVehicleInPark.DataSource = 
                CheckInOutBLL.Instance.GetDataTableParkingHistories(hasCheckout:false);
            if (this.tableVehicleInPark.RowCount > 0)
            {
                this.tableVehicleInPark.FirstDisplayedScrollingRowIndex
                = this.tableVehicleInPark.RowCount - 1;
            }
            
        }
        private void ShowFrame(object sender, EventArgs e)
        {

            try
            {
                // Get frame from camera
                Mat m = new Mat();
                ((VideoCapture)(sender)).Retrieve(m);
                // Show frame
                this.imgCamera.Image = m.ToImage<Bgr, byte>().Resize(650, 400, Emgu.CV.CvEnum.Inter.Linear, true);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private async void HandleNewCardID(string ID)
        {
            // To using reference in another thread
            if (this.txtCard.InvokeRequired)
            {
                this.Invoke(new ArduinoSerial.LineReceivedEvent(HandleNewCardID), ID);
                return;
            }
            // Set to textfield
            this.txtCard.Text = ID;
            // Start 2 thread: Check card + Check plate
            await Task.WhenAll(TryGetPlate(), LoadCheckinInfoByCard(ID));
            if ((this.checkAutoCheckout.Checked) 
                && (this.SavedPlate != null)
                && (this.DetectedPlate != null))
            {
                CheckOut();
            }
        }
        private void CleanCheckOutInfo()
        {
            this.txtCard.Clear();
            this.txtPlate.Clear();
            this.txtSavedPlate.Clear();
            this.lbStatusCard.Text = "Waiting";
            this.DetectedPlate = null;
            this.SavedPlate = null;
        }
        private async Task TryGetPlate()
        {
            // Check if exist camera
            if (!this.Capture.IsOpened)
            {
                this.lbPlate.Text = "Chưa kết nối đến camera";
                this.lbPlate.ForeColor = Color.Red;
                return;
            }
            // return;
            this.DetectedPlate = null;
            // Loading signal
            this.txtPlate.Text = "";
            this.lbPlate.Text = "Đang trích xuất...";
            this.lbPlate.ForeColor = Color.Yellow;
            // Save capture image
            ImageProcesing.CaptureToImageFile(this.Capture, "tmp.jpg");
            // Call API to get plate
            IList<Result> resutls = await APIPlateRecognizer.Instance.ReadPlateAsync("tmp.jpg");

            // Handle result
            if (resutls == null || resutls.Count == 0)
            {
                // Cannot get plate or no plate in image
                this.lbPlate.Text = "Không thể nhận dạng";
                this.lbPlate.ForeColor = Color.Red;
                this.DetectedPlate = null;
                return;
            }
            // If multiple plate
            if (resutls.Count > 1)
            {
                this.lbPlate.Text = "Quá nhiều biển số";
                this.lbPlate.ForeColor = Color.Red;
                return;
            }
            // Show plate
            this.txtPlate.Text = resutls[0].Plate;
            this.DetectedPlate = resutls[0].Plate;
            this.lbPlate.Text = "Đã trích xuất";
            this.lbPlate.ForeColor = Color.Green;
            
        }
        private async Task LoadCheckinInfoByCard(string cardID)
        {
            this.SavedPlate = null;
            this.CurentCustomer = null;
            // Loading signla
            this.lbStatusCard.Text = "...";
            // Check card
            Customer customer = CustomerBLL.Instance.GetCustomerByCardID(cardID);
            // Card is register?
            if (customer == null)
            {
                this.lbStatusCard.Text = "Chưa đăng ký";
                this.lbStatusCard.ForeColor = Color.Red;
                SystemSound.play(Sound.InvalidCard);
                return;
            }
            // Check if exist
            Parking_History checkin = CheckInOutBLL.Instance.GetParkingHistory(
                customer_id: customer.ID_customer,
                hasCheckout: false
                );
            if (checkin == null)
            {
                this.lbStatusCard.Text = "Thẻ chưa gửi xe";
                this.lbStatusCard.ForeColor = Color.Yellow;
                return;
            }
            this.lbStatusCard.Text = customer.fullname;
            this.lbStatusCard.ForeColor = Color.Green;
            this.SavedPlate = checkin.license_plate;
            this.CurentCustomer = customer;
            this.txtSavedPlate.Text = checkin.license_plate;
            
        }
        private void CheckOut(bool ignoreCompare = false)
        {
            // Show error
            if ((this.SavedPlate == null) || (!ignoreCompare && this.DetectedPlate == null))
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin thẻ hoặc biển số", "Lỗi thông tin");
                return;
            }
            if ((!ignoreCompare) && (this.SavedPlate != this.DetectedPlate))
            {
                MessageBox.Show("Thông tin không khớp", "Lỗi thông tin");
                return;
            }
            // Must payment?
            bool isPayment = !this.cbDebit.Checked;
            if (this.CurentCustomer.student_id == null) isPayment = true;
            Parking_History currentParking = null;
            try
            {
                currentParking = CheckInOutBLL.Instance.CheckOut(this.SavedPlate, isPayment);
                if (currentParking == null) throw new Exception();
            } catch (Exception err)
            {
                MessageBox.Show("Không thể truy cập vào cơ sở dữ liệu", "Lỗi hệ thống");
                return;
            }
            if (isPayment)
            {
                PaymentForm form = new PaymentForm(currentParking.price, this.CurentCustomer.student_id != null);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.Cancel)
                {
                    // Update debit card
                }
                // else do no thing
            }
            SystemSound.play(Sound.Thanks);
;           InitializeParkingList();
            CleanCheckOutInfo();
        }
        public void btnTryGetPlate_Click(object sender, EventArgs e)
        {
            _ = TryGetPlate();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CheckOut(true);
        }

        private void btnSetingSerial_Click(object sender, EventArgs e)
        {
            SerialSettingForm form = new SerialSettingForm(InitializeSerial);
            form.ShowDialog(this);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.ArduinoSerial.SendMessage("1");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ArduinoSerial.SendMessage("0");
        }

        private void txtPlate_TextChanged(object sender, EventArgs e)
        {
            this.DetectedPlate = ((TextBox)(sender)).Text;
        }

        private void btnFilterWithPlate_Click(object sender, EventArgs e)
        {
            if (this.DetectedPlate == null)
            {
                MessageBox.Show("Biển số không hợp lệ", "Lỗi dữ liệu");
            }
            this.tableVehicleInPark.DataSource = CheckInOutBLL.Instance
                .GetDataTableParkingHistories(hasCheckout: false, plate: this.DetectedPlate);
        }

        private void btnFilterWithCard_Click(object sender, EventArgs e)
        {
            string cardId = this.txtCard.Text.Trim();
            Customer customer = CustomerBLL.Instance.GetCustomerByCardID(cardId);
            if (customer == null)
            {
                MessageBox.Show("Thẻ không hợp lệ", "Lỗi dữ liệu");
                return;
            }
            this.tableVehicleInPark.DataSource = CheckInOutBLL.Instance
                .GetDataTableParkingHistories(hasCheckout: false, customer_id: customer.ID_customer);
        }

        private void btlGetAllInPark_Click(object sender, EventArgs e)
        {
            InitializeParkingList();
        }

        private void btnSettingCamera_Click(object sender, EventArgs e)
        {
            SettingCamera form = new SettingCamera(InitializeVideo);
            form.ShowDialog();
        }


    }
}
