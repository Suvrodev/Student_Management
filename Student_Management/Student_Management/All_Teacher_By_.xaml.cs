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
    /// Interaction logic for All_Teacher_By_.xaml
    /// </summary>
    public partial class All_Teacher_By_ : Window
    {
        public All_Teacher_By_()
        {
            InitializeComponent();
        }

        private void Show_btn(object sender, RoutedEventArgs e)
        {
            String Department = "", Semester = "", Section = "", Sex = "", Religion = "";


            var Religion_Temp = (ComboBoxItem)comboBox_rl.SelectedItem;
            Religion = (String)Religion_Temp.Content;


            var Department_Temp = (ComboBoxItem)comboBox_dprtmnt.SelectedItem;
            Department = (String)Department_Temp.Content;


            var Sex_temp = (ComboBoxItem)comboBox_Sex.SelectedItem;
            Sex = (String)Sex_temp.Content;

            /////Data Retrive//////////
            String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
            String Query = "";
            if (Department == "ALL")
            {
                Department = "%";
            }

            if (Sex == "ALL")
            {
                Sex = "%";
            }
            if (Religion == "ALL")
            {
                Religion = "%";
            }


            //  MessageBox.Show(Department + "\n" + Semester + "\n" + Section + "\n" + Sex + "\n" + Religion);
            Query = "SELECT  `ID`, `Name`, `Age`, `Sex`, `Religion`, `Department`, `M_S`, `Phone`, `Email`, `DOB`, `Location` FROM `teacher` WHERE Department LIKE '" + Department + "' AND sex LIKE '" + Sex + "' AND religion LIKE '" + Religion + "'";

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
    }
}
