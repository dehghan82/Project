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
using System.Text.RegularExpressions;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void MainWindow_OnMousedown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void admin_signin(object sender, RoutedEventArgs e)
        {
            try
            {
               
                string khata="";
                string pattern = @"^[09][0-9]{9}";
              
                if (pass.Password != password.Password)
                {
                    
                    khata += "passwords doesnt match.\n";
                    
                }
                 if (pass.Password == "" || password.Password == "" || username.Text == "" || name.Text == "" || phone.Text == "")
                {
                    
                    khata += "please fill all the fields.\n";
                   
                }
                if (!Regex.IsMatch(phone.Text, pattern))
                {
                    
                    khata += "your phone number is not valid.\n";
                    
                }
                if (name.Text.Length < 3 || name.Text.Length > 32 || Regex.IsMatch(name.Text, @"[a-zA-Z]") == false)
                {
                  
                    khata += "name is not valid.\n";
                    
                }
                if (Regex.IsMatch(username.Text, @"^([\w\.\-]{1,32})@([\w\-]{1,32})((\.(\w){1,32})+)$") == false)
                {
                    
                    khata += "email is not valid.\n";
                    
                }
                if (Regex.IsMatch(pass.Password, @"^(?=.*?[A-Z])(?=.*?[a-z]).{8,40}") == false)
                {
                    
                    khata += "password is not valid.\n";
                    
                }
                if (khata != "")
                {
                    throw new Exception(khata);
                }
                else
                {


                    admin admin = new admin(username.Text, pass.Password, name.Text, phone.Text);
                    Window2 window2 = new Window2();
                    window2.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
    }
}
