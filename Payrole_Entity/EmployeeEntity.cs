using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrole_Entity
{
    public class EmployeeEntity
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string departmentId { get; set; }
        public string EmailID { get; set; }
        public string DateOfBirth { get; set; }
        public string Mobilenumber { get; set; }
        //public string DepartmentName { get; set; }
        public string Salary { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }
        public EmployeeEntity() { }


        public EmployeeEntity(  string Name, string departmentId, string Designation, string EmailID, string DateOfBirth, string Mobilenumber,/* string DepartmentName */ string Salary /*string UserName, string Password */)
        {
            this.Name = Name;
            this.departmentId = departmentId;
            this.EmailID = EmailID;
            this.Designation = Designation;
            this.DateOfBirth = DateOfBirth;
            this.Mobilenumber = Mobilenumber;
            //this.DepartmentName = DepartmentName;
            this.Salary = Salary;
            //this.UserName = UserName;
            //this.Password = Password;
        }
    }
    public class AdminEntity
    {
        public string Username { get; set; }
        public string password { get; set; }

        public AdminEntity() { }
        public AdminEntity ( string Username,string password)
        {
            this.password = password;
            this.Username = Username;
        }
    }
}
