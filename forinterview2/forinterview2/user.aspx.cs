using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forinterview2
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //password need to change in database login
            string connectionString = "Data Source =DESKTOP-DPDLQMP; Initial Catalog = interview01; User ID = loginnew; Password = 922480710;";

            try
            {
                // Get values from controls
                string id = txtid.Text;
                string name = Txtname.Text;
                DateTime dob = Convert.ToDateTime(txtdob.Text);
                decimal salary = Convert.ToDecimal(txtsalary.Text);
                bool active = CheckBox1.Checked;

                // Establish database connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create SQL command
                    SqlCommand cmd = new SqlCommand("INSERT INTO task2 (id, name, dob, salary, active) VALUES (@id, @name, @dob, @salary, @active)", connection);

                    // Add parameters with proper data types
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@dob", SqlDbType.Date).Value = dob;
                    cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = salary;
                    cmd.Parameters.Add("@active", SqlDbType.Bit).Value = active;

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Clear input fields and provide success message
                    txtid.Text = "";
                    Txtname.Text = "";
                    txtdob.Text = "";
                    txtsalary.Text = "";
                    CheckBox1.Checked = false;
                    lblMessage.Text = "Data inserted successfully!"; // Assuming a Label control for feedback
                }
            }
            catch (Exception ex)
            {
                // Handle any errors (e.g., display an error message)
                lblMessage.Text = "Error: " + ex.Message;
            }





        }
    }
}