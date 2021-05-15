﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HeThongGiuXe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading.Start(this);
            CheckinForm form = new CheckinForm();
            Loading.Close();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading.Start(this);
            CheckoutForm form = new CheckoutForm();
            Loading.Close();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnGeneralManagement_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //GeneralManagement form = new GeneralManagement();
            //form.ShowDialog(this);
            //this.Show();
        }

        private void btnParkingManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageVehicle form = new ManageVehicle();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnManageManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmployeeForm form = new ManageEmployeeForm();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnUnitPrice_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUnitPrice form = new ManageUnitPrice();
            form.ShowDialog(this);
            this.Show();
        }
    }
}
