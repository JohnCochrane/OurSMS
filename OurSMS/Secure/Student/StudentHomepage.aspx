<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="StudentHomepage.aspx.cs" Inherits="OurSMS.Secure.Student.StudentHomepage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <br />
    <br />
    <br />
    <div class="container">
        <ul class="nav navbar-nav">
            <li><a runat="server" href="~/MyCource.aspx">View Subjects</a></li>
            <li><a runat="server" href="StudentViewAttendance.aspx" >My Attendance</a></li>
            <li><a runat="server" href="~/Help.aspx">Help</a></li>

           
        </ul>
        <div class="navbar-collapse collapse">
                <div class="nav navbar-nav navbar-right">
                    <asp:Label runat="server" ID="lblEmail"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblUser"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblID"></asp:Label>
                    <br />

                    <asp:Button runat="server" Text="Logout" ID="Button1" OnClick="btnLogout_Click"/>
                </div>
         </div>
        <br />
        <br />
        <br />
        <div class="form-horizontal">
            <h2 class="form-signin-heading"  >Student Dashboard</h2>
                        
            <div class="form-group">
                <label class="col-sm-2 control-label">Annoucemence</label>
                <div class="col-sm-10">
                    <p>No Annoucemences today!</p>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-2 control-label">Attendance</label>
                <div class="col-sm-10">
                    <p>Nothing to Report!</p>
                </div>

            </div>

          
        </div>

    </div>
    <!-- /container -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>
