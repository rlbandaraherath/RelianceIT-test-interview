using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forinterview2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {


            string connectionString = "Data Source = DESKTOP-DPDLQMP; Initial Catalog = interview01; User ID = loginnew; Password = A#922480710v;"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string username = txtusername.Text;
                string password = txtPassword.Text;

                string query = "SELECT userrole FROM login WHERE username = @Username AND password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object userRole = cmd.ExecuteScalar();

                    if (userRole != null)
                    {
                        string role = userRole.ToString();

                        
                        if (role == "admin")
                        {
                            Response.Redirect("admin.aspx");
                        }
                        else if (role == "user")
                        {
                            Response.Redirect("user.aspx");
                        }
                       
                    }
                    else
                    {
                        
                        Response.Write("Invalid credentials");
                    }
                }
            }


        }
    }
}