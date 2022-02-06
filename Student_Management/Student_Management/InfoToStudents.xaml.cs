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
    /// Interaction logic for InfoToStudents.xaml
    /// </summary>
    public partial class InfoToStudents : Window
    {
        public String ID = "", Department = "", Semester = "";
    

        public InfoToStudents()
        {
            InitializeComponent();
        }

        private void Update_Click_btn(object sender, RoutedEventArgs e)
        {
            String Student_Message = "";
            /////Data Retrive//////////
            String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
            // String Query = "SELECT `"+ID+"`, `"+Password+"`  FROM `admin` WHERE ID='"+ID+"';";
            String Query = " SELECT  * FROM `message` WHERE id='dean'";


            MySqlConnection mycon = new MySqlConnection(Connection);
            MySqlCommand myCom = new MySqlCommand(Query, mycon);

            MySqlDataReader reader;
            mycon.Open();
            reader = myCom.ExecuteReader();
            while (reader.Read())
            {
                if (Semester == "1_1")
                {
                    Student_Message = Convert.ToString(reader[2]);
                    break;
                }
                if (Semester == "1_2")
                {
                    Student_Message = Convert.ToString(reader[3]);
                    break;
                }
                if (Semester == "1_3")
                {
                    Student_Message = Convert.ToString(reader[4]);
                    break;
                }
                if (Semester == "2_1")
                {
                    Student_Message = Convert.ToString(reader[5]);
                    break;
                }
                if (Semester == "2_2")
                {
                    Student_Message = Convert.ToString(reader[6]);
                    break;
                }
                if (Semester == "2_3")
                {
                    Student_Message = Convert.ToString(reader[7]);
                    break;
                }
                if (Semester == "3_1")
                {
                    Student_Message = Convert.ToString(reader[8]);
                    break;
                }
                if (Semester == "3_2")
                {
                    Student_Message = Convert.ToString(reader[9]);
                    break;
                }
                if (Semester == "3_3")
                {
                    Student_Message = Convert.ToString(reader[10]);
                    break;
                }
                if (Semester == "4_1")
                {
                    Student_Message = Convert.ToString(reader[11]);
                    break;
                }
                if (Semester == "4_2")
                {
                    Student_Message = Convert.ToString(reader[12]);
                    break;
                }
                if (Semester == "4_3")
                {
                    Student_Message = Convert.ToString(reader[13]);
                    break;
                }

            }
            mycon.Close();

            dean_msg.Text = Student_Message;


            //////////////////////////////////

           // String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
           // String Query = "";

            Query = "SELECT T_N,3_2 FROM `message` WHERE  "+Semester+"  !=''";

             mycon = new MySqlConnection(Connection);
             myCom = new MySqlCommand(Query, mycon);
            mycon.Open();

            MySqlDataAdapter adp = new MySqlDataAdapter(myCom);
            DataTable dt = new DataTable("admin");
            adp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            adp.Update(dt);
            mycon.Close();
        }
    }
}
