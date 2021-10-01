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
        IEnumerable<ItemData> items = null;
        List<string> link = new List<string>();
        List<string> desc = new List<string>();
        int titleSelect = 0; 
        public Form1()
        {
            InitializeComponent();
            btWeb.Enabled = false;
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
                items = xdoc.Root.Descendants("item").Select(x => new ItemData
                {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("description"),
                });
                foreach (var item in items)   
                {
                    lbTitles.Items.Add(item.Title);
                    link.Add(item.Link);
                    desc.Add(item.Description);
                }
            }
        }

        private void lbTitles_MouseClick(object sender, MouseEventArgs e)
        {
            
            lbldesc.Text = desc[lbTitles.SelectedIndex];
            lbPubDate.Text = (items.ToArray())[lbTitles.SelectedIndex].PubDate.ToString();
            titleSelect = lbTitles.SelectedIndex;
            btWeb.Enabled = true;
            string links = (items.ToArray())[titleSelect].Link;
            Uri URL  = new Uri(links);

            //wbBrowser.Url = new Uri(link[lbTitles.SelectedIndex]);
        }

        private void btWeb_Click(object sender, EventArgs e)
        {
            var wbForm= new Form2((items.ToArray())[titleSelect].Link);
            wbForm.Show();
            //webBrowser出力
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
