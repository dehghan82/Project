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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void open_windowuser(object sender, RoutedEventArgs e)
        {

            Window1 firstwindow = new Window1();
            firstwindow.Show();
            this.Close();
        }

        private void open_windowadmin(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();

        }
        //public partial class Window1 : Window
        //{
        //    public Window1()
        //    {
        //       InitializeComponent();
        //    }

        //}
        //public partial class Window2 : Window
        //{
        //    public Window2()
        //    {
        //        InitializeComponent();
        //    }
        //}

    }
}
