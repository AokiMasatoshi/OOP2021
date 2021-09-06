﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            GetNewsReportFromYahoo(tbUrl.Text);
            
        }
        private void GetNewsReportFromYahoo(string uri)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    uri);
                var url = new Uri(uri);
                var stream = wc.OpenRead(uriString);

                XDocument xdoc = XDocument.Load(stream);
                var results = xdoc.Root.Descendants("title");
                foreach (var news in results)
                {
                    string s = Regex.Replace(news.Value, "【|】", "");
                    lbTitles.Items.Add(s);
                }
            }
        }
    }
}