using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int ramd = 0;
        int select = 0;
        public MainWindow()
        {
            InitializeComponent();
            ramdom(1, 21);
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

            select = int.Parse((string)bt.Content);



            if (ramd == select)
            {
                tbAns.Text ="正解です";
            }
            else if (ramd >select)
            {
                tbAns.Text = "値が小さいです";
            }
            else if(ramd < select)
            {
                tbAns.Text = "値が大きいです";
            }
            

            
        }

    }
}
