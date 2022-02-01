using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Sample01
{
    class API
    {
        public API()
        {
        }
        public void getXML(string name)
        {
            String URLString = "https://ja.wikipedia.org/w/api.php?action=query&format=xml&prop=revisions&titles=" + name + "&rvprop=content";

            XmlTextReader reader = new XmlTextReader(URLString);
            var xdoc = XDocument.Load(reader);
            xdoc.Save("C:/Users/infosys/source/repos/AokiMasatoshi/OOP2021/Promo/Sample01/aaaa.xml");

        }
    }
}
