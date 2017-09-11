using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace OurSMS
{
    public partial class Login : System.Web.UI.Page
    {
        private Models.OurSMSEntitiesNew2 Test = new Models.OurSMSEntitiesNew2();

        //This work once is was connected to the OurSMS Database. Its currently connected to TestSMS
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Models.User user = new Models.User();

                //user.username = "john123";

                ////if you get time look into encrypting passwords
                //user.password = "password";

                //temp.User.Add(user);
                //temp.SaveChanges();

                //var usersw = temp.Users.Where(x => x.ID == 1);

                ////var t = (from c in temp.Users
                ////         where c.username == "John"
                ////         select c).ToList();

                //DataTable dt = new DataTable();
                //SqlDataAdapter da = new SqlDataAdapter();
                //da.Fill(dt);
                //foreach (DataRow dr in dt.Rows) {
                //    Session["username"] = dr["username"].ToString();
                //}



            }//emd of Postback

        }//end of page load

       

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = Convert.ToString(inputEmail.Value);
            string password = inputPassword.Value;


            if (email.Contains("@staff.oursms.ac.uk"))
            {
                var user = (from u in Test.Users
                            where u.username == email
                            && u.password == password
                            select u).FirstOrDefault();
                Session.Add("Staff User", user);
                Response.Redirect("~/Secure/Teacher/TeacherHomepage.aspx?username=" + inputEmail.Value); 
            }
            else if (email.Contains("@student.oursms.ac.uk"))
            {
                var user = (from u in Test.Users
                            where u.username == email
                            && u.password == password
                            select u).FirstOrDefault();
                Session.Add("Student User", user);
                Response.Redirect("~/Secure/Student/StudentHomepage.aspx?username=" + inputEmail.Value);
            }
            else if (email.Contains("@admin.ac.uk")) {
                var user = (from u in Test.Users
                            where u.username == email
                            && u.password == password
                            select u).FirstOrDefault();
                Session.Add("Admin User", user);

                Response.Redirect("~/Secure/Admin/AdminHomepage.aspx?username=" + inputEmail.Value);
            }
            

            

        }//end of btnsignin
    }
}