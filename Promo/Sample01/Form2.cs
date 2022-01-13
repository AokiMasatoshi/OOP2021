using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample01
{
    public partial class Form2 : Form
    {
        private static Form1 _instance1;
        public String[] SplitMenberName;
        public string TeamMenber = "アリソン・ラムセス・ベッカー,ファビオ・エンリケ・タバレス,フィルジル・ファン・ダイク,イブラヒマ・コナテ,ティアゴ・アルカンタラ・ド・ナシメント,ジェイムズ・ミルナー,ナビ・ケイタ,ロベルト・フィルミーノ・バルボーサ・デ・オリヴェイラ,ジョー・ゴメス,アドリアン・サン・ミゲル・カスティージョ,ジョーダン・ヘンダーソン,アレックス・オックスレイド＝チェンバレン,カーティス・ジョーンズ,南野拓実,ディオゴ・ジョッタ,コスタス・ツィミカス,ロリス・カリウス,アンドリュー・ロバートソン_(サッカー選手),ディヴォック・オリジ,ジョエル・マティプ,ナサニエル・フィリップス,クィービーン・ケレハー,トレント・アレクサンダー＝アーノルド,ハーヴェイ・エリオット,ネコ・ウィリアムズ";
        private string u = "http://ja.wikipedia.org/wiki/";
        public Form2(string text)
        {
            lbTeamName.Text = text ;
            InitializeComponent();


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
            SplitMenberName = TeamMenber.Split(',');
            foreach (var item in SplitMenberName)
            {
                lbPL.Items.Add(item);

            }

        }

        private void lbPL_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void lbPL_MouseClick(object sender, MouseEventArgs e)
        {
            string WikiURL = u + SplitMenberName[lbPL.SelectedIndex];
            wb.ScriptErrorsSuppressed = true;
            Uri URL = new Uri(WikiURL);
            wb.Url = URL;
        }
        public static Form1 Instance1
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance1 == null || _instance1.IsDisposed)
                {
                    _instance1 = new Form1();
                }
                return _instance1;
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            Visible = false;
            Instance1.Show();
        }
    }
}
