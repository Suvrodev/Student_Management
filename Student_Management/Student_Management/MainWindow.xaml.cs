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
using MySql.Data.MySqlClient;

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

            String id="", pass="";


            /////Data Retrive//////////
            String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
           // String Query = "SELECT `"+ID+"`, `"+Password+"`  FROM `admin` WHERE ID='"+ID+"';";
            String Query =" SELECT * FROM `admin` WHERE ID = '"+ID+"'";


            MySqlConnection mycon = new MySqlConnection(Connection);
            MySqlCommand myCom = new MySqlCommand(Query, mycon);

            MySqlDataReader reader;
            mycon.Open();
            reader = myCom.ExecuteReader();
            while (reader.Read())
            {
                 id =Convert.ToString(reader[0]);
                 pass = Convert.ToString(reader[12]);

               
               // Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4]);

            }

            
            mycon.Close();

            if(ID==id && Password == pass)
            {
                After_Login a = new After_Login();
                a.Show();
                this.Close();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("ID or Password Not matched");
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
