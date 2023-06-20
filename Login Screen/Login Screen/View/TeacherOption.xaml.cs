using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Login_Screen.View
{
    /// <summary>
    /// Interaction logic for TeacherOption.xaml
    /// </summary>
    public partial class TeacherOption : Window
    {
        public List<Student> DatabaseInformations { get; private set; }
        public TeacherOption()
        {
            InitializeComponent();

            Read();
        }
        public void Read()
        {
            using (UserDataContext context = new UserDataContext())
            {
                DatabaseInformations = context.Students.ToList();
                InformationList.ItemsSource = DatabaseInformations;

            }

        }

        public void Delete()
        {
            Student selectedInfo = InformationList.SelectedItem as Student;
            using (UserDataContext context = new UserDataContext())
            {
                if (selectedInfo != null)
                {

                    //Teacher Teacher = context.Informations.Find(selectedInfo.Id);
                    Student student = context.Students.Single(x => x.Id == selectedInfo.Id);

                    context.Remove(student);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please select student you want to delete");
                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void registerbtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationView main = new RegistrationView();
            main.Show();
            Close();
        }

        
        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            LoginView main = new LoginView();
            main.Show();
            Close();
        }


        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStd = InformationList.SelectedItem as Student;
            using (UserDataContext context = new UserDataContext())
            {
                if (selectedStd != null) {
                    
                    RegistrationView regView = new RegistrationView(selectedStd);
                    regView.Show();
                    //regView.TitleText = "EDIT STUDENT";

                    Close();
                }
                else
                {
                    MessageBox.Show("Please select the student");
                }
            }
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();
            Read();
        }

        private void resultbtn_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStd = InformationList.SelectedItem as Student;
            using (UserDataContext context = new UserDataContext())
            {
                if (selectedStd != null)
                {
                    MainWindow main = new MainWindow(selectedStd);
                    main.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Please select a student.");
                }
            }

        }
    }
}
