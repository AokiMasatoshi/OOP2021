using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var today = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);
            DayOfWeek dayofweek = today.DayOfWeek;
            string dow = "";


            #region
            switch (dayofweek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
                default:
                    break;
            }
            #endregion

            tbOutput.Text = "今日は"+dow+"です";
            var isleapYear=  DateTime.IsLeapYear((int)nudYear.Value);

            if (isleapYear) {
                tbLeapYear.Text = "閏年です";

            } else {
                tbLeapYear.Text = "閏年ではありません";

            }

            var nowDay = DateTime.Now;
            TimeSpan diff= dateTimePicker1.Value - nowDay;
            tB2.Text = diff.TotalDays.ToString();

              tbAge.Text=  GetAge(dateTimePicker1.Value,nowDay).ToString()+"才";


                
        }
        public static int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay<birthday.AddYears(age)) {
                age--;
            }
            return age;
        }


       

    }
}
