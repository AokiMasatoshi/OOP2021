using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class PLTeam
    {
        public static string PLteam = "リヴァプール,マンチェスターシティ,マンチェスターユナイテッド,アーセナル,チェルシー,トッテナム,ウェストハム,ウルブス,ブライトン ,レスターシティ,サウサンプトン,クリスタル・パレス,ブレントフォード,アストン・ヴィラ,エヴァートン,リーズU,ワトフォード,バーンリー,ニューカッスル,ノリッジ";
        public string[] PLTeamName { get; set; }
        public string[] TeamMenber { get; set; }


        private void Teamsplit()
        {
            PLTeamName = PLteam.Split(',');

        }
    }
}
