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
    //TUESDAY 11th April
    // Created a new database called TestSMS
    // Created all the tables
    // Added the relationships
    // Tried to add grid view to pull in year group ID to student table didn't work
    // ALSO WHEN TRIED TO SAVE CHANGES IT DOESN'T ACTUALLY SAVE THE CHANGES TO THE DATABASE
    // TRIED IT WITHOUT ADDING TO OTHER TABLES, THROW EXCEPTION STATING THAT TAG ID ISN'T AVAILABLE, 
    // CAUSE IT DOESN'T EXISIT 



    public partial class AddUser : System.Web.UI.Page
    {
        private Models.OurSMSEntitiesNew2 Test = new Models.OurSMSEntitiesNew2();

        //Imports table from Database 
        private Models.Student_tbl stu = new Models.Student_tbl();
        private Models.Staff staf = new Models.Staff();
        private Models.User user = new Models.User();
        private Models.YearGroup youG = new Models.YearGroup();
        private Models.Tag tag = new Models.Tag();


        /// <summary>
        /// On Page Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //var searchResult = Request.QueryString["search"];
                //editUserSetup(searchResult);

                ////Models.User user = new Models.User();
                //Models.Student_tbl student = new Models.Student_tbl();

                //student.ID = 1;
                //student.Firstname = "John";
                //student.Lastname = "Cochrane";
                //student.Age = 15;
                //student.email = "johnpatrickcochrane@gmail.com";
                //student.password = "password";

                //LOADS DROP DOWN LIST



                //hides on pageload
                lblFirstname.Visible = false;
                inputFirstName.Visible = false;


                inputMobileNo.Visible = false;//student only
                lblMobNo.Visible = false;

                lblNotes.Visible = false;
                inputNotes.Visible = false;

                lblLastname.Visible = false;
                inputSurname.Visible = false;

                lblAddress.Visible = false;
                inputAddress.Visible = false;

                lblAddress2.Visible = false;
                inputAddress2.Visible = false;

                lblAddress3.Visible = false;
                inputAddress3.Visible = false;

                lblCountry.Visible = false;
                inputCountry.Visible = false;

                chkDisability.Visible = false;
                lblDis.Visible = false;

                lblPostcode.Visible = false;
                inputPostcode.Visible = false;


                lblTag.Visible = false;
                inputTag.Visible = false;

                lblYearGroup.Visible = false;
                ddlYearGroupID.Visible = false;

                lblEmergencyNum.Visible = false;
                inputEmergencyNum.Visible = false;


                lblEmail.Visible = false;
                inputEmail.Visible = false;

                lblPassword.Visible = false;
                inputPassword.Visible = false;

                inputDOB.Visible = false; //STUDENT ONLY
                lblDOB.Visible = false;

                ddlPrivilage.Visible = false; // STAFF ONLY
                lblPrivilage.Visible = false;

                btnProceed.Visible = false;
                clear.Visible = false;
            }//emd of Postback

        }//end of page_load


        /// <summary>
        /// Action used on button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnProceed_Click(object sender, EventArgs e)
        {


            AddUsr();//Calls the addUsr Method once btn is clicked



        }//end of btnsignin


        /// <summary>
        /// This is used to display the correct input controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownListRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListRole.SelectedIndex == 0)
            {
                lblMessage.Text = "Please Select a Role to Continue!!!!";

            }
            else if (DropDownListRole.SelectedIndex == 1)//Student is true
            {
                lblFirstname.Visible = true;
                inputFirstName.Visible = true;

                lblLastname.Visible = true;
                inputSurname.Visible = true;

                lblAddress.Visible = true;
                inputAddress.Visible = true;

                lblAddress2.Visible = true;
                inputAddress2.Visible = true;

                lblAddress3.Visible = true;
                inputAddress3.Visible = true;

                lblCountry.Visible = true;
                inputCountry.Visible = true;

                chkDisability.Visible = true;
                lblDis.Visible = true;

                lblPostcode.Visible = true;
                inputPostcode.Visible = true;

                inputMobileNo.Visible = true;
                lblMobNo.Visible = true;

                lblNotes.Visible = true;
                inputNotes.Visible = true;

                lblTag.Visible = true;
                inputTag.Visible = true;

                lblYearGroup.Visible = true;
                ddlYearGroupID.Visible = true;

                lblEmail.Visible = true;
                inputEmail.Visible = true;

                lblPassword.Visible = true;
                inputPassword.Visible = true;

                inputDOB.Visible = true; //STUDENT ONLY
                lblDOB.Visible = true;

                ddlPrivilage.Visible = false; // STAFF ONLY
                lblPrivilage.Visible = false;

                btnProceed.Visible = true;
                clear.Visible = true;

            }
            else if (DropDownListRole.SelectedIndex == 2)//Staff is true
            {
                lblFirstname.Visible = true;
                inputFirstName.Visible = true;

                lblLastname.Visible = true;
                inputSurname.Visible = true;

                lblAddress.Visible = false;//student only
                inputAddress.Visible = false;

                lblAddress2.Visible = false;
                inputAddress2.Visible = false;

                lblAddress3.Visible = false;
                inputAddress3.Visible = false;

                lblEmergencyNum.Visible = false;
                inputEmergencyNum.Visible = false;

                lblCountry.Visible = false;
                inputCountry.Visible = false;

                chkDisability.Visible = false;
                lblDis.Visible = false;

                lblPostcode.Visible = false;//student only
                inputPostcode.Visible = false;

                inputMobileNo.Visible = false;//student only
                lblMobNo.Visible = false;

                lblNotes.Visible = false;//student only
                inputNotes.Visible = false;

                lblNotes.Visible = false;//student only
                inputNotes.Visible = false;

                lblTag.Visible = false;//student only
                inputTag.Visible = false;

                lblYearGroup.Visible = false;//student only
                ddlYearGroupID.Visible = false;

                lblEmail.Visible = true;
                inputEmail.Visible = true;

                lblPassword.Visible = true;
                inputPassword.Visible = true;

                inputDOB.Visible = false; //STUDENT ONLY
                lblDOB.Visible = false;

                ddlPrivilage.Visible = true;
                lblPrivilage.Visible = true;

                btnProceed.Visible = true;
                clear.Visible = true;
            }//end of if
        }//end of drop

        /// <summary>
        /// This method used to determine which user is being added
        /// Using the drop down this selects the role to be added
        /// Each role has different insert features 
        /// 
        /// </summary>
        public void AddUsr()
        {
            //1 = student
            if (DropDownListRole.SelectedIndex == 1)
            {
                try
                {
                    //Adding a student required update depending tables
                    //User, Student, User, YearGroup
                    DateTime dob = DateTime.UtcNow;
                    string email = string.Empty;
                    string fName = string.Empty;
                    string lName = string.Empty;
                    string pword = string.Empty;
                    string emergencyNum = string.Empty;
                    string mobileNum = string.Empty;

                    string line1 = string.Empty;
                    string line2 = string.Empty;
                    string line3 = string.Empty;
                    string postcode = string.Empty;
                    string country = string.Empty;

                    string notes = string.Empty;

                    string tagtype = string.Empty;

                    int yearGroupID = 0;

                    dob = Convert.ToDateTime(inputDOB.Value);
                    email = inputEmail.Value;
                    fName = inputFirstName.Value;
                    lName = inputSurname.Value;
                    pword = inputPassword.Value;
                    emergencyNum = Convert.ToString(inputMobileNo.Value);
                    mobileNum = Convert.ToString(inputEmergencyNum.Value);
                    bool disailbity = chkDisability.Checked;
                    notes = inputNotes.Value;

                    line1 = inputAddress.Value;
                    line2 = inputAddress2.Value;
                    line3 = inputAddress3.Value;
                    postcode = inputPostcode.Value;
                    country = inputCountry.Value;

                    tagtype = Convert.ToString(inputTag.Value);

                    yearGroupID = Convert.ToInt32(ddlYearGroupID.SelectedValue);

                    //var YearGroup = (from u in Test.YearGroups
                    //                 where u.ID == yearGroupID 
                    //                 select u).FirstOrDefault();

                    //Session.Add("get Year Group id", YearGroup);


                    //string email = inputEmail.Value;
                    //string password = inputPassword.Value;

                    //var user = (from u in temp.User
                    //            where u.email == email
                    //            && u.password == password
                    //            select u).FirstOrDefault();

                    //Student
                    Models.Student_tbl temp = new Models.Student_tbl()
                    {
                        DOB = dob,
                        email = email,
                        Firstname = fName,
                        Lastname = lName,
                        MobileNumber = mobileNum,
                        EmergencyContactNumber = emergencyNum,
                        Disability = disailbity,
                        Notes = notes,
                        YearGroup_ID = yearGroupID
                    };
                    //Saves changes
                    Test.Student_tbl.Add(temp);
                    Test.SaveChanges();

                    //retrieve the new user i have just created
                    Models.Student_tbl newStudent = Test.Student_tbl.Where(x => x.email == email && x.Firstname == fName && x.Lastname == lName).FirstOrDefault();

                    ///////////////////////////////////////////////////////////////////////////////////////////

                    //Address
                    Models.Address addressTemp = new Models.Address()
                    {

                        Line1 = line1,
                        Line2 = line2,
                        Line3 = line3,
                        Postcode = postcode,
                        Country = country,
                        Telephone = mobileNum,

                    };
                    //SAVES Changes                
                    Test.Addresses.Add(addressTemp);
                    Test.SaveChanges();

                    //retrieve the new address i have just created
                    Models.Address newAddress = Test.Addresses.Where(x => x.Telephone == mobileNum && x.Line1 == line1).FirstOrDefault();


                    //Student_Address
                    Models.Student_Address studentAddressTemp = new Models.Student_Address()
                    {
                        Student_ID = newStudent.ID,
                        Address_ID = newAddress.ID

                    };

                    //Adds temp StudentAddress
                    Test.Student_Address.Add(studentAddressTemp);
                    Test.SaveChanges();
                    //////////////////////////////////////////////////////////////////////////////////



                    //TAG TABLE
                    Models.Tag tagTemp = new Models.Tag()
                    {
                        TagType = tagtype
                    };
                    ///Save Changes
                    Test.Tags.Add(tagTemp);
                    Test.SaveChanges();

                    //retrieve the new tag i just created
                    Models.Tag newTag = Test.Tags.Where(x => x.TagType == tagtype).FirstOrDefault();

                    //Student_tag
                    Models.Student_Tag studenttagTemp = new Models.Student_Tag()
                    {
                        Student_ID = newStudent.ID,
                        Tag_ID = newTag.ID
                    };

                    //adds student tag temp
                    Test.Student_Tag.Add(studenttagTemp);
                    Test.SaveChanges();
                    /////////////////////////////////////////////////////////////////////////////////

                    //User table
                    Models.User userTemp = new Models.User()
                    {
                        username = email,
                        password = pword

                    };

                    Test.Users.Add(userTemp);
                    Test.SaveChanges();

                    Models.User newUser = Test.Users.Where(x => x.username == email).FirstOrDefault();

                    ///Student User 
                    Models.StudentUser studentUserTemp = new Models.StudentUser()
                    {
                        User_ID = newUser.ID,
                        Student_ID = newStudent.ID

                    };

                    Test.StudentUsers.Add(studentUserTemp);
                    Test.SaveChanges();



                    var query = (from s in Test.Student_tbl
                                 join sa in Test.Student_Address on s.ID equals sa.Student_ID
                                 join a in Test.Addresses on sa.Address_ID equals a.ID
                                 select new
                                 {
                                     Student = s,
                                     Address = a
                                 }).FirstOrDefault();

                    var address = query.Address;
                    var student = query.Student;


                    Test.SaveChanges();//Saves Changes to Database    

                    var addstu = Test.Student_tbl.Where(x => x.ID == 1);
                    var adduser = Test.Users.Where(x => x.ID == 1);
                    var addtag = Test.Tags.Where(x => x.ID == 1);
                    var addYear = Test.YearGroups.Where(x => x.ID == 1);

                    lblMessage.Text = ("Student was successfully added!");//displays once successful add of student

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex);
                }//end of trycatch            
                 //end of true
            }
            else if (DropDownListRole.SelectedIndex == 2)
            {
                //TEACHER

                try
                {
                    string fName = string.Empty;
                    string lName = string.Empty;
                    string pword = string.Empty;
                    string role = string.Empty;
                    string privilage = string.Empty;
                    string email = string.Empty;

                    fName = inputFirstName.Value;
                    lName = inputSurname.Value;
                    pword = inputPassword.Value;
                    role = DropDownListRole.SelectedValue;
                    privilage = ddlPrivilage.SelectedValue;
                    email = inputEmail.Value;



                    ///Staff table
                    Models.Staff staffTemp = new Models.Staff()
                    {

                        FirstName = fName,
                        Surname = lName,
                        Role = role,
                        Privilage = privilage,
                        Email = email

                    };

                    Test.Staffs.Add(staffTemp);
                    Test.SaveChanges();

                    Models.Staff newStaff = Test.Staffs.Where(x => x.Email == email).FirstOrDefault();

                    //User table
                    Models.User userTemp = new Models.User()
                    {
                        username = email,
                        password = pword

                    };

                    Test.Users.Add(userTemp);
                    Test.SaveChanges();

                    Models.User newUser = Test.Users.Where(x => x.username == email).FirstOrDefault();

                    //Link StaffUser table

                    Models.Staff_User staffuser = new Models.Staff_User()
                    {
                        UserID = newUser.ID,
                        StaffID = newStaff.ID
                    };

                    Test.Staff_User.Add(staffuser);
                    Test.SaveChanges();

                    lblMessage.Text = ("Teacher was successfully added!");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex);
                }//end try    



            }//end of elseif
        }//end of addUser

        /// <summary>
        /// This method used to clear the input controls 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void clear_Click(object sender, EventArgs e)
        {

            inputFirstName.Value = "";
            inputSurname.Value = "";
            inputAddress.Value = "";
            inputPostcode.Value = "";
            inputMobileNo.Value = "";
            inputEmail.Value = "";
            inputPassword.Value = "";
            inputDOB.Value = ""; //STUDENT ONLY
            ddlPrivilage.SelectedIndex = 1; // STAFF ONLY

        }//end of clear click

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomepage.aspx");
        }

        //protected void editUserSetup(string searchResult)
        //{
        //var query = (from s in Test.Student_tbl
        //             where s.email.Contains(searchResult)
        //             select s).ToList();


        //    if (query.Count == 1)
        //    {
        //        Models.Student_tbl student = query.FirstOrDefault();
        //        Models.Address address = new Models.Address();
        //        dob = Convert.ToDateTime(inputDOB.Value);
        //        email = inputEmail.Value;
        //        fName = inputFirstName.Value;
        //        lName = inputSurname.Value;
        //        pword = inputPassword.Value;
        //        emergencyNum = Convert.ToString(inputMobileNo.Value);
        //        mobileNum = Convert.ToString(inputEmergencyNum.Value);
        //        bool disailbity = chkDisability.Checked;
        //        notes = inputNotes.Value;

        //        line1 = inputAddress.Value;
        //        line2 = inputAddress2.Value;
        //        line3 = inputAddress3.Value;
        //        postcode = inputPostcode.Value;
        //        country = inputCountry.Value;

        //        Gets the data and adds to fields



        //        inputFirstName.Value = student.Firstname;
        //        inputSurname.Value = student.Lastname;
        //        inputDOB.Value = Convert.ToString(student.DOB);
        //        inputMobileNo.Value = student.MobileNumber;
        //        inputEmergencyNum.Value = student.EmergencyContactNumber;
        //        inputAddress.Value = student.MobileNumber;
        //        inputEmail.Value = student.email;
        //        inputNotes.Value = student.Notes;


        //        address
        //        inputAddress.Value = address.Line1;
        //        inputAddress2.Value = address.Line2;
        //        inputAddress3.Value = address.Line3;

        //        if (student.Disability == true)
        //        {
        //            chkDisability.Checked = true;
        //        }
        //        else if (student.Disability == false)
        //        {
        //            chkDisability.Checked = false;
        //        }

        //    }//end of query
        //}//end of search


    }//end of public class
}//end of namespace