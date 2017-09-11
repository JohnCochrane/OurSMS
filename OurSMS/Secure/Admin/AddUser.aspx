<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" MasterPageFile="~/Main.Master" Inherits="OurSMS.AddUser" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <div class="container">

        <div class="form-horizontal">
            <h2 class="form-signin-heading">Add Account</h2>
            
             <div class="form-group">
                <label runat="server" for="inputRole" class="col-sm-2 control-label">What is the Role of the Account:</label>
                <div class="col-sm-10">
                    <asp:DropDownList runat="server" ID="DropDownListRole" Width="200px">
                        <asp:ListItem Text="Select Role" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Student" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Teacher" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputFirstName" class="col-sm-2 control-label">Firstname:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputFirstName" text="FirstName" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputSurname" class="col-sm-2 control-label">Surname:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputSurname" text="Surname" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputEmail" class="col-sm-2 control-label">Email Address:</label>
                <div class="col-sm-10">
                    <input runat="server" type="email" class="form-control" id="inputEmail" placeholder="Email" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputPassword" class="col-sm-2 control-label">Password:</label>
                <div class="col-sm-10">
                    <input runat="server" type="password" class="form-control" id="inputPassword" placeholder="Password" size="10" />
                </div>
            </div>
           
            <div class="form-group">
                <label runat="server" for="inputAge" class="col-sm-2 control-label">Date of Birth:</label>
                <div class="col-sm-10">
                    <asp:DropDownList runat="server" ID="ddlAge" Width="200px">
                        <asp:ListItem Text="Select Age" Value="0"></asp:ListItem>
                        <asp:ListItem Text="11" Value="11"></asp:ListItem>
                        <asp:ListItem Text="12" Value="12"></asp:ListItem>
                        <asp:ListItem Text="13" Value="13"></asp:ListItem>
                        <asp:ListItem Text="14" Value="14"></asp:ListItem>
                        <asp:ListItem Text="15" Value="15"></asp:ListItem>
                        <asp:ListItem Text="16" Value="16"></asp:ListItem>
                        <asp:ListItem Text="17" Value="17"></asp:ListItem>
                        <asp:ListItem Text="18" Value="18"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button runat="server" ID="btnProceed" OnClick="btnProceed_Click" Text="Proceed" />
            </div>

            <div class="col-sm-offset-2 col-sm-10">
                <asp:label runat="server" id="lblMessage"></asp:label>
            </div>
        </div>

    </div>
</asp:Content>





