using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OurSMS.Secure.Admin
{
    public partial class AdminHomepage : System.Web.UI.Page
    {
        private Models.OurSMSEntitiesNew2 Test = new Models.OurSMSEntitiesNew2();

        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["username"];

            //gets ID and Name
            var ID = (from d in Test.Users
                             where d.username.Contains(email)
                             select d).ToList();
            lblEmail.Text = "Email: " + email;
           

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String searchResult = inputSearch.Value;

            Response.Redirect("./AddEditUser.aspx?search="+searchResult);
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Navigation/Login.aspx");
        }
    }
}