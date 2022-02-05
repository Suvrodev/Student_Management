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
using MySql.Data.MySqlClient;

namespace Student_Management
{
    /// <summary>
    /// Interaction logic for Student_Activity.xaml
    /// </summary>
    public partial class Student_Activity : Window
    {
        public Student_Activity()
        {
            InitializeComponent();

           // tb_fname.Text = "Your Name";
           
        }

        private void Update_Click_btn(object sender, RoutedEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Do you Update Information?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            switch (m)
            {
                //1st case
                case MessageBoxResult.Yes:
                    /////Update Data////

                    String ID = tb.Text;
                    String Phn = tbx_phn.Text;
                    String Mail = tbx_mail.Text;
                    String loc = tbx_loc.Text;

                    String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
                    String Query = "UPDATE `students` SET `phn`= '"+Phn+"',`mail`= '"+Mail+"',`location`= '"+loc+"' WHERE ID = '"+ID+"'";



                    MySqlConnection mycon = new MySqlConnection(Connection);
                    MySqlCommand myCom = new MySqlCommand(Query, mycon);
                    mycon.Open();
                    MySqlDataReader reader = myCom.ExecuteReader(); ;
                    mycon.Close();
                    MessageBoxResult result = MessageBox.Show("Data Updated Successfully");


                    ///Update Data Close///

                    break;

                //2nd Case
                case MessageBoxResult.No:
                    break;
            }
           
        }

        private void Update_Password(object sender, RoutedEventArgs e)
        {
            String ID = tb.Text;
            String Password = tbx_oldpass.Text;
            String New_Password = tbx_new_pass.Text;
            String Retype_New_Password = tbx_new_rpass.Text;

            String Get_Password = "";

            MessageBoxResult m = MessageBox.Show("Do you Update Password?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            switch (m)
            {
                //1st case
                case MessageBoxResult.Yes:
                    /////Update Password////


                    String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
                    String Query = " SELECT * FROM `students` WHERE ID = '" + ID + "'";
                    MySqlConnection mycon = new MySqlConnection(Connection);
                    MySqlCommand myCom = new MySqlCommand(Query, mycon);

                    MySqlDataReader reader;
                    mycon.Open();
                    reader = myCom.ExecuteReader();
                    while (reader.Read())
                    {    
                               
                        Get_Password = Convert.ToString(reader[14]);
            
                    }
                    mycon.Close();

                    if (Get_Password == Password)
                    {
                        //MessageBoxResult result = MessageBox.Show("Old Password is correct" + Get_Password);
                         if (New_Password.Length >= 6)
                         {
                             if (New_Password == Retype_New_Password)
                             {
                                 String Connections = "Server=127.0.0.1;User ID=root; DataBase=project";
                                 String Querys = "UPDATE `students` SET `password`='"+New_Password+"' WHERE ID='"+ID+"';";



                                 MySqlConnection mycons = new MySqlConnection(Connections);
                                 MySqlCommand myComs = new MySqlCommand(Querys, mycons);
                                 mycons.Open();
                                 MySqlDataReader readerss = myComs.ExecuteReader(); 
                                 mycons.Close();
                                 MessageBoxResult result = MessageBox.Show("Password Updated Successfully");

                                 ///Update Password Close///
                             }
                             else
                             {
                                 MessageBoxResult result = MessageBox.Show("Password Not Matched ");
                             }
                         }
                         else
                         {
                             MessageBoxResult result = MessageBox.Show("Password Should be 6 digit or more");
                         }
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Old Password is not correct"+Get_Password);
                    }
                   
                    ///Update Password Data Close///

                    break;

                //2nd Case
                case MessageBoxResult.No:
                    break;
            }

        }

        private void Course(object sender, RoutedEventArgs e)
        {
            String ID = tb.Text;
            StudentActivity_2 s = new StudentActivity_2();
            s.Get_ID = ID;
            s.Show();
            this.Close();
        }
    }
}
