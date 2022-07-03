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

namespace WpfApp1.mvvm.view
{
    /// <summary>
    /// Interaction logic for profileviewer.xaml
    /// </summary>
    public partial class profileviewer : UserControl
    {
        user obj;

        public profileviewer(user obj)
        {   this.obj = obj; 
            InitializeComponent();
        }
        public void meghdardehi()
        {
            name.Text = obj.name;
            username.Text = obj.user_name;
            phone.Text = obj.phone_number;
            mojodi.Text = obj.mojodi.ToString();

        }
    }
}
