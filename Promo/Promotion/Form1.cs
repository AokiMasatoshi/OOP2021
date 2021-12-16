using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promotion
{
    public partial class Form1 : Form
    {
        public string ConsumerKey = "0500cc1d22a4497297e17f6489170c6f";
        private static Form2 _instance;
        public string key;
        public string LeagueName;

        public string EndPointUrl { get; private set; } = "https://api.football-data.org/v2/competitions/CL/matches";

        public Form1()
        {
            InitializeComponent();
        }

        private void btPre_Click(object sender, EventArgs e)
        {
            EndPointUrl = "https://api.football-data.org/v2/competitions/PL/matches";
            LeagueName = "プレミアリーグ";
        }

        private void btLaLiga_Click(object sender, EventArgs e)
        {
            EndPointUrl = "https://api.football-data.org/v2/competitions/PD/matches";
            LeagueName = "ラ・リーガ";
        }

        private void btBundes_Click(object sender, EventArgs e)
        {
            EndPointUrl = "https://api.football-data.org/v2/competitions/BL1/matches";
            LeagueName = "ブンデスリーガ";
        }

        private void btLigue1_Click(object sender, EventArgs e)
        {
            EndPointUrl = "https://api.football-data.org/v2/competitions/FL1/matches"; 
            LeagueName = "リーグ・アン";
        }

        private void btSerieA_Click(object sender, EventArgs e)
        {
            EndPointUrl = "https://api.football-data.org/v2/competitions/SA/matches";
            LeagueName = "セリエ・A";
        }

        private void btUEFAChanpions_Click(object sender, EventArgs e)
        {
            EndPointUrl = "https://api.football-data.org/v2/competitions/CL/matches";
            LeagueName = "チャンピオンズリーグ";

        }

        private void btDecision_Click(object sender, EventArgs e)
        {
            var api = new MajorSoccerAPI(ConsumerKey,EndPointUrl);
            api.GetSoccer();
            Visible = false;
            Instance.Show();
        }
        public static Form2 Instance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form2();
                }
                return _instance;
            }
        }
    }
}