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
           
        }


        private void btMoveOn_Click(object sender, EventArgs e)
        {
            wbBrowser2.GoForward();

        }

        private void wbBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btReturn.Enabled = wbBrowser2.CanGoBack;
            btMoveOn.Enabled = wbBrowser2.CanGoForward;

            //if(wbBrowser2.CanGoBack )
            //{
            //    btReturn.Enabled = true;
            //}

        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            wbBrowser2.GoBack();
        }
    }
}
