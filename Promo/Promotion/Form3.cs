using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promotion
{
    public partial class Form3 : Form
    {
        private static Form2 _instance;
        private static Form1 _instance1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbLeagueName.Text = "プレミアリーグ";
        }

        private void btSerectBack_Click(object sender, EventArgs e)
        {
            Instance.Show();
            this.Visible = false;

        }
        public static Form2 Instance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form2();
                }
                return _instance;
            }
        }

        private void btLeagueSelectBack_Click(object sender, EventArgs e)
        {
            Instance1.Show();
            this.Visible = false;
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
