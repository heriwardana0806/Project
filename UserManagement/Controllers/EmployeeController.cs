using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UserManagement.Context;
using UserManagement.Models;
using UserManagement.Views;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Data;
using System.Windows.Documents;

namespace UserManagement.Controllers
{
    public class EmployeeController
    {
        public void AddEmp(string Id, string First_Name, string Last_Name, DateTime Birth_Date, string Blood_Type, string Gender, string Phone_Number, string Marital_Status, 
                            string Address, string Zip_Code, string Email, bool IsActive, int Religion_Id, string Position_Id, int Village_Id, string Manager_Id, int Birth_Place)
        {
            var result = 0;
            Employee employee = new Employee();
            MyContext _context = new MyContext();

            employee.Id = Id;
            employee.First_Name = First_Name;
            employee.Last_Name = Last_Name;
            employee.Birth_Date = Birth_Date;
            employee.Blood_Type = Blood_Type;
            employee.Gender = Gender;
            employee.Phone_Number = Phone_Number;
            employee.Marital_Status = Marital_Status;
            employee.Address = Address;
            employee.Zip_Code = Zip_Code;
            employee.Email = Email;
            employee.IsActive = IsActive;
            employee.Religion_Id = Religion_Id;
            employee.Position_Id = Position_Id;
            employee.Village_Id = Village_Id;
            employee.Manager_Id = Manager_Id;
            employee.Birth_Place = Birth_Place;


            _context.Employees.Add(employee);
            result = _context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Add Employee Successful!");
            }
            else
            {
                MessageBox.Show("Add Employee Failed!");
            }
        }

       
    }
}
