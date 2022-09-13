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
    public partial class FormHome : Form
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskReport.Properties.Settings.DataBaseConnectionString"].ConnectionString);
        DateTime now = DateTime.Now;
        int isActive;
        StringBuilder errorMessages = new StringBuilder();
        int parsedValue;


        public FormHome()
        {
            InitializeComponent();
        }

        private void rbClose_CheckedChanged(object sender, EventArgs e)
        {

            if (rbClose.Checked)
                isActive = 0;
            else
                isActive = 1;
        }

        private void FormHome_Load(object sender, EventArgs e)
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
                    cbTech2.ValueMember = "PKID";
                    cbTech2.DisplayMember = "Name";
                    cbTech2.DataSource = dt;
                    cbTech2.SelectedIndex = -1;

                    cn.Close();
                }

            }
            catch
            {
                return;
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(tbPKID.Text) || !int.TryParse(tbPKID.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a valid Order ID");
                tbPKID.Clear();
            }
            else
            {
                string commandText = "UPDATE Ticket SET Assigned_Tech = (LEFT(@assigned_tech,1)),Remarks = @remark_desc,Completed_Date = @complete_when, IsActive = @isActive WHERE PKID = @PKID";
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    {
                        SqlCommand sqlUpdate = new SqlCommand(commandText, cn);
                        sqlUpdate.Parameters.AddWithValue("assigned_tech", cbTech2.Text);
                        sqlUpdate.Parameters.AddWithValue("remark_desc", tbRemark.Text);
                        sqlUpdate.Parameters.AddWithValue("complete_when", now);
                        sqlUpdate.Parameters.AddWithValue("isActive", isActive);
                        sqlUpdate.Parameters.AddWithValue("PKID", tbPKID.Text);
                        sqlUpdate.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated.");
                        cn.Close();

                        tbPKID.Clear();
                        cbTech2.SelectedIndex = -1;
                        tbRemark.Clear();
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
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbPKID.Text) || !int.TryParse(tbPKID.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a valid Order ID");
                tbPKID.Clear();
            }
            else
            {

                string commandText = "DELETE FROM Ticket WHERE PKID = @PKID";
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    {
                        SqlCommand sqlUpdate = new SqlCommand(commandText, cn);
                        sqlUpdate.Parameters.AddWithValue("PKID", tbPKID.Text);
                        sqlUpdate.ExecuteNonQuery();
                        MessageBox.Show("Succesfully Deleted");
                        cn.Close();

                        tbPKID.Clear();
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
        }
    }
}

