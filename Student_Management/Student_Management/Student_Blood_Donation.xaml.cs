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
    /// Interaction logic for Student_Blood_Donation.xaml
    /// </summary>
    public partial class Student_Blood_Donation : Window
    {
        public String Blood_Donate = "", Blood_Group = "", Last_Donate = "";

        public Student_Blood_Donation()
        {
            InitializeComponent();
        }

        private void modify_btn(object sender, RoutedEventArgs e)
        {
            String ID = tb.Text;
            String FName = tb_fname.Text;
            String LName = tb_lname.Text;
            String Blood_Group = comboBox_BloodGroup.Text;
            String Blood_Donation = comboBox_Blood_Donate.Text;
            String Last_Donate = last_donate_box_.Text;

            MessageBox.Show(ID + "\n" + FName + "\n" + LName + "\n" + Blood_Group + "\n" + Blood_Donation+"\n"+Last_Donate);

            ////////////////////////
            MessageBoxResult m = MessageBox.Show("Do you Really modify Data?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (m)
            {
                //1st case
                case MessageBoxResult.Yes:
                    /////Update Data////

                    String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
                    String Query = "UPDATE `students` SET `Blood_Donate`='"+Blood_Donation+"',`Blood_Group`='"+Blood_Group+"',`Last_Donate`='"+Last_Donate+"' WHERE id='"+ID+"'";



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

        private void Reset_btn(object sender, RoutedEventArgs e)
        {
            last_donate_box_.Text = "";
            comboBox_BloodGroup.SelectedIndex = -1;
            comboBox_Blood_Donate.SelectedIndex = -1;
        }
    }
}
