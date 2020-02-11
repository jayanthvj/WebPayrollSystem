using System;
using Payrole_Entity;
using Payrole_DAL;
using System.Data;

namespace Payrole_BL
{
    public class EmployeeBL
    {
        public static Boolean AddandupdateEmployee(EmployeeEntity emp,string EmployeeData)
        {
            EmployeeRepository.AddandupdateEmployee(emp,EmployeeData);
            return true ;
        }
        public static DataTable EmployeeGridView()
        {
            DataTable dataview = EmployeeRepository.EmployeeGridView();
            return dataview;
        }
        public static DataTable view(int EmployeeData)
        {
            DataTable data = EmployeeRepository.view(EmployeeData);
            return data;
        }
        public static void DeleteEmployee(int empId)
        {
            EmployeeRepository.DeleteEmployee(empId);
        }
        public static Boolean Login(AdminEntity login)
        {
            bool data = AdminRepository.Login(login);
            return data;
        }
    }

}
