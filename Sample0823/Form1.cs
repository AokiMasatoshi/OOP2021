using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btExec_Click(object sender, EventArgs e)
        {
            int num1 =int.Parse(tbValue.Text);
            int num2 = int.Parse(tbJyou.Text);
            //int ans = 1;

           tbResult.Text= ( Math.Pow(num2, num1)).ToString();
            

           // for (int i = 0; i < num2; i++)
           //{
           //  ans= ans *num1;
           //}
           //tbResult.Text = ans.ToString();


        }
    }
}
