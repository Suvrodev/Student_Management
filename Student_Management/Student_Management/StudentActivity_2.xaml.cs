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

/////
using System.Data;
using MySql.Data.MySqlClient;

namespace Student_Management
{
    /// <summary>
    /// Interaction logic for StudentActivity_2.xaml
    /// </summary>
    public partial class StudentActivity_2 : Window
    {
        public String Get_ID = "";

        public StudentActivity_2()
        {
            InitializeComponent();
        }

        private void Show_btn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Get_ID);
            String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
            String Query = "";
            
            Query = "SELECT students.Department,students.Semester,course.Name,course.C_Teacher FROM students INNER JOIN course ON students.Semester = course.Semester WHERE students.ID='"+Get_ID+"' ;";

            MySqlConnection mycon = new MySqlConnection(Connection);
            MySqlCommand myCom = new MySqlCommand(Query, mycon);
            mycon.Open();

            MySqlDataAdapter adp = new MySqlDataAdapter(myCom);
            DataTable dt = new DataTable("admin");
            adp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            adp.Update(dt);
            mycon.Close();

            //  MessageBox.Show(Department + "\n" + Semester + "\n" + Section + "\n" + Sex + "\n" + Religion);
        }

        private void Back_Button(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
    }
}
