using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
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

        private void show_signin(object sender, RoutedEventArgs e)
        {

            try
            {

                string khata = "";
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


                     user cust = new user(username.Text, pass.Password, name.Text, phone.Text);



                    Window1 window1 = new Window1();
                    window1.Show();
                   // user.checkusers(cust);
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
