using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace OurSMS.Secure.Teacher
{


    public partial class TeacherViewAttendance : System.Web.UI.Page
    {
        private Models.OurSMSEntitiesNew2 Test = new Models.OurSMSEntitiesNew2();
        private int studentId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            string studentID = Request.QueryString["studentid"];

            StringBuilder table = new StringBuilder();

            if (!Page.IsPostBack)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["OurSMS"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                if (studentID != null) {
                    cmd.CommandText = "Select * from [Attendance] where StudentID = " + studentID;
                }else
                {
                    cmd.CommandText = "Select * from [Attendance]";

                }
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                table.Append("<table border='1'>");
                table.Append("<tr>,<th>AttendanceID</th><th>TagID</th><th>StudentID</th><th>ClassroomID</th><th>Timestamp</th>");
                table.Append("</tr>");

                if (rd.HasRows)
                {
                    while (rd.Read()) {
                        table.Append("<tr>");
                        table.Append("<td>" + rd[0] + "</td>");
                        table.Append("<td>" + rd[1] + "</td>");
                        table.Append("<td>" + rd[2] + "</td>");
                        table.Append("<td>" + rd[3] + "</td>");
                        table.Append("<td>" + rd[4] + "</td>");
                        table.Append("</tr>");
                    }

                }//end of if has rows

                table.Append("</table");
                placeholder.Controls.Add(new Literal { Text = table.ToString() });
                rd.Close();

            }//end of if postback

        }//end of page load
    }//end of class
}//end of namespace