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
    /// Interaction logic for StudentRegistration.xaml
    /// </summary>
    public partial class StudentRegistration : Window
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void Reg_Click_btn(object sender, RoutedEventArgs e)
        {
            String ID = ID_box.Text;
            String FName = FName_Box.Text;
            String LName = LName_Box.Text;
            String Age = Age_box.Text;
            String Email = mail_box.Text;
            String Phone = Phn_Box.Text;
            String Location = Loc_box.Text;
            String Password = Pass_box.Password;
            String CGPA = cgpa_box.Text;
            String Sex = "";
           // String Department = "";
          //  String Semester = "";
           

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


            string DOB = cal_date.SelectedDate.Value.ToShortDateString();

            //Message box for surity of data
            MessageBoxResult results = MessageBox.Show(ID + "\n" + FName + "\n" + LName + "\n" + Age + "\n" + Sex + "\n" + Religion + "\n" + Department +"\n" + Semester
                + "\n" + Section + "\n" + Email + "\n" + Phone
                + "\n" + DOB + "\n" + Location +  "\n" + Password);


            //////////////////////////////////////////////////////////

            if (Password.Length >= 6)
            {
                MessageBoxResult m = MessageBox.Show("Do you relly Insert?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                switch (m)
                {
                    //1st case
                    case MessageBoxResult.Yes:
                        /////Insert Data////


                        String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
                        String Query = "INSERT INTO `students`(`ID`, `fname`, `lname`, `age`, `sex`, `religion`, `Department`, `Semester`, `Section`, `cgpa`, `phn`, `mail`, `dob`, `location`, `password`) VALUES ('" + ID + "','" + FName + "','" + LName + "','" + Age + "','" + Sex + "','" + Religion + "','" + Department + "','" + Semester + "','" + Section + "','" + CGPA + "','" + Phone + "','" + Email + "','" + DOB + "','" + Location + "','" + Password + "')";



                        MySqlConnection mycon = new MySqlConnection(Connection);
                        MySqlCommand myCom = new MySqlCommand(Query, mycon);
                        mycon.Open();
                        MySqlDataReader reader = myCom.ExecuteReader(); ;
                        mycon.Close();
                        MessageBoxResult result = MessageBox.Show("Data Inserted Successfully");


                        ///Insert Data Close///

                        break;

                    //2nd Case
                    case MessageBoxResult.No:
                        break;
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Password Should be 6 or More digit");
            }
        
        //////////////////////////////////////////////////////////
    }

        private void Reset_btn(object sender, RoutedEventArgs e)
        {
            ID_box.Text = "";
            FName_Box.Text = "";
            LName_Box.Text = "";
            Age_box.Text = "";
            mail_box.Text = "";
            Phn_Box.Text = "";
            Loc_box.Text = "";
            Pass_box.Password = "";
            cgpa_box.Text="";

        }
    }
}
