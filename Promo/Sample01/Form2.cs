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
        public string TeamMenber;
        private string Selectteam;
        private string u = "http://ja.wikipedia.org/wiki/";
        public Form2(String team)
        {
            Selectteam = team;
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            lbTeamName.Text = Selectteam;
            SerectTeamManber();
            SplitMenberName = TeamMenber.Split(',');
            foreach (var item in SplitMenberName)
            {
                lbPL.Items.Add(item);

            }

        }

        private void SerectTeamManber()
        {
            switch (Selectteam)
            {
                case"リヴァプール":

                    TeamMenber = "アリソン・ラムセス・ベッカー,ファビオ・エンリケ・タバレス,フィルジル・ファン・ダイク,イブラヒマ・コナテ,ティアゴ・アルカンタラ・ド・ナシメント,ジェイムズ・ミルナー,ナビ・ケイタ,ロベルト・フィルミーノ・バルボーサ・デ・オリヴェイラ,ジョー・ゴメス,アドリアン・サン・ミゲル・カスティージョ,ジョーダン・ヘンダーソン,アレックス・オックスレイド＝チェンバレン" +
                        ",カーティス・ジョーンズ,南野拓実,ディオゴ・ジョッタ,コスタス・ツィミカス,ロリス・カリウス,アンドリュー・ロバートソン_(サッカー選手),ディヴォック・オリジ,ジョエル・マティプ,ナサニエル・フィリップス,クィービーン・ケレハー,トレント・アレクサンダー＝アーノルド,ハーヴェイ・エリオット,ネコ・ウィリアムズ";
                    break;
                case "マンチェスターシティ":
                    TeamMenber = "カイル・ウォーカー,ルベン・ディアス,ジョン・ストーンズ,ナタン・アケ,ラヒーム・スターリング,イルカイ・ギュンドアン,ガブリエウ・フェルナンド・ジ・ジェズス,ジャック・グリーリッシュ,オレクサンドル・ジンチェンコ,ザック・ステッフェン,アイメリク・ラポルテ,ロドリゴ・エルナンデス,ケヴィン・デ・ブライネ,ベルナルド・シウバ,バンジャマン・メンディ," +
                        "フェルナンド・ルイス・ローザ,リヤド・マフレズ,ジョアン・カンセロ,エデルソン・サンタナ・ジ・モライス,スコット・カーソン,フィル・フォーデン";
                    break;
                case "マンチェスターユナイテッド":
                    TeamMenber = "ダビド・デ・ヘア,ヴィクトル・リンデロフ,エリック・バイリー,フィル・ジョーンズ_(サッカー選手),ハリー・マグワイア,ポール・ポグバ,クリスティアーノ・ロナウド,フアン・マタ,アントニー・マルシャル,マーカス・ラッシュフォード,メイソン・グリーンウッド,ジェシー・リンガード,アマド・ディアロ,フレデリコ・ロドリゲス・デ・パウラ・サントス," +
                        "ブルーノ・フェルナンデス,ラファエル・ヴァラン,ディオゴ・ダロト,エディンソン・カバーニ,トム・ヒートン,ルーク・ショー,ジェイドン・サンチョ,ディーン・ヘンダーソン,アレックス・ニコラオ・テレス,アーロン・ワン＝ビサカ,ネマニャ・マティッチ,ドニー・ファン・デ・ベーク,アンソニー・エランガ,スコット・マクトミネイ,ハンニバル・メイブリ,ショラ・ショレティレ";
                    break;
                case "アーセナル":
                    TeamMenber = "ベルント・レノ,キーラン・ティアニー,ベン・ホワイト,トーマス・パーテイ,ガブリエウ・ドス・サントス・マガリャンイス,ブカヨ・サカ,マルティン・ウーデゴール,アレクサンドル・ラカゼット,エミール・スミス・ロウ,ピエール＝エメリク・オーバメヤン,ロブ・ホールディング,セドリック・ソアレス,冨安健洋,ニコラ・ペペ,ヌーノ・タヴァレス" +
                        ",カラム・チャンバース,パブロ・マリ,アルベール・サンビ・ロコンガ,モハメド・エルネニー,フォラリン・バログン,エディ・エンケティア,セアド・コラシナツ,アーロン・ラムズデール,グラニト・ジャカ,ガブリエウ・テオドロ・マルティネッリ・シウヴァ";
                    break;
                case "チェルシー":
                    TeamMenber = "ケパ・アリサバラガ,アントニオ・リュディガー,マルコス・アロンソ・メンドーサ,アンドレアス・クリステンセン,ジョルジ・ルイス・フレーロ・フィーリョ,チアゴ・エミリアーノ・ダ・シウバ,エンゴロ・カンテ,マテオ・コヴァチッチ,ロメル・ルカク,クリスチャン・プリシッチ,ティモ・ヴェルナー,ルーベン・ロフタス＝チーク,マーカス・ベッティネッリ," +
                        "トレヴォ・チャロバー,エドゥアール・メンディ,サウール・ニゲス,ロス・バークリー,メイソン・マウント,カラム・ハドソン＝オドイ,ベン・チルウェル,ハキム・ツィエク,リース・ジェームズ_(1999年生のサッカー選手),セサル・アスピリクエタ,カイ・ハフェルツ,マラング・サール,ルイス・ベイカー";
                    break;
                case "トッテナム":
                    TeamMenber = "ウーゴ・ロリス,マット・ドハーティ,セルヒオ・レギロン,クリスティアン・ロメロ,ピエール・エミール・ホイビュルク,ダビンソン・サンチェス,孫興ミン,ハリー・ウィンクス,ハリー・ケイン,ブライアン・ヒル・サルバティエラ,エメルソン・アパレシド・レイテ・デ・ソウザ・ジュニオール,ジョー・ロドン,エリック・ダイアー,ジオヴァニ・ロ・チェルソ," +
                        "ライアン・セセニョン,デレ・アリ,ピエルルイジ・ゴッリーニ,ステーフェン・ベルフワイン,ジャフェット・タンガンガ,ルーカス・ロドリゲス・モウラ・ダ・シルヴァ,タンギ・エンドンベレ,オリヴァー・スキップ,ベン・デイヴィス_(1993年生のサッカー選手),デーン・スカーレット,ジャック・クラーク_(サッカー選手)";
                    break;
                case "ウェストハム":
                    TeamMenber = "";
                    break;
                case "ウルブス":
                    TeamMenber = "";
                    break;
                case "ブライトン":
                    TeamMenber = "";
                    break;
                case "レスターシティ":
                    TeamMenber = "";
                    break;
                case "サウサンプトン":
                    TeamMenber = "";
                    break;
                case "クリスタル・パレスアストン・ヴィラ":
                    TeamMenber = "";
                    break;
                case "ブレントフォード":
                    TeamMenber = "";
                    break;
                case "アストン・ヴィラ":
                    TeamMenber = "";
                    break;
                case "エヴァートン":
                    TeamMenber = "";
                    break;
                case "リーズU":
                    TeamMenber = "";
                    break;
                case "ワトフォード":
                    TeamMenber = "";
                    break;
                case "ニューカッスル":
                    TeamMenber = "";
                    break;
                case "バーンリー":
                    TeamMenber = "";
                    break;
                case "ノリッジ":
                    TeamMenber = "";
                    break;

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
