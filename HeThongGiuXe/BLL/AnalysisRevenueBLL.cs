using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class AnalysisRevenueMonthResult
    {
        public int MONTH { get; set; }
        public int COUNT { get; set; }
        public int SUM { get; set; }
    }
    class AnalysisRevenueBLL
    {
        // Singleton
        public static AnalysisRevenueBLL _Instance { get; set; }

        public static AnalysisRevenueBLL Instance()
        {
            if (_Instance == null)
            {
                _Instance = new AnalysisRevenueBLL();
            }

            return _Instance;
        }

        private AnalysisRevenueBLL()
        {

        }

        public DataTable GetDataTableRevenue(int year)
        {
            /**
             * Doanh thu = ParkingHistory.price where paid_at = (month, year) + 
             *              Payment.price where check_out_at = (month,year)
             */
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("Tháng", typeof(string)),
                new DataColumn("Số lượng xe ra/vào", typeof(int)),
                new DataColumn("Doanh thu", typeof(string))
            });

            
            using (DatabaseEntities db = new DatabaseEntities())
            {
                List<AnalysisRevenueMonthResult> result1 = db.Parking_History.Where(item => 
                        (item.check_out_at.HasValue ? item.check_out_at.Value.Year == year : false))
                    .GroupBy(item => item.check_out_at.Value.Month)
                    .Select(
                        g => new AnalysisRevenueMonthResult
                        {
                            MONTH = g.Key,
                            SUM = g.Sum(item => item.price),
                            COUNT = g.Count()
                        }
                    ).OrderBy(item => item.MONTH).ToList();

                List<AnalysisRevenueMonthResult> result2 = db.Payments
                    .Where(payment => (payment.paid_at.HasValue ? payment.paid_at.Value.Year == year : false))
                    .GroupBy(payment => payment.paid_at.Value.Month)
                    .Select(g => new AnalysisRevenueMonthResult
                    {
                        MONTH = g.Key,
                        SUM = g.Sum(payment => payment.price),
                        COUNT = 0
                    }).ToList();

                Dictionary<int, AnalysisRevenueMonthResult> dict = new Dictionary<int, AnalysisRevenueMonthResult>();

                foreach (AnalysisRevenueMonthResult item in result1)
                {
                    if (dict.ContainsKey(item.MONTH))
                    {
                        dict[item.MONTH].SUM += item.SUM;
                    }
                    else
                    {
                        dict[item.MONTH] = item;
                    }
                }

                foreach (AnalysisRevenueMonthResult item in result2)
                {
                    if (dict.ContainsKey(item.MONTH))
                    {
                        dict[item.MONTH].SUM += item.SUM;
                    } else
                    {
                        dict[item.MONTH] = item;
                    }
                }
                List<AnalysisRevenueMonthResult> list = dict.Values.ToList();
                foreach (AnalysisRevenueMonthResult item in list)
                {
                    DataRow row = dt.NewRow();
                    row["Tháng"] = item.MONTH;
                    row["Số lượng xe ra/vào"] = item.COUNT;
                    row["Doanh thu"] = item.SUM;
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }

    }
}
