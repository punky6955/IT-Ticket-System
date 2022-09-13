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
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }


        private void bEnter_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (String.IsNullOrEmpty(tbSearch.Text) || !int.TryParse(tbSearch.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a valid Tech ID");
                tbSearch.Clear();
            }
            else
            {
                try
                {
                    //check connection status and if closed open it
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskReport.Properties.Settings.DataBaseConnectionString"].ConnectionString))
                    {
                        if (cn.State == ConnectionState.Closed)
                            cn.Open();
                        using (DataTable dt = new DataTable("techs"))
                        {
                            using (SqlCommand cmd = new SqlCommand("select * from [dbo].[Ticket] where Assigned_Tech=@techID", cn))
                            {
                                cmd.Parameters.AddWithValue("techID", tbSearch.Text);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);
                                dataGridView.DataSource = dt;
                                lblTotal.Text = $"Total Rows: {dataGridView.RowCount}";
                                cn.Close();
                            }
                        }

                        if (String.IsNullOrEmpty(tbSearch.Text))
                        {
                            MessageBox.Show("Please enter a value, or click Select All", "Error!");
                        }
                    }
                    tbSearch.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Restart Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if enter is pressed is same as clicking button
            if (e.KeyChar == (char)13)
                bEnter.PerformClick();
        }

        private void bSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                //check connection status and if closed open it
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskReport.Properties.Settings.DataBaseConnectionString"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("all"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select * from [dbo].[Ticket] Order by Assigned_Tech", cn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                            lblTotal.Text = $"Total Rows: {dataGridView.RowCount}";
                        }
                    }
                }
                tbSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Restart Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
