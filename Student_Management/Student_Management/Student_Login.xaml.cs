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
using MySql.Data.MySqlClient;
using System.Windows.Navigation;

namespace Student_Management
{
    /// <summary>
    /// Interaction logic for Student_Login.xaml
    /// </summary>
    public partial class Student_Login : Window
    {
        public Student_Login()
        {
            InitializeComponent();
        }

        private void Reset_btn(object sender, RoutedEventArgs e)
        {
            ID_Box.Text = "";
            Pass_Box.Password = "";
        }

        private void ID_Box_focus(object sender, RoutedEventArgs e)
        {
            ID_Box.Text = "";
        }



        private void Login_Click_btn(object sender, RoutedEventArgs e)
        {
            String ID = ID_Box.Text;
            String Password = Pass_Box.Password;

            String id = "", pass = "";
            String Fname = "", Lname = "", Age = "", Sex = "", Department = "", Semester = "", Section = "", CGPA = "", Rel = "", Phn = "", Mail = "", DOB = "", Loc = "";


            /////Data Retrive//////////
            String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
            // String Query = "SELECT `"+ID+"`, `"+Password+"`  FROM `admin` WHERE ID='"+ID+"';";
            String Query = " SELECT * FROM `students` WHERE ID = '" + ID + "'";


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


                // Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4]);

            }


            mycon.Close();

             if(ID==id && Password == pass)
             {
                string A = "hello";
                Student_Activity a = new Student_Activity();

                a.tb.Text = ID_Box.Text;
                a.tb_fname.Text = Fname;
                a.tb_lname.Text = Lname;
                a.tb_department.Text = Department;
                a.tb_semester.Text = Semester;
                a.tb_section.Text = Section;
                a.tb_cgpa.Text = CGPA;

                a.tb_age.Text = Age;
                a.tb_sex.Text = Sex;
                a.tb_rel.Text = Rel;

                a.tb_dob.Text = DOB;
                a.tbx_mail.Text = Mail;
                a.tbx_phn.Text = Phn;   
                a.tbx_loc.Text = Loc;

                a.Show();
                this.Close();
             }
             else
             {
                 MessageBoxResult result = MessageBox.Show("ID or Password Not matched");
             }

        }
    }
}