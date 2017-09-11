using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace OurSMS
{
    public partial class AddUser : System.Web.UI.Page
    {
        private OurSMS.Models.OurSMSEntitiesDB temp = new Models.OurSMSEntitiesDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ////Models.User user = new Models.User();
                //Models.Student_tbl student = new Models.Student_tbl();

                //student.ID = 1;
                //student.Firstname = "John";
                //student.Lastname = "Cochrane";
                //student.Age = 15;
                //student.email = "johnpatrickcochrane@gmail.com";
                //student.password = "password";




                //if you get time look into encrypting passwords
                //student.password = inputPassword.Value;

                //temp.Student_tbl.Add(student);
                //temp.SaveChanges();

                //var studentsw = temp.Student_tbl.Where(x => x.ID == 1);

                //temp.Users.Add(user);
                //temp.SaveChanges();

                //var usersw = temp.Users.Where(x => x.ID == 1);

                //var t = (from c in temp.Users
                //         where c.username == "John"
                //         select c).ToList();
            }//emd of Postback

        }//end of page_load

        protected void DropDownListRole_Click(object sender, EventArgs e) {

            if (DropDownListRole.SelectedIndex == 1)
            {
                ddlAge.Visible = false;
            }
            else if (DropDownListRole.SelectedIndex == 2) {
                ddlAge.Visible = true;
            }//end of if

        }//end of dropdownlistRole

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            Models.Student_tbl student = new Models.Student_tbl();
            Models.Staff staff = new Models.Staff();
            Models.User user = new Models.User();

           
            
            student.Firstname = inputFirstName.Value;
            student.Lastname = inputSurname.Value;
            student.Age = Convert.ToInt32(ddlAge.SelectedValue);
            student.email = inputEmail.Value;
            student.password = inputPassword.Value;

            temp.Student_tbl.Add(student);
            temp.SaveChanges();

            var studentsw = temp.Student_tbl.Where(x => x.ID == 1);            

            lblMessage.Text = ("Student was successfully added!");

            inputFirstName.Value = "";
            inputSurname.Value = "";
            ddlAge.SelectedIndex = 0;
            inputEmail.Value = "";

            



        }//end of btnsignin

    }//end of public class
}//end of namespace