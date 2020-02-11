using System;
using Payrole_Entity;
using Payrole_BL;
using System.Data.SqlClient;
using Payrole_DAL;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DemoPayrollWebApp
{
    public partial class EmployeeDataInsertion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnDelete.Enabled = false;
                FillGridView();
            }
        }

        protected void btnClear_Onclick(object sender, EventArgs e)
        {
            try
            {
                string EmployeeData = Convert.ToString(hfEmployeedata.Value = "");
                string name = empName.Text = "";
                string departmentId = depID.Text = "";
                string Designation = empDesigination.Text = "";
                string EmailID = empEmail.Text = "";
                string DateOfBirth = empDOB.Text = "";
                string Mobilenumber = empMobileNumber.Text = "";
                string Salary = empSalary.Text = "";
                EmployeeEntity empdata = new EmployeeEntity(name, departmentId, Designation, EmailID, DateOfBirth, Mobilenumber, Salary);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
            }
            catch(Exception )
            {
                Response.Write("error");
            }
        }


        protected void btnSave_Onclick(object sender, EventArgs e)
        {
            string EmployeeData = Convert.ToString(hfEmployeedata.Value == "" ? 0 : Convert.ToInt32(hfEmployeedata.Value));
            string name = empName.Text;
            string departmentId = depID.Text;
            string Designation = empDesigination.Text;
            string EmailID = empEmail.Text;
            string DateOfBirth = empDOB.Text;
            string Mobilenumber = empMobileNumber.Text;
            string Salary = empSalary.Text;
            EmployeeEntity empdata = new EmployeeEntity(name, departmentId, Designation, EmailID, DateOfBirth, Mobilenumber, Salary);
            bool result = EmployeeBL.AddandupdateEmployee(empdata, EmployeeData);
            if (result)
            {
                Response.Write("<script LANGUAGE='JavaScript'>alert('EmployeeData successfully added')</script>");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript'>alert('EmployeeData successfully updated')</script>");
            }
            FillGridView();

        }
        private void FillGridView()
        {
            DataTable datatable = EmployeeBL.EmployeeGridView();
            GridViewEmployeeData.DataSource = datatable;
            GridViewEmployeeData.DataBind();
        }
        protected void link_onclick(object sender, EventArgs e)
        {
            int EmployeeData = Convert.ToInt32((sender as LinkButton).CommandArgument);
            DataTable dtbl = EmployeeBL.view(EmployeeData);
            hfEmployeedata.Value = EmployeeData.ToString();
            empName.Text = dtbl.Rows[0]["Name"].ToString();
            empDesigination.Text = dtbl.Rows[0]["Desigination"].ToString();
            depID.Text = dtbl.Rows[0]["DepartmentId"].ToString();
            empEmail.Text = dtbl.Rows[0]["EmailId"].ToString();
            empDOB.Text = dtbl.Rows[0]["DateOfBirth"].ToString();
            empMobileNumber.Text = dtbl.Rows[0]["MobileNumber"].ToString();
            empSalary.Text = dtbl.Rows[0]["Salary"].ToString();
            btnDelete.Enabled = true;
        }

        protected void btnDelete_Onclick(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(hfEmployeedata.Value);
            EmployeeBL.DeleteEmployee(empId);
            FillGridView();
            Response.Write("DeletedSuccessfully");
            btnSave.Enabled = false;
        }
    }
}

