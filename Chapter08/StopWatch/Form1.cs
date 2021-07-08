using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }


        private void Tm_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }


        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btStrat_Click(object sender, EventArgs e) {
            sw.Start();
            tmDisp.Tick += Tm_Tick;
            tmDisp.Start();

        }

        private void byStop_Click(object sender, EventArgs e) {
            sw.Stop();
        }

        private void tbReset_Click(object sender, EventArgs e) {
            sw.Reset();
            lbLapDisp.Items.Clear();

        }

        private void btLap_Click(object sender, EventArgs e) {
            lbLapDisp.Items.Insert(0,lbTimerDisp.Text);
        }
    }
}
