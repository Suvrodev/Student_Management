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
    /// Interaction logic for TeacherActivity.xaml
    /// </summary>
   

    public partial class TeacherActivity : Window
    {
        public String Get_ID = "";
        public String Name = "", Age = "", Sex = "", Rel = "", Department = "", M_S = "", Mail = "", phn = "", DOB = "", Loc = "", Pass = "";

        private void All_Clourse(object sender, RoutedEventArgs e)
        {
            ALl_Course a = new ALl_Course();
            a.Show();
            this.Close();
        }

        private void Shw_All_Std(object sender, RoutedEventArgs e)
        {
            All_Students_By a = new All_Students_By();
            a.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            All_Teacher_By_ a = new All_Teacher_By_();
            a.Show();
            this.Close();
        }

        public TeacherActivity()
        {
            InitializeComponent();
            
        }

        private void Show_btn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Get_ID+"\n"+Name + "\n"+ Age + "\n" + Sex + "\n" + Rel + "\n" + Department + "\n" + M_S + "\n" + phn + "\n" + Mail + "\n" + DOB + "\n" + Loc+"\n"+Pass);

            /////Data Retrive//////////
            String Connection = "Server=127.0.0.1;User ID=root; DataBase=project";
            String Query = "SELECT teacher.Name, course.Name,course.Semester FROM course INNER JOIN teacher ON course.C_Teacher = teacher.Name WHERE teacher.ID='"+Get_ID+"'";

            MySqlConnection mycon = new MySqlConnection(Connection);
            MySqlCommand myCom = new MySqlCommand(Query, mycon);
            mycon.Open();

            MySqlDataAdapter adp = new MySqlDataAdapter(myCom);
            DataTable dt = new DataTable("teacher");
            adp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            adp.Update(dt);
            mycon.Close();
        }


        ///Teacher Own Update
        private void Update_Teacher_Own(object sender, RoutedEventArgs e)
        {
            Teacher_Own_Update t = new Teacher_Own_Update();

            t.tb.Text = Get_ID;
            t.tb_fname.Text = Name;
            t.tb_age.Text = Age;
            t.tb_department.Text = Department;
            t.tb_m_s.Text = M_S;
            t.tb_rel.Text = Rel;
            t.tb_sex.Text = Sex;
            t.tb_dob.Text = DOB;

            t.tbx_phn.Text = phn;
            t.tbx_mail.Text = Mail;
            t.tbx_loc.Text = Loc;
            t.tbx_oldpass.Text = Pass;

            MessageBox.Show("Password:" + Pass);


            t.Show();          
            this.Close();
        }
    }
}
