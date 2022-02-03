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
    /// Interaction logic for AdminViewSetting.xaml
    /// </summary>
    public partial class AdminViewSetting : Window
    {
        public AdminViewSetting()
        {
            InitializeComponent();
        }

        private void search_btn(object sender, RoutedEventArgs e)
        {
            if (ID_box_s.Text == "")
            {
                MessageBoxResult result = MessageBox.Show("Invalid ID");
            }
            else
            {
                String ID = ID_box_s.Text;
                String id = "", pass = "";
                String fname = "", lname = "", age = "", sex = "", rel = "", m_s = "", mail = "", phn = "", dob = "", loc = "", skill = "", Status = "";

                /////Data Retrive//////////
                String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";

                String Query = " SELECT * FROM `admin` WHERE ID = '" + ID + "'";


                MySqlConnection mycon = new MySqlConnection(Connection);
                MySqlCommand myCom = new MySqlCommand(Query, mycon);

                MySqlDataReader reader;
                mycon.Open();
                reader = myCom.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToString(reader[0]);
                    fname = Convert.ToString(reader[1]);
                    lname = Convert.ToString(reader[2]);
                    age = Convert.ToString(reader[3]);
                    sex = Convert.ToString(reader[4]);
                    rel = Convert.ToString(reader[5]);
                    m_s = Convert.ToString(reader[6]);
                    mail = Convert.ToString(reader[7]);
                    phn = Convert.ToString(reader[8]);
                    dob = Convert.ToString(reader[9]);
                    loc = Convert.ToString(reader[10]);
                    skill = Convert.ToString(reader[11]);
                    pass = Convert.ToString(reader[12]);
                    Status = Convert.ToString(reader[13]);
                    // Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4]);

                }
                mycon.Close();

                /////String Set/////////
                ID_box.Text = id;
                FName_Box.Text = fname;
                LName_Box.Text = lname;
                Age_box.Text = age;
                mail_box.Text = mail;
                Phn_Box.Text = phn;
                dob_box.Text = dob;
                Loc_box.Text = loc;
                Skill_Box.Text = skill;
                pass_box.Text = pass;

                ////Check Box
                if (m_s == "Merried")
                {
                    Merried.IsChecked = true;
                }
                else if (m_s == "Unmerried")
                {
                    Unmerried.IsChecked = true;
                }
                else {
                    Merried.IsChecked = false;
                    Unmerried.IsChecked = false;
                }


                ///Radio Button
                if (sex == "Male")
                {
                    RB_Male.IsChecked = true;
                }
                else if (sex == "Female")
                {
                    RB_Female.IsChecked = true;
                }
                else if (sex == "Other")
                {
                    RB_Other.IsChecked = true;
                }
                else {
                    RB_Male.IsChecked = false;
                    RB_Female.IsChecked = false;
                    RB_Other.IsChecked = false;
                }


                //  Religion By Combo box
                if (rel == "Hindu")
                {
                    comboBox_rl.SelectedIndex = 0;
                }
                else if (rel == "Muslim")
                {
                    comboBox_rl.SelectedIndex = 1;
                }
                else if (rel == "Buddhist")
                {
                    comboBox_rl.SelectedIndex = 2;
                }
                else if (rel == "Christian")
                {
                    comboBox_rl.SelectedIndex = 3;
                }
                else
                {
                    comboBox_rl.SelectedIndex = -1;
                }

                ///Status Combo box
                if (Status == "True")
                {
                    comboBox_status.SelectedIndex = 0;
                }
                else if (Status == "False")
                {
                    comboBox_status.SelectedIndex = 1;
                }
                else
                {
                    comboBox_status.SelectedIndex = -1;
                }
                //////////////////////////////


                //////////////////
            }
        }

        private void modify_btn(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_btn(object sender, RoutedEventArgs e)
        {

        }

        private void Reset_btn(object sender, RoutedEventArgs e)
        {

        }
    }
}
