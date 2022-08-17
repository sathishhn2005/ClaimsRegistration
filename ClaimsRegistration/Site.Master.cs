using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClaimsRegistration
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["Username"]).Length <= 0)
            {
               // Response.Redirect(Page.ResolveUrl("SignIn.aspx"));
            }

        }
        protected void Dashboard_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Dashboard.aspx");
        }
        protected void Transaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction.aspx");
        }
        protected void Claim_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddClaims.aspx");
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("SignIn.aspx");
        }
    }
}