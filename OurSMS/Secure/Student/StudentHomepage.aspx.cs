using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OurSMS.Secure.Student
{
    public partial class StudentHomepage : System.Web.UI.Page
    {
        private Models.OurSMSEntitiesNew2 Test = new Models.OurSMSEntitiesNew2();
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["username"];
           
            //gets ID and Name
            var StudentID = (from d in Test.Student_tbl
                             where d.email.Contains(email)
                             select d).ToList();
            lblEmail.Text = email;

            if (StudentID.Count == 1)
            {
                Session["StudentID"] = StudentID.FirstOrDefault().ID;

                Models.Student_tbl stu = StudentID.FirstOrDefault();

                lblID.Text = Convert.ToString("Student ID: " + stu.ID);
                lblUser.Text = "User Logged in: " + stu.Firstname + " " + stu.Lastname;

            }//end of if
        }//end of Page_Load

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Navigation/Login.aspx");

        }
    }
}