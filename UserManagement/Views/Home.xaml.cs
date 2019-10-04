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
using UserManagement.Models;
using UserManagement.Views;

namespace UserManagement
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public object MyDataGrid { get; private set; }

        public Home()
        {
            InitializeComponent();
            //initData();
        }

        private void initData()
        {
            //try
            //{
            //    MyContext db = new MyContext();

            //    var DataResult = from Employee in db.Employees
            //                         select Employee;
            //    this.MyDataGrid.Employees = DataResult.ToList<Employee>();
            //}
            //catch
            //{
            //    MessageBox.Show("Data is empty");
            //}
        }

        private void Add_Btn_Click_1(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            AddEmployee calling = new AddEmployee();
            calling.ShowDialog();
        }

        private void Setting_Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Man_Emp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home calling = new Home();
            calling.ShowDialog();

        }

        private void Man_App_Emp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageApplicationEmployee calling = new ManageApplicationEmployee();
            calling.ShowDialog();

        }

        private void Man_Role_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ManageRole calling = new ManageRole();
            calling.ShowDialog();

        }

        private void Active_Status_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EmployeeActiveStatus calling = new EmployeeActiveStatus();
            calling.ShowDialog();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            ViewEmployee calling = new ViewEmployee();
            calling.ShowDialog();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            EditEmployee calling = new EditEmployee();
            calling.ShowDialog();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdatePassword_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ChangePassword calling = new ChangePassword();
            calling.ShowDialog();

        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Login calling = new Login();
            calling.ShowDialog();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            Employee employee = new Employee();
            MyContext _context = new MyContext();
            //employees.Add(new Employee("15002", "Heri", "Ginting", Convert.ToDateTime("06-08-2019"), "A", "Male", "082188667799", "Single",
            //                        "Jakarta Barat", "20018", "heriwardana8@gmail.com", Convert.ToBoolean("True"), Convert.ToInt32("1"), "ADA", Convert.ToInt32("1"), "15003", Convert.ToInt32("1"))
            //                        );

            //var grid = sender as DataGrid;
            //grid.ItemsSource = employees;
            var get = _context.Employees.ToList();

            var grid = sender as DataGrid;
            grid.ItemsSource = get;
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }



        //public class Employee
        // {
        //     private string Id;
        //     private string First_Name;
        //     private string Last_Name;
        //     private DateTime Birth_Date;
        //     private string Blood_Type;
        //     private string Gender;
        //     private string Phone_Number;
        //     private string Marital_Status;
        //     private string Address;
        //     private string Zip_Code;
        //     private string Email;
        //     private bool IsActive;
        //     private int Religion_Id;
        //     private string Position_Id;
        //     private int Village_Id;
        //     private string Manager_Id;
        //     private int Birth_Place;

        //     public Employee(string Id, string First_Name, string Last_Name, DateTime Birth_Date, string Blood_Type, string Gender, string Phone_Number, string Marital_Status,
        //                     string Address, string Zip_Code, string Email, bool IsActive, int Religion_Id, string Position_Id, int Village_Id, string Manager_Id, int Birth_Place)
        //     {
        //         this.Id = Id;
        //         this.First_Name = First_Name;
        //         this.Last_Name = Last_Name;
        //         this.Birth_Date = Birth_Date;
        //         this.Blood_Type = Blood_Type;
        //         this.Gender = Gender;
        //         this.Phone_Number = Phone_Number;
        //         this.Marital_Status = Marital_Status;
        //         this.Address = Address;
        //         this.Zip_Code = Zip_Code;
        //         this.Email = Email;
        //         this.IsActive = IsActive;
        //         this.Religion_Id = Religion_Id;
        //         this.Position_Id = Position_Id;
        //         this.Village_Id = Village_Id;
        //         this.Manager_Id = Manager_Id;
        //         this.Birth_Place = Birth_Place;
        //     }
        // }



    }
}
