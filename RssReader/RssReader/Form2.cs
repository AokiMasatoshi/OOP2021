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
        List<string> linkCode = null;
        int titleSelect = 0;

        public Form2(List<string> link, int title)
        {
            InitializeComponent();
            linkCode = link;
            titleSelect = title;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            wbGet(linkCode);
        }

        private void wbGet(List<string> linkCode)
        {
            wbBrowser2.Url = new Uri(linkCode[titleSelect]);
        }
    }
}
