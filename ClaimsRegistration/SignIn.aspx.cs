using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ClaimsRegistration
{
    public partial class SignIn : System.Web.UI.Page
    {
        string ST = "Data Source=DESKTOP-L7KVMKE\\SQLEXPRESS;Initial Catalog=Claims;Integrated Security=True;";
     

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Un = String.Empty;
                string pwd = string.Empty;
                Un = LoginTxtLn1.Text.Trim();
                pwd = LoginTxtPw.Text;

                SqlConnection con = new SqlConnection(ST);
                try
                {
                    con.Open();
                    SqlCommand Obj = new SqlCommand("select count(*) from ClaimsUserRegistertab where Username ='" + Un + "' and Password = '" + pwd + "'", con);
                    int i = Convert.ToInt32(Obj.ExecuteScalar());
                    con.Close();
                    if (i > 0)
                    {
                        Session["UserName"] = Un;
                        Response.Redirect("Dashboard.aspx");
                    }
                    else if (i == 0)
                    {
                        // Response.Write("Goto login");
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Invalid crediantials');", true);
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}