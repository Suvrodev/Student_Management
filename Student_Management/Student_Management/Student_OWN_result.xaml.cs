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

using System.Data;
using MySql.Data.MySqlClient;

namespace Student_Management
{
    /// <summary>
    /// Interaction logic for Student_OWN_result.xaml
    /// </summary>
    public partial class Student_OWN_result : Window
    {
        public String Get_ID = "", Get_Semester = "";

        public Student_OWN_result()
        {
            InitializeComponent();
        }

        private void Show_btn(object sender, RoutedEventArgs e)
        {






            String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
            String Query = "";

            Query = "SELECT * FROM `result` WHERE id='"+Get_ID+"' AND Payment='Paid'";

            MySqlConnection mycon = new MySqlConnection(Connection);
            MySqlCommand myCom = new MySqlCommand(Query, mycon);
            mycon.Open();

            MySqlDataAdapter adp = new MySqlDataAdapter(myCom);
            DataTable dt = new DataTable("admin");
            adp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            adp.Update(dt);
            mycon.Close();
        }

        private void Back_Button(object sender, RoutedEventArgs e)
        {

        }
    }
}
