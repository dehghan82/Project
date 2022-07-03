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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1()
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

        private void enter(object sender, RoutedEventArgs e)
        {
            try
            {


                if (user.checkuser(user_name.Text, password.Password) == true)
                {

                    
                    userdashboard userdashboard = new userdashboard();
                    userdashboard.Show();
                    this.Close();
                }
                else
                {
                    throw new Exception("The information is wrong.you cant enter.");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message) ;
            }
        }
    }
}
