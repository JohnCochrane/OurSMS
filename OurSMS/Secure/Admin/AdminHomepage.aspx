<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AdminHomepage.aspx.cs" Inherits="OurSMS.Secure.Admin.AdminHomepage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <br />
    <br />
    <br />
    <div class="container">

        <ul class="nav navbar-nav">
            <li><a runat="server" href="AddEditUser.aspx">Admission</a></li>
            <li><a runat="server" href="~/Student.aspx">Student</a></li>
            <li><a runat="server" href="~/Help.aspx">Help</a></li>
        </ul>
        <div class="navbar-collapse collapse">
                <div class="nav navbar-nav navbar-right">
                    <asp:Label runat="server" ID="lblEmail"></asp:Label>
                    <asp:Button runat="server" Text="Logout" ID="Button1" OnClick="btnLogout_Click" />
                </div>
         </div>
        <br />
        <br />
        <br />
        <div class="form-horizontal">
            <h2 class="form-signin-heading">Admin Dashboard</h2>

            <div class="form-group">
                <label class="col-sm-2 control-label">Annoucemence</label>
                <div class="col-sm-10">
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-2 control-label">General Information</label>
                <div class="col-sm-10">
                </div>
            </div>

            <div class="form-group">
                Find Student:
                <label class="col-sm-2 control-label">Search for Student:</label>
                <input type="text" id="inputSearch" runat="server" />
                <br />
                <asp:Button runat="server" ID="btnSearch" OnClick="btnSearch_Click" Text="Search" />
            </div>
        </div>

    </div>
    <!-- /container -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>
