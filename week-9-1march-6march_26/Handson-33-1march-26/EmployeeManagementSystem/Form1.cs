using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {

        string connectionString =
             "Data Source=DESKTOP-L1MO71T\\SQLEXPRESS;Initial Catalog=CompanyDB;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDepartments()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                "SELECT DepartmentID, DepartmentName FROM Departments", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDepartment.DataSource = dt;
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentID";
            }
        }

        private void LoadEmployees()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetEmployees", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadEmployees();
        }
    }
}
