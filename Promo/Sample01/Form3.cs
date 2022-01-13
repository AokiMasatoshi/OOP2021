using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample01
{
    public partial class Form3 : Form
    {
        private static Form1 _instance1;
        private string u = "https://ja.wikipedia.org/wiki/";
        public Form3()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string WikiURL = u + tbSelect.Text; 
            wb1.ScriptErrorsSuppressed = true;
            Uri URL = new Uri(WikiURL);
            wb1.Url = URL;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Visible = false;
            Instance1.Show();
        }
        public static Form1 Instance1
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance1 == null || _instance1.IsDisposed)
                {
                    _instance1 = new Form1();
                }
                return _instance1;
            }
        }

    }
}
