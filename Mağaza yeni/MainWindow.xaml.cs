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
using System.Windows.Threading;


namespace Mağaza_yeni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += new EventHandler(timer_Tick);
            timer.IsEnabled = true;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 3)
            {
                i = 1;
            }
            SlideShow(i);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            i = 1;
            SlideShow(i);
        }
        private void SlideShow(int i)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            string filename = ((i < 10) ? "slide/sl0" + i + ".jpg" : "slide/sl" + i + ".jpg");
            image.UriSource = new Uri(filename, UriKind.Relative);
            image.EndInit();
            slide.Source = image;
            slide.Stretch = Stretch.Uniform;
        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void geri_Click(object sender, RoutedEventArgs e)
        {
            bezsucuk.Visibility = Visibility.Visible;
            bal.Visibility = Visibility.Visible;
            uzumpekmezi.Visibility = Visibility.Visible;
            sofrabezi.Visibility = Visibility.Visible;

            yaprak10kg.Visibility = Visibility.Hidden;
            yaprak5kg.Visibility = Visibility.Hidden;
            ekmek.Visibility = Visibility.Hidden;
            visnereceli.Visibility = Visibility.Hidden;
        }

        private void ileri_Click(object sender, RoutedEventArgs e)
        {
            bezsucuk.Visibility = Visibility.Hidden;
            bal.Visibility = Visibility.Hidden;
            uzumpekmezi.Visibility = Visibility.Hidden;
            sofrabezi.Visibility = Visibility.Hidden;

            yaprak10kg.Visibility = Visibility.Visible;
            yaprak5kg.Visibility = Visibility.Visible;
            ekmek.Visibility = Visibility.Visible;
            visnereceli.Visibility = Visibility.Visible;


        }

        private void Anasayfa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sepetim_Click(object sender, RoutedEventArgs e)
        {

        }

        private void magaza_Click(object sender, RoutedEventArgs e)
        {

        }

        private void iletişim_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sepet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ara_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Anasayfa_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Mağaza_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Blog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hakkımızda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sepetim_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Hesabım_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GirisYap_Click(object sender, RoutedEventArgs e)
        {

        }

        private void KayıtOl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hediyelik_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gıda_urunleri_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sirke_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sarküteri_Click(object sender, RoutedEventArgs e)
        {

        }

        private void süt_ürün_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bakliyat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void salcavesos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tümünü_Click(object sender, RoutedEventArgs e)
        {

        }

        private void balbuton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uzumpekmezibuton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sepetekleuzumpekmezi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void sepeteklesofrabezi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sofrabezibuton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bezsucukbuton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sepeteklebezsucuk_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
