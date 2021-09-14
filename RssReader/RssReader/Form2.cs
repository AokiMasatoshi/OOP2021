using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class Form2 : Form
    {
        Uri urlCode;
        List<Uri> urls= new List<Uri>();

        public Form2(string url)
        {
            InitializeComponent();
            this.urlCode = new Uri(url);
            btReturn.Enabled = false;
            btMoveOn.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            wbBrowser2.Url = urlCode;
            urls.Add(wbBrowser2.Url);
        }


        private void btReturn_Click(object sender, EventArgs e)
        {

            if (urls[0] != wbBrowser2.Url)
            {
               btReturn.Enabled = true;
               
            }
        }

        private void btMoveOn_Click(object sender, EventArgs e)
        {
            //if ()
            //{

            //}

        }
    }
}
