using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDeskReport.Forms
{
    public partial class FormUpdate : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskReport.Properties.Settings.DataBaseConnectionString"].ConnectionString);

        DateTime now = DateTime.Now;
        StringBuilder errorMessages = new StringBuilder();


        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            //Populate combobox with Tech ID,last name, first name
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();             
                    {
                        SqlCommand comboData = new SqlCommand("select concat(TechID, ': ', Last_Name, ', ',First_Name) as 'Name' from Tech", cn);
                        SqlDataReader reader;
                        reader = comboData.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Tech", typeof(string));
                        dt.Load(reader);
                        cbTech.ValueMember = "PKID";
                        cbTech.DisplayMember = "Name";
                        cbTech.DataSource = dt;
                        cbTech.SelectedIndex = -1;
                       
                        cn.Close();
                    }

                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                {
                    SqlCommand custData = new SqlCommand("select concat(CustID, ': ', Last_Name, ', ',First_Name) as 'custName' from Customer", cn);
                    SqlDataReader custReader;
                    custReader = custData.ExecuteReader();
                    DataTable custDT = new DataTable();
                    custDT.Columns.Add("Cust", typeof(string));
                    custDT.Load(custReader);
                    cbCustID.ValueMember = "CustID";
                    cbCustID.DisplayMember = "custName";
                    cbCustID.DataSource = custDT;
                    cbCustID.SelectedIndex = -1;

                    cn.Close();

                }

            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            string commandText = "insert into Ticket (Assigned_Tech,Issue_Desc,Created_When,CustId) values (LEFT(@assigned_tech,1),@issue_desc,@created_when,LEFT(@cust_id,1))";
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                {
                    SqlCommand sqlUpdate = new SqlCommand(commandText, cn);
                    sqlUpdate.Parameters.AddWithValue("assigned_tech", cbTech.Text);
                    sqlUpdate.Parameters.AddWithValue("issue_desc", tbDesc.Text);
                    sqlUpdate.Parameters.AddWithValue("created_when", now);
                    sqlUpdate.Parameters.AddWithValue("cust_id", cbCustID.Text);
                    sqlUpdate.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Created.");
                    cn.Close();

                    tbDesc.Clear();
                    cbCustID.SelectedIndex = -1;
                    cbTech.SelectedIndex = -1;
                }
            }
            catch(SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbDesc.Clear();
            cbCustID.SelectedIndex = -1;
            cbTech.SelectedIndex = -1;
        }
    }
}
