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

            string links = (items.ToArray())[lbTitles.SelectedIndex].Link;
            wbBrowser.Url = new Uri(links);
        
            //wbBrowser.Url = new Uri(link[lbTitles.SelectedIndex]);
        }


    }
}
