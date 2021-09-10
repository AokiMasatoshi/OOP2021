using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        List<string> link = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            GetRssTitle(tbUrl.Text);


        }
        private void GetRssTitle(string uri)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");

                var stream = wc.OpenRead(uri);

                XDocument xdoc = XDocument.Load(stream);
                var linkList = xdoc.Root.Descendants("link");
                var results = xdoc.Root.Descendants("title");
                foreach (var news in results)
                {

                    lbTitles.Items.Add(news.Value);
                }
                foreach (var links in linkList)
                {


                    link.Add(links.Value);
                }
            }
        }

        private void lbTitles_MouseClick(object sender, MouseEventArgs e)
        {
            wbBrowser.Url = new Uri(link[lbTitles.SelectedIndex]);
        }


    }
}
