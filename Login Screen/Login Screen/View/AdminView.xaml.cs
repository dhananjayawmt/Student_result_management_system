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
using System.Xml.Linq;

namespace Login_Screen.View
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public List<Teacher> DatabaseInformations { get; private set; }

        String gender;

        public AdminView()
        {
            InitializeComponent();

            Read();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        public void Create()
        {
            using (UserDataContext context = new UserDataContext())
            {
                var fname = fnametxt.Text;
                var lname = lnametxt.Text;
                var dob = dobDatePicker.Text;
                var age = agetxt.Text;
                var address = addresstxt.Text;
                var email = emaitxt.Text;
                var phone = mobtxt.Text;
                var pass=passtxt.Text;
                if (fname != null && lname != null && gender != null)
                {
                    context.Teachers.Add(new Teacher() { FName = fname, LName = lname, gender = gender, dob = dob, age = age, address= address, email = email, mob = phone, TeacherPass=pass });
                    context.SaveChanges();
                }
            }
        }
        public void Read()
        {
            using (UserDataContext context = new UserDataContext())
            {
                DatabaseInformations = context.Teachers.ToList();
                InformationList.ItemsSource = DatabaseInformations;

            }

        }
        public void Update()
        {
            Teacher selectedInfo = InformationList.SelectedItem as Teacher;
            using (UserDataContext context = new UserDataContext())
            {
                var fname = fnametxt.Text;
                var lname = lnametxt.Text;
                var dob = dobDatePicker.Text;
                var age = agetxt.Text;
                var address = addresstxt.Text;
                var email = emaitxt.Text;
                var phone = mobtxt.Text;
                var pass = passtxt.Text;

                
                    if(selectedInfo != null) { 
                        Teacher Teacher = context.Teachers.Find(selectedInfo.Id);
                        Teacher.FName = fname;
                        Teacher.LName = lname;
                        Teacher.gender = gender;
                        Teacher.dob = dob;
                        Teacher.age = age;
                        Teacher.email = email;
                        Teacher.address = address;
                        Teacher.mob = phone;
                        Teacher.TeacherPass = pass;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Please select Teacher");
                    }
                
            }
        }
        public void Delete()
        {
            Teacher selectedInfo = InformationList.SelectedItem as Teacher;
            using (UserDataContext context = new UserDataContext())
            {
                if (selectedInfo != null)
                {

                    //Teacher Teacher = context.Informations.Find(selectedInfo.Id);
                    Teacher Teacher = context.Teachers.Single(x => x.Id == selectedInfo.Id);

                    context.Remove(Teacher);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please select Teacher");
                }

            }
        }

        private void createbtn_Click(object sender, RoutedEventArgs e)
        {
            Create();
            Read();

        }

        /*private void readbtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationView main = new RegistrationView();
            main.Show();
            //GrantAccess();
            Close();
        }*/

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Update();
            Read();

        }

        private void dltebtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();
            Read();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            if (female.IsChecked == true)
            {
                gender = "Female";
            }
            else if (male.IsChecked == true)
            {
                gender = "Male";
            }
        }

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            LoginView main = new LoginView();
            main.Show();
            Close();
        }

       
    }
}