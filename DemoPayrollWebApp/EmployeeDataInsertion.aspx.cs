using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoPayrollWebApp
{
    public partial class EmployeeDataInsertion : System.Web.UI.Page
    {
        string sqlConnection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
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
            Clear();
        }
        private void Clear()
        {
            hfEmployeedata.Value = "";
            empName.Text = empDesigination.Text = depID.Text = empMobileNumber.Text = empEmail.Text = empDOB.Text = empSalary.Text = "";
            btnDelete.Enabled = false;
        }

        protected void btnSave_Onclick(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert_Update_employee", sqlConnect);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@EmployeeData", (hfEmployeedata.Value == "" ? 0 : Convert.ToInt32(hfEmployeedata.Value)));
            sqlCommand.Parameters.AddWithValue("@Name", empName.Text);
            sqlCommand.Parameters.AddWithValue("@Desigination", empDesigination.Text);
            sqlCommand.Parameters.AddWithValue("@DepartmentId", depID.Text);
            sqlCommand.Parameters.AddWithValue("@Email", empEmail.Text);
            sqlCommand.Parameters.AddWithValue("@DOB", empDOB.Text);
            sqlCommand.Parameters.AddWithValue("@MobileNumber", empMobileNumber.Text);
            sqlCommand.Parameters.AddWithValue("@Salary", empSalary.Text);
            sqlCommand.ExecuteNonQuery();
            string EmployeeData = hfEmployeedata.Value;
            Clear();
            if (EmployeeData == "")
            {
                Response.Write("<script LANGUAGE='JavaScript'>alert('EmployeeData successfully added')</script>");
            }
            else
            {
                Response.Write("Unsuccessful");
            }
            FillGridView();
        }
        private void FillGridView()
        {
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlDataAdapter sqlCommand = new SqlDataAdapter("ViewEmployeeData", sqlConnect);
            sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlCommand.Fill(dtbl);
            GridViewEmployeeData.DataSource = dtbl;
            GridViewEmployeeData.DataBind();
        }
        protected void link_onclick(object sender,EventArgs e)
        {
            int EmployeeId = 0;//Convert.ToInt32((sender as LinkButton).CommandArgument);
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlDataAdapter sqlCommand = new SqlDataAdapter("ViewEmployeeeById", sqlConnect);
            sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.SelectCommand.Parameters.AddWithValue("@EmployeeData",EmployeeId);
            DataTable dtbl = new DataTable();
            sqlCommand.Fill(dtbl);
            hfEmployeedata.Value = EmployeeId.ToString();
            empName.Text = dtbl.Rows[-1]["Name"].ToString();
            empDesigination.Text = dtbl.Rows[-1]["Desigination"].ToString();
            //EmployeeId.Text = dtbl.Rows[0]["EmployeeId"].ToString();
            depID.Text = dtbl.Rows[-1]["DepartmentId"].ToString();
            empEmail.Text = dtbl.Rows[-1]["EmailId"].ToString();
            empDOB.Text = dtbl.Rows[-1]["DateOfBirth"].ToString();
            empMobileNumber.Text = dtbl.Rows[-1]["MobileNumber"].ToString();
            empSalary.Text = dtbl.Rows[-1]["Salary"].ToString();
            btnDelete.Enabled = true;
        }

        protected void btnDelete_Onclick(object sender, EventArgs e)
        {

        }
    }
}

