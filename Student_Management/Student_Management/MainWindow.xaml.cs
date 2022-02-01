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

namespace Student_Management
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

        private void Login_Click_btn(object sender, RoutedEventArgs e)
        {
            String ID = ID_Box.Text;
            String Password = Pass_Box.Password;

            if(ID=="abc" && Password == "123")
            {
                After_Login a = new After_Login();
                a.Show();
                this.Close();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Wrong ID or Password");
            }
        }

        private void Reset_btn(object sender, RoutedEventArgs e)
        {
            //String ID, Password;
           ID_Box.Text="";
           Pass_Box.Password="";

        }


        private void ID_Box_focus(object sender, RoutedEventArgs e)
        {
            ID_Box.Text = "";
        }


        private void Registration_btn_click(object sender, RoutedEventArgs e)
        {
            Admin_Registration a = new Admin_Registration();
            a.Show();
            this.Close();
        }
    }
}
