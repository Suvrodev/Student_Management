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

namespace Student_Management
{
    /// <summary>
    /// Interaction logic for DeanProfile.xaml
    /// </summary>
    public partial class DeanProfile : Window
    {
        public DeanProfile()
        {
            InitializeComponent();
        }

        private void Add_Student(object sender, RoutedEventArgs e)
        {
            StudentRegistration s = new StudentRegistration();
            s.Show();
            this.Close();
        }

        private void ViewAndSetting(object sender, RoutedEventArgs e)
        {
            StudentViewSetting s = new StudentViewSetting();
            s.Show();
            this.Close();
        }

        private void Add_Admin(object sender, RoutedEventArgs e)
        {
            Admin_Registration a = new Admin_Registration();
            a.catch_Data = "1";
            a.Show();
            this.Close();
        }

        private void Admin_setting(object sender, RoutedEventArgs e)
        {
            AdminViewSetting a = new AdminViewSetting();
            a.Show();
            this.Close();
        }

        private void ViewAllAdmin(object sender, RoutedEventArgs e)
        {
            All_Admin a = new All_Admin();
            a.Show();
            this.Close();
        }

        private void View_All_Students(object sender, RoutedEventArgs e)
        {
            All_Students a = new All_Students();
            a.Show();
            this.Close();
        }

        private void Add_Teacher(object sender, RoutedEventArgs e)
        {
            TeacherRegistration t = new TeacherRegistration();
            t.Show();
            this.Close();
        }

        private void TeacherViewSetting(object sender, RoutedEventArgs e)
        {
            TeacherViewSetting t = new TeacherViewSetting();
            t.Show();
            this.Close();
        }

        private void View_All_Teacher(object sender, RoutedEventArgs e)
        {
            ALL_Teachers a = new ALL_Teachers();
            a.Show();
            this.Close();
        }

        private void Add_Subject(object sender, RoutedEventArgs e)
        {
            Add_Course a = new Add_Course();
            a.Show();
            this.Close();
        }

        private void CourseViewSetting(object sender, RoutedEventArgs e)
        {
            CourseViewSetting c = new CourseViewSetting();
            c.Show();
            this.Close();
        }

        private void View_All_Course(object sender, RoutedEventArgs e)
        {
            ALl_Course a = new ALl_Course();
            a.Show();
            this.Close();
        }

        private void Back_Button(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
    }
}
