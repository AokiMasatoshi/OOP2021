using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        string inputPath = "";
        string outputPath = "";

        public Form1() {
            InitializeComponent();
        }  
        
        
        private void btSelect_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                inputPath = ofdOpenFile.FileName;
            }
        } 
        private void bt_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                outputPath = ofdOpenFile.FileName;
            }
        }

        private void btPlus_Click(object sender, EventArgs e) {

            var lines = File.ReadLines(inputPath);
            var filePath = outputPath;
            using (var writer = new StreamWriter(filePath, append: true)) {
                foreach (var line in lines) {
                    

                }
            }



        }

       
    }
}
