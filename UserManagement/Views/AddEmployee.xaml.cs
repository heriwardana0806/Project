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
using UserManagement.Context;
using UserManagement.Controllers;
using UserManagement.Models;

namespace UserManagement.Views
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            EmployeeController CallEmployee = new EmployeeController();

            string Id = IdTextBox.Text;
            string First_Name = First_NameTextBox.Text;
            string Last_Name = Last_NameTextBox.Text;
            DateTime Birth_Date = Convert.ToDateTime(Birth_DateTextBox.Text);
            object Blood_TypeComboBox = null;
            //string Blood_Type = Blood_TypeComboBox.Text;
            string Blood_Type = Convert.ToString(Blood_TypeComboBox);
            //string Gender = GenderTextBox.Text;
            object GenderComboBox = null;
            string Gender = Convert.ToString(GenderComboBox);
            string Phone_Number = Phone_NumberTextBox.Text;
            object Marital_StatusComboBox = null;
            string Marital_Status = Convert.ToString(Marital_StatusComboBox);
            string Address = AddressTextBox.Text;
            string Zip_Code = Zip_CodeTextBox.Text;
            string Email = EmailTextBox.Text;
            object IsActiveComboBox = true;
            bool IsActive = Convert.ToBoolean(IsActiveComboBox);
            object Religion_IdComboBox = null;
            int Religion_Id = Convert.ToInt32(Religion_IdComboBox);
            string Position_Id = Position_IdTextBox.Text;
            int Village_Id = Convert.ToInt32(Village_IdTextBox.Text);
            string Manager_Id = Manager_IdTextBox.Text;
            int Birth_Place = Convert.ToInt32(Birth_PlaceTextBox.Text);

            CallEmployee.AddEmp(Id, First_Name, Last_Name, Birth_Date, Blood_Type, Gender, Phone_Number, Marital_Status,
                            Address, Zip_Code, Email, IsActive, Religion_Id, Position_Id, Village_Id, Manager_Id, Birth_Place);
            this.Hide();
            Home main = new Home();
            //main.Show();

        }

        //private void ReligionComboBox_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Religion religion = new Religion();
        //    MyContext _context = new MyContext();
        //    var get *_context.Religions.ToList();

        //    var combo = sender as ComboBox;
        //    combo.ItemsSource = get;
        //}
    }
}
