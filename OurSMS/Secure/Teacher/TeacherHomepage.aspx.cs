using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OurSMS.Secure.Teacher
{
    public partial class TeacherHomepage : System.Web.UI.Page
    {
        private Models.OurSMSEntitiesNew2 Test = new Models.OurSMSEntitiesNew2();

        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["username"];

            //gets ID and Name
            var UserInfo = (from d in Test.Staffs
                             where d.Email.Contains(email)
                             select d).ToList();
            lblEmail.Text = "Email: " + email;

            if(UserInfo.Count == 1)
            {
                Models.Staff sta = UserInfo.FirstOrDefault();

                lblID.Text = Convert.ToString("Staff ID: " + sta.ID);
                lblUser.Text = "Hello!: " + sta.FirstName + " " + sta.Surname;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Navigation/Login.aspx");
        }

        protected void btnSearchAttenance_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Secure/Teacher/TeacherViewAttendance.aspx?studentid=" + txtSearchAttendance.Text);
        }
    }
}