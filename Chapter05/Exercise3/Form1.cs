using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }
//フォームがロードされるタイミングで1回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            inputStrDate.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void button5_3_1_Click(object sender, EventArgs e) {
            textBoxSpaceCount.Text = inputStrText.Text.Count(s => s == ' ').ToString();   
        }

        private void button5_3_2_Click(object sender, EventArgs e) {
            tbWordChange.Text = inputStrText.Text.Replace("big", "small");

        }

        private void WordCountBotton_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ');
            tbWordCount.Text = items.Length.ToString();

            
        }

        private void button5_3_4_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach (var item in items) {
                tb5_3_4.Text += item+' ';
            }
           
            
        }

        private void button5_3_5_Click(object sender, EventArgs e) {
            var sb = new StringBuilder();
            var items = inputStrText.Text.Split(' ');
            foreach (var item in items) {
                sb.Append(item +" ");
            }
            tb5_3_5.Text = sb.ToString();

            //var array = inputStrText.Text.Split(' ').ToArray();
            //if (array.Length>0) {
            //    var sb = new StringBuilder(array[0]);
            //    foreach (var item in array.Skip(1)) {
            //        sb.Append(' ');
            //        sb.Append(item);

            //    }
            //    tb5_3_5.Text = sb.ToString();
            
                
        }

        private void button5_4_Click(object sender, EventArgs e) {
            //"Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886"
            foreach (var pair in inputStrDate.Text.Split(';')) {
                var array = pair.Split('=');
                outputStrDate.Text += ToJapanese(array[0]) + ":" + array[1] + Environment.NewLine;

            }
        }

        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";

            }
            throw new AggregateException("引数が正しくありません");
        }
    }
}
