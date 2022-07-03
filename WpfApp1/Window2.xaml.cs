﻿using System;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        admin admin;
        public Window2(admin admin)
        {   
            this.admin = admin;
            InitializeComponent();
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void enter_admin(object sender, RoutedEventArgs e)
        {
            try
            {


                if (admin.checkadmin(user_name.Text, password.Password) == true)
                {


                    //userdashboard userdashboard = new userdashboard(obj);
                   //admindashboard admindashboard=new admindashboard(admin)
                   // admindashboard.Show();
                    this.Close();
                }
                else
                {
                    throw new Exception("The information is wrong.you cant enter.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
