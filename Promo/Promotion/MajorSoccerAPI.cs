
using Microsoft.Exchange.WebServices.Data;
using Newtonsoft.Json;
using PowerArgs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Promotion
{
    class MajorSoccerAPI
    {
        public string ConsumerKey { get; private set; }

        public string EndPointUrl { get; private set; }
        public MajorSoccerAPI(string consumerKey, string endpointurl)
        {
            ConsumerKey = consumerKey;
            EndPointUrl = endpointurl;
            
        }
        public Soccer GetSoccer()
        {
            var parm = new Dictionary<string, string>();
            parm["rdf:type"] = "api.football-data:";
            parm["acl:consumerKey"] = ConsumerKey;
                var url = string.Format("{0}?{1}", EndPointUrl, string.Join("&", parm.Select(p => string.Format("{0}={1}", p.Key, p.Value))));
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };


            var json = client.DownloadString(url);

            return JsonConvert.DeserializeObject<Soccer>(json);
        }

        
    }
}
