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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        int curStudent = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.City = txtCity.Text;

            students.Add(student);
            curStudent = students.Count;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (curStudent > 0)
            {
                curStudent--;
                txtFirstName.Text = students.ElementAt(curStudent).FirstName;
                txtLastName.Text = students.ElementAt(curStudent).LastName;
                txtCity.Text = students.ElementAt(curStudent).City;
            }

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (curStudent < students.Count - 1)
            {
                curStudent++;
                txtFirstName.Text = students.ElementAt(curStudent).FirstName;
                txtLastName.Text = students.ElementAt(curStudent).LastName;
                txtCity.Text = students.ElementAt(curStudent).City;
            }

            else
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtCity.Clear();
            }
        }


    }
}
