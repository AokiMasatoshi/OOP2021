using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int ramd = 0;
        DispatcherTimer dispatcherTimer;    // タイマーオブジェクト
        DateTime st;                 // カウント開始時刻
        TimeSpan nts;               // Startボタンが押されてから現在までの経過時間
        TimeSpan ots;

        public MainWindow()
        {
            InitializeComponent();
            ramdom(1, 26);
            lb1.Content = "00:00:000";
            // タイマーのインスタンスを生成
            dispatcherTimer = new DispatcherTimer(DispatcherPriority.Normal);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            // タイマー開始
            TimerStart();
        }
        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            nts = DateTime.Now.Subtract(st);
            lb1.Content = ots.Add(nts).ToString(@"mm\:ss\:fff");
        }
        private void TimerStart()
        {
            st = DateTime.Now;
            dispatcherTimer.Start();
        }

        // タイマー操作：停止
        private void TimerStop()
        {
            ots = ots.Add(nts);
            dispatcherTimer.Stop();
        }

        public void ramdom(int min,int max)
        {
            Random r1 = new System.Random();
            ramd = r1.Next(min,max);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = e.Source as Button;
            bt.Background = Brushes.Aquamarine;

            int select = int.Parse((string)bt.Content);



            if (ramd == select)
            {
                tbAns.Text ="正解です";
                TimerStop();


            }
            else if (ramd >select)
            {
                tbAns.Text = "大きいです";
            }
            else if(ramd < select)
            {
                tbAns.Text = "小さいです";
            }
            

            
        }

    }
        
}
