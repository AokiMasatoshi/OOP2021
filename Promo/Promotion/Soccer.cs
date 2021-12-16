using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion
{
    public class Soccer
    {


        public class Rootobject
        {
            public int id { get; set; }
            public Area area { get; set; }
            public string name { get; set; }
            public object code { get; set; }
            public string plan { get; set; }
            public Currentseason currentSeason { get; set; }
            public Season[] seasons { get; set; }
            public DateTime lastUpdated { get; set; }
        }

        public class Area
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Currentseason
        {
            public int id { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public int currentMatchday { get; set; }
        }

        public class Season
        {
            public int id { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public int currentMatchday { get; set; }
        }

    }
}
