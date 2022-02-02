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
    /// Interaction logic for StudentViewSetting.xaml
    /// </summary>
    public partial class StudentViewSetting : Window
    {
        public StudentViewSetting()
        {
            InitializeComponent();
        }

        private void modify_btn(object sender, RoutedEventArgs e)
        {
            String ID = ID_box.Text;
        

            if (ID_box.Text == "")
            {
                MessageBoxResult result = MessageBox.Show("Invalid ID");
            }
            else
            {
                ////////////////////////
                String FName = FName_Box.Text;
                String LName = LName_Box.Text;
                String Age = Age_box.Text;
                String Email = mail_box.Text;
                String Phone = Phn_Box.Text;
                String Location = Loc_box.Text;
                String Password = pass_box.Text;
                String CGPA = cgpa_box.Text;
                String DOB = dob_box.Text;
                String Sex = "";



                if (RB_Male.IsChecked == true)
                {
                    Sex = "Male";
                }
                else if (RB_Female.IsChecked == true)
                {
                    Sex = "Female";
                }
                else if (RB_Other.IsChecked == true)
                {
                    Sex = "other";
                }
                var Religion_Temp = (ComboBoxItem)comboBox_rl.SelectedItem;
                String Religion = (String)Religion_Temp.Content;


                var Department_Temp = (ComboBoxItem)comboBox_dprtmnt.SelectedItem;
                String Department = (String)Department_Temp.Content;

                var Semester_Temp = (ComboBoxItem)comboBox_semester.SelectedItem;
                String Semester = (String)Semester_Temp.Content;

                var Section_Temp = (ComboBoxItem)comboBox_section.SelectedItem;
                String Section = (String)Section_Temp.Content;
                ////////////////////////
                MessageBoxResult m = MessageBox.Show("Do you Really modify Data?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                switch (m)
                {
                    //1st case
                    case MessageBoxResult.Yes:
                        /////Update Data////

                        String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
                        String Query = "UPDATE `students` SET `ID`='"+ID+ "',`fname`='"+FName+ "',`lname`='"+LName+ "',`age`='"+Age+ "',`sex`='"+Sex+ "',`religion`='"+Religion+ "',`Department`='"+Department+ "',`Semester`='"+Semester+ "',`Section`='"+Section+ "',`cgpa`='"+CGPA+ "',`phn`='"+Phone+ "',`mail`='"+Email+ "',`dob`='"+DOB+ "',`location`='"+Location+ "',`password`='"+Password+"' WHERE id='" + ID+"';";



                        MySqlConnection mycon = new MySqlConnection(Connection);
                        MySqlCommand myCom = new MySqlCommand(Query, mycon);
                        mycon.Open();
                        MySqlDataReader reader = myCom.ExecuteReader(); ;
                        mycon.Close();
                        MessageBoxResult result = MessageBox.Show("ID updated Successfully");


                        ///Update Data Close///

                        break;

                    //2nd Case
                    case MessageBoxResult.No:
                        break;
                }
            }

        }


        private void Delete_btn(object sender, RoutedEventArgs e)
        {
            String ID = ID_box.Text;
            if (ID == "")
            {
                MessageBoxResult result = MessageBox.Show("Invalid ID");
            }
            else {
                MessageBoxResult m = MessageBox.Show("Do you Really delete Data?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                switch (m)
                {
                    //1st case
                    case MessageBoxResult.Yes:
                        /////Update Data////

                        String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
                        String Query = "DELETE FROM `students` WHERE id='"+ID+"'";



                        MySqlConnection mycon = new MySqlConnection(Connection);
                        MySqlCommand myCom = new MySqlCommand(Query, mycon);
                        mycon.Open();
                        MySqlDataReader reader = myCom.ExecuteReader(); ;
                        mycon.Close();
                        MessageBoxResult result = MessageBox.Show("ID Deleted Successfully");


                        ///Update Data Close///

                        break;

                    //2nd Case
                    case MessageBoxResult.No:
                        break;
                }

            }

        }

        private void search_btn(object sender, RoutedEventArgs e)
        {
            String Given_ID = ID_box_s.Text;
            //  MessageBoxResult result = MessageBox.Show(""+Given_ID);
            String id = "", pass = "";
            String Fname = "", Lname = "", Age = "", Sex = "", Department = "", Semester = "", Section = "", CGPA = "", Rel = "", Phn = "", Mail = "", DOB = "", Loc = "";
            /////Data Retrive//////////
            String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
            // String Query = "SELECT `"+ID+"`, `"+Password+"`  FROM `admin` WHERE ID='"+ID+"';";
            String Query = " SELECT * FROM `students` WHERE ID = '" + Given_ID + "'";


            MySqlConnection mycon = new MySqlConnection(Connection);
            MySqlCommand myCom = new MySqlCommand(Query, mycon);

            MySqlDataReader reader;
            mycon.Open();
            reader = myCom.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToString(reader[0]);
                Fname = Convert.ToString(reader[1]);
                Lname = Convert.ToString(reader[2]);
                Age = Convert.ToString(reader[3]);
                Sex = Convert.ToString(reader[4]);
                Rel = Convert.ToString(reader[5]);
                Department = Convert.ToString(reader[6]);
                Semester = Convert.ToString(reader[7]);
                Section = Convert.ToString(reader[8]);
                CGPA = Convert.ToString(reader[9]);
                Phn = Convert.ToString(reader[10]);
                Mail = Convert.ToString(reader[11]);
                DOB = Convert.ToString(reader[12]);
                Loc = Convert.ToString(reader[13]);
                pass = Convert.ToString(reader[14]);
            }
            mycon.Close();

            ID_box.Text = id;
            FName_Box.Text = Fname;
            LName_Box.Text = Lname;         
            cgpa_box.Text = CGPA;
            Age_box.Text = Age;
            dob_box.Text = DOB;
            mail_box.Text = Mail;
            Phn_Box.Text = Phn;
            Loc_box.Text = Loc;
            pass_box.Text = pass;

           
            ///Radio Button
            if (Sex == "Male")
            {
                RB_Male.IsChecked = true;
            }
            else if (Sex == "Female")
            {
                 RB_Female.IsChecked = true;
            }
            else if(Sex=="Other")
            {
                RB_Other.IsChecked = true;
            }
            else {}

            ///Religion
            if (Rel == "Hindu")
            {
                comboBox_rl.SelectedIndex = 0;
            }
            else if (Rel == "Muslim")
            {
                comboBox_rl.SelectedIndex = 1;
            }
            else if (Rel == "Buddhist")
            {
               comboBox_rl.SelectedIndex = 2;
            }
            else if(Rel == "Christian")
            {
               comboBox_rl.SelectedIndex = 3;
            }
            else {}

            ///Department
            if (Department == "CSE")
            {
                comboBox_dprtmnt.SelectedIndex = 0;
            }
            else if (Department == "EEE")
            {
                comboBox_dprtmnt.SelectedIndex = 1;
            }
            else if (Department == "Civil")
            {
                comboBox_dprtmnt.SelectedIndex = 2;
            }
            else if(Department == "BBA")
            {
                comboBox_dprtmnt.SelectedIndex = 3;
            }
            else {}


            ///Section
            if (Section == "A")
            {
                comboBox_section.SelectedIndex = 0;
            }
            else if (Section == "B")
            {
                comboBox_section.SelectedIndex = 1;
            }
            else if (Section == "C")
            {
                comboBox_section.SelectedIndex = 2;
            }
            else if(Section == "C")
            {
                comboBox_section.SelectedIndex = 3;
            }
            else {}


            ///Semester
            if (Semester == "1_1")
            {
                comboBox_semester.SelectedIndex = 0;
            }
            else if (Semester == "1_2")
            {
                comboBox_semester.SelectedIndex = 1;
            }
            else if (Semester == "1_3")
            {
                comboBox_semester.SelectedIndex = 2;
            }
            else if (Semester == "2_1")
            {
                comboBox_semester.SelectedIndex = 3;
            }
            else if (Semester == "2_2")
            {
                comboBox_semester.SelectedIndex = 4;
            }
            else if (Semester == "2_3")
            {
                comboBox_semester.SelectedIndex = 5;
            }
            else if (Semester == "3_1")
            {
                comboBox_semester.SelectedIndex = 6;
            }
            else if (Semester == "3_2")
            {
                comboBox_semester.SelectedIndex = 7;
            }
            else if (Semester == "3_3")
            {
                comboBox_semester.SelectedIndex = 8;
            }
            else if (Semester == "4_1")
            {
                comboBox_semester.SelectedIndex = 9;
            }
            else if (Semester == "4_2")
            {
                comboBox_semester.SelectedIndex = 10;
            }
            else if(Semester == "4_2")
            {
                comboBox_semester.SelectedIndex = 11;
            }
            else {}


            if (id == "")
            {
                MessageBoxResult result = MessageBox.Show("Invalid ID");
            }
        }

        private void Reset_btn(object sender, RoutedEventArgs e)
        {
            ID_box.Text = "";
            FName_Box.Text = "";
            LName_Box.Text = "";
            cgpa_box.Text = "";
            Age_box.Text = "";
            dob_box.Text = "";
            mail_box.Text = "";
            Phn_Box.Text = "";
            Loc_box.Text = "";
            pass_box.Text = "";

            ///Radio Button
           
                RB_Male.IsChecked = false;
                RB_Female.IsChecked = false;          
                RB_Other.IsChecked = false;            
            ///Religion
                comboBox_rl.SelectedIndex = -1;
            ///Department          
                comboBox_dprtmnt.SelectedIndex = -1;          
            ///Section           
                comboBox_section.SelectedIndex = -1;
            ///Semester
                comboBox_semester.SelectedIndex = -1;      
        }

        
    }
}
