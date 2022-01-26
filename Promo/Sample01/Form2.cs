﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample01
{
    public partial class Form2 : Form
    {
        readonly CountdownEvent condition = new CountdownEvent(1);
        private static Form1 _instance1;
        public string[] SplitMenberName;
        public string TeamMenber;
        private string Selectteam;
        private string u = "http://ja.wikipedia.org/wiki/";
        //
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
        //async void InitializeAsync()
        //{
            //await wv2.EnsureCoreWebView2Async(null);
            //wv2.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
        //}

        private void CoreWebView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            //読み込み結果を判定
            if (e.IsSuccess)
                Console.WriteLine("complete");
            else
                Console.WriteLine(e.WebErrorStatus);

            //シグナル初期化
            condition.Signal();
            System.Threading.Thread.Sleep(1);
            condition.Reset();
        }

        private void SerectTeamManber()
        {
            switch (Selectteam)
            {
                case"リヴァプール":

                    TeamMenber = "アリソン・ラムセス・ベッカー,ファビオ・エンリケ・タバレス,フィルジル・ファン・ダイク,イブラヒマ・コナテ,ティアゴ・アルカンタラ・ド・ナシメント,ジェイムズ・ミルナー,ナビ・ケイタ,ロベルト・フィルミーノ・バルボーサ・デ・オリヴェイラ,ジョー・ゴメス,アドリアン・サン・ミゲル・カスティージョ,ジョーダン・ヘンダーソン,アレックス・オックスレイド＝チェンバレン" +
                        ",カーティス・ジョーンズ,南野拓実,ディオゴ・ジョッタ,コスタス・ツィミカス,ロリス・カリウス,アンドリュー・ロバートソン_(サッカー選手),ディヴォック・オリジ,ジョエル・マティプ,ナサニエル・フィリップス,クィービーン・ケレハー,トレント・アレクサンダー＝アーノルド,ハーヴェイ・エリオット,ネコ・ウィリアムズ";
                    BackgroundImage = Properties.Resources.Liverpool;
                    break;
                case "マンチェスターシティ":
                    TeamMenber = "カイル・ウォーカー,ルベン・ディアス,ジョン・ストーンズ,ナタン・アケ,ラヒーム・スターリング,イルカイ・ギュンドアン,ガブリエウ・フェルナンド・ジ・ジェズス,ジャック・グリーリッシュ,オレクサンドル・ジンチェンコ,ザック・ステッフェン,アイメリク・ラポルテ,ロドリゴ・エルナンデス,ケヴィン・デ・ブライネ,ベルナルド・シウバ,バンジャマン・メンディ," +
                        "フェルナンド・ルイス・ローザ,リヤド・マフレズ,ジョアン・カンセロ,エデルソン・サンタナ・ジ・モライス,スコット・カーソン,フィル・フォーデン";
                    BackgroundImage = Properties.Resources.ManC;
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
                    TeamMenber = "ウカシュ・ファビアンスキ,アーロン・クレスウェル,クル・ズマ,ヴラディミール・ツォウファル,アンドリー・ヤルモレンコ,パブロ・フォルナルス,マイケル・アントニオ,マヌエル・ランシニ,ニコラ・ヴラシッチ,アルフォンス・アレオラ,クレイグ・ドーソン,マーク・ノーブル,ジャロッド・ボーウェン,アンジェロ・オグボンナ,サイード・ベンラーマ," +
                        "イッサ・ディオプ,ライアン・フレデリックス,デイビッド・マーティン,アルトゥール・マスアク,トマーシュ・ソウチェク,ベン・ジョンソン_(サッカー選手),アレックス・クラール,ダレン・ランドルフ,デクラン・ライス";
                    break;
                case "ウルブス":
                    TeamMenber = "ジョゼ・サ,キ＝ヤナ・フーフェル,ラヤン・アイト＝ヌーリ,フェルナンド・マルサウ・オリヴェイラ,ブルーノ・ジョルダン,ペドロ・ネト,ルベン・ネヴェス,ラウル・ヒメネス,ダニエル・ポデンセ,フランシスコ・トリンコン,ウィリー・ボリー,コナー・コーディ,ファビオ・シルヴァ,ホニー・カストロ・オット," +
                        "フランシスコ・ジョルジェ・タヴァレス・オリヴェイラ,ジョン・ラディ,ネルソン・セメド,黄喜燦,ロマン・サイス,ジョアン・モウティーニョ,レアンデル・デンドンケル,ライアン・ジャイルズ,アダマ・トラオレ_(1996年生のサッカー選手),川辺駿";
                    break;
                case "ブライトン":
                    TeamMenber = "ロベルト・サンチェス,タリク・ランプティ,マルク・ククレジャ,アダム・ウェブスター,ルイス・ダンク,イヴ・ビスマ,ニール・モペイ,アレクシス・マック・アリスター,レアンドロ・トロサール,エノック・ムウェプ,パスカル・グロス,アダム・ララーナ,ヤクブ・モデル,キエル・スヘルペン,スティーブン・アルザテ," +
                        "ダニー・ウェルベック,ソロモン・マーチ,ジェイソン・スティール,シェイン・ダフィー,モイセス・カイセド,ダン・バーン,ジョエル・フェルトマン,トゥドゥール・バルツァ";
                    break;
                case "レスターシティ":
                    TeamMenber = "カスパー・シュマイケル,ジェームス・ジャスティン,ウェズレイ・フォファナ,チャーラル・ソユンジュ,ライアン・バートランド,ジョニー・エヴァンズ,ハーヴィー・バーンズ,ユーリ・ティーレマンス,ジェイミー・ヴァーディ,ジェームズ・マディソン_(サッカー選手),マーク・オルブライトン,ダニー・ウォード_(ウェールズのサッカー選手),ケレチ・イヘアナチョ,アジョセ・ペレス," +
                        "ダニエル・アマーティ,ハムザ・チョードゥリー,リカルド・ドミンゴス・バルボサ・ペレイラ,キアナン・デューズバリー＝ホール,ヤニク・ヴェスターゴーア,ナンパリス・メンディ,ウィルフレッド・ディディ,ティモシー・カスターニュ,パトソン・ダカ,ルーク・トーマス,エルディン・ヤクポヴィッチ,アデモラ・ルックマン,ブバカリ・スマレ,タナワット・スエンチッタウォン";
                    break;
                case "サウサンプトン":
                    TeamMenber = "アレックス・マッカーシー,カイル・ウォーカー＝ピータース,リャンコ・エヴァンジェリスタ・シウヴェイラ・ネヴェス・ヴォイノヴィッチ,ジャック・スティーヴンス,オリオール・ロメウ,シェーン・ロング,ジェームズ・ウォード＝プラウズ,アダム・アームストロング,チェ・アダムス,ネイサン・レドモンド,ウィルフレード・カバジェロ,ロマン・ペロー,ティエリー・スモール," +
                        "スチュアート・アームストロング,アルマンド・ブロヤ,ムサ・ジェネポ,ティノ・リヴラメント,モハメド・サリス,ネイサン・テラ,モハメド・エルユヌシ,イブラヒマ・ディアロ,セオ・ウォルコット,ヤン・ベドナレク,ヤン・ヴァレリー,フレイザー・フォースター";
                    break;
                case "クリスタル・パレス":
                    TeamMenber = "ジャック・バトランド,ジョエル・ウォード_(サッカー選手),タイリック・ミッチェル,ルカ・ミリヴォイェヴィッチ,ジェームズ・トムキンス,ミカエル・オリーズ,シェイフ・クヤテ,ジョルダン・アイェウ,エベレチ・エゼ,ウィルフレッド・ザハ,ウィル・ヒューズ,ビセンテ・グアイタ," +
                        "ジャン＝フィリップ・マテタ,ジェフリー・シュルップ,ヨアキム・アンデルセン,クリスティアン・ベンテケ,オドソンヌ・エドゥアール,コナー・ギャラガー,マーティン・ケリー,ネイサン・ファーガソン_(2000年生のサッカー選手),ヤイロ・リーデヴァルト";
                    break;
                case "ブレントフォード":
                    TeamMenber = "ダビド・ラヤ,ドミニク・トンプソン,リコ・ヘンリー,チャーリー・グッド,イーサン・ピノック,クリスティアン・ノアゴール,セルジ・カノス,マティアス・イェンセン,マルクス・フォルス,ジョシュ・ダシルヴァ,ヨアヌ・ウィサ,サマン・ゴドス,フランク・オニェカ," +
                        "イヴァン・トニー,ポントゥス・ヤンソン,ブライアン・ムベウモ,クリストフェル・アイェル,マティアス・ヨルゲンセン,ジュリアン・ジャンヴィエ,シャンドン・バプティスト,ヴィタリー・ヤネルト,マッズ・ビストルップ,マッツ・ベック・セーレンセン,マッツ・ルアスレウ,ルカ・ラチッチ,アルバロ・フェルナンデス・ジョレンテ,ヨナス・レッスル";
                    break;
                case "アストン・ヴィラ":
                    TeamMenber = "エミリアーノ・マルティネス,マティ・キャッシュ,マット・ターゲット,エズリ・コンサ,タイロン・ミングス,ドウグラス・ルイス・ソアレス・デ・パウロ,ジョン・マッギン,モルガン・サンソン,エミリアーノ・ブエンディア,オリー・ワトキンス,ジェッド・スティアー,ベルトラン・トラオレ," +
                        "マフムード・ハッサン_(サッカー選手),アシュリー・ヤング,マーヴェラス・ナカンバ,ダニー・イングス,フィリペ・コウチーニョ・コレイア,リュカ・ディニュ,コートニー・ホース,レオン・ベイリー,カーニー・チュクエメカ,ジェイコブ・ラムジー,ロビン・オルセン";
                    break;
                case "エヴァートン":
                    TeamMenber = "ジョーダン・ピックフォード,ジョンジョー・ケニー,ネイサン・パターソン,メイソン・ホルゲート,マイケル・キーン,アラン・マルケス・ロウレイロ,リシャルリソン・デ・アンドラーデ,ファビアン・デルフ,ドミニク・キャルバート＝ルーウィン,ギルフィ・シグルズソン,デマレイ・グレイ,ジェリー・ミナ,アンドロス・タウンゼント," +
                        "アスミル・ベゴヴィッチ,アブドゥライェ・ドゥクレ,アレックス・イウォビ,ヴィタリー・ミコレンコ,ジェンク・トスン,アンドレ・ゴメス,ベン・ゴッドフリー,シェイマス・コールマン,アンソニー・ゴードン,ジャン＝フィリップ・グバミン,トム・デイヴィス,アンディ・ロナーガン,ジャラッド・ブランスウェイト,ホセ・サロモン・ロンドン,アンワル・エル・ガジ";
                    break;
                case "リーズU":
                    TeamMenber = "イラン・メリエ,ルーク・アイリング,ジュニオル・フィルポ,アダム・フォーショー,ロビン・コッホ,リアム・クーパー,パトリック・バンフォード,ハファエウ・ジアス・ベローリ,タイラー・ロバーツ,クリストファー・クラーソン,ディエゴ・ジョレンテ,スチュアート・ダラス,ロドリゴ・モレノ・マチャド," +
                        "ダニエル・ジェームズ,パスカル・ストライク,ジャック・ハリソン,カルバン・フィリップス,クリセンシオ・サマーフィルマテウシュ・クリヒ,ジェイミー・シャクルトン";
                    break;
                case "ワトフォード":
                    TeamMenber = "ベン・フォスター_(サッカー選手),ジェレミー・エンガキア,ダニー・ローズ,オゲネカロ・エテボ,ウィリアム・トロースト＝エコング,ジョシュア・キング,トム・クレヴァリー,ジョアン・ペドロ・ジュンケイラ・ジ・ジェズス,アダム・マジーナ,ケン・セマ,ニコラ・ヌクル,クレイグ・キャスカート,ダン・ゴスリング,アシュリー・フレッチャー,オザン・トゥファン," +
                        "ムサ・シソコ,フランシスコ・フェメニア,サミル・カエターノ・デ・ソウザ・サントス,イスマイラ・サール,エマヌエル・ボナヴェントゥレ・デニス,ダニエル・バッハマン,クリスティアン・カバセレ,クチョ・エルナンデス,フランシスコ・シエルラルタ,ユライ・クツカ,ロブ・エリオット";
                    break;
                case "ニューカッスル":
                    TeamMenber = "マルティン・ドゥブラフカ,キアラン・クラーク,ポール・ダメット,マシュー・ロングスタッフ,ファビアン・シェア,ジャマール・ラスセルズ,ジョエリントン・カッシオ・アポリナリオ・デ・リラ,ジョンジョ・シェルヴェイ,カラム・ウィルソン_(イングランドのサッカー選手),アラン・サン＝マクシマン,マット・リッチー,ジャマール・ルイス_(サッカー選手),アイザック・ヘイデン,キーラン・トリッピアー," +
                        "ジェフ・ヘンドリック,エミル・クラフト,フェデリコ・フェルナンデス,ハビエル・マンキージョ・ガイタン,クリス・ウッド,ライアン・フレイザー,ジェイコブ・マーフィー,ミゲル・アルミロン,カール・ダーロウ,フレディ・ウッドマン,ジョー・ウィロック,ドワイト・ゲイル,ショーン・ロングスタッフ";
                    break;
                case "バーンリー":
                    TeamMenber = "ニック・ポープ,マシュー・ロートン,チャーリー・テイラー_(サッカー選手),ジャック・コーク,ジェームス・ターコウスキー,ベン・ミー,ヨーハン・ベルク・グズムンドソン,ジョシュ・ブラウンヒル,アシュリー・バーンズ,ドワイト・マクニール,ウェイン・ヘネシー,コナー・ロバーツ,デール・スティーブンス,アーロン・レノン,アシュリー・ウェストウッド,ジェイ・ロドリゲス,マクスウェル・コルネ,ネイサン・コリンズ," +
                        "エリック・ピーテルス,フィル・バーズリー,マチェイ・ヴィドラ,ケビン・ロング";
                    break; 
                case "ノリッジ":
                    TeamMenber = "ティム・クルル,マックス・アーロンズ,サム・バイラム,ベン・ギブソン,グラント・ハンリー,クリストフ・ツィマーマン,ルーカス・ルップ,ビリー・ギルモア,キーラン・ダウエル,プシェミスワフ・プワヘタ,トッド・キャントウェル,オザン・カバク,マティアス・ノルマン,ミロト・ラシツァ,フリストス・ツォリスヤコブ・ソーレンセン,ピエール・レース＝メル," +
                        "ブランドン・ウィリアムズ,テーム・プッキ,ケニー・マクリーン,ジョシュ・サージェント,アンガス・ガン,ディミトリス・ヤヌリス,マイケル・マクガヴァン,アダム・アイダ,アンドリュー・オモバミデレ";
                    break;

            }
        }

        private void lbPL_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private  void lbPL_MouseClick(object sender, MouseEventArgs e)
        {
            //string result = "";
            string WikiURL = u + SplitMenberName[lbPL.SelectedIndex];
            wb1.ScriptErrorsSuppressed = true;
            Uri URL = new Uri(WikiURL);
            wb1.Url = URL;
            //wv2.CoreWebView2.Navigate(WikiURL);
        //    await Task.Run(() =>
        //    {
        //        //読み込み完了まで待機
        //        if (condition.Wait(5000))
        //            result = "ok";
        //        else
        //            result = "timeout";
        //    });

        //    MessageBox.Show(result);
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
            Instance1.ShowDialog();
        }
    }
}
