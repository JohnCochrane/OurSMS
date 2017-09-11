<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeBehind="AddEditUser.aspx.cs" MasterPageFile="~/Main.Master" Inherits="OurSMS.AddUser" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <div class="container">

        <div class="form-horizontal">
            <h2 class="form-signin-heading">Add Account</h2>

            <div class="form-group">
                <label runat="server" for="inputRole" class="col-sm-2 control-label">What is the Role of the Account:</label>
                <div class="col-sm-10">
                    <asp:DropDownList runat="server" ID="DropDownListRole" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownListRole_SelectedIndexChanged">
                        <asp:ListItem Text="Select Role" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Student" Value="Student"></asp:ListItem>
                        <asp:ListItem Text="Teacher" Value="Teacher"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputFirstName" id="lblFirstname" class="col-sm-2 control-label">Firstname:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputFirstName" text="FirstName" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputSurname" id="lblLastname" class="col-sm-2 control-label">Lastname:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputSurname" text="Surname" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputDOB" id="lblDOB" class="col-sm-2 control-label">DOB:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputDOB" text="DOB" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputAddress" id="lblAddress" class="col-sm-2 control-label">Address Line 1:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputAddress" text="Address" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputAddress2" id="lblAddress2" class="col-sm-2 control-label">Address Line 2:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputAddress2" text="Address" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputAddress3" id="lblAddress3" class="col-sm-2 control-label">Address Line 3:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputAddress3" text="Address" />
                </div>
            </div>


            <div class="form-group">
                <label runat="server" for="inputPostcode" id="lblPostcode" class="col-sm-2 control-label">Postcode:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputPostcode" text="Postcode" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputCountry" id="lblCountry" class="col-sm-2 control-label">Country:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputCountry" text="Country" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputMobileNo" id="lblMobNo" class="col-sm-2 control-label">Mobile Number:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputMobileNo" placeholder="Telephone" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputEmergencyNum" id="lblEmergencyNum" class="col-sm-2 control-label">Emergency Number:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputEmergencyNum" text="Telephone" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="ddlDisability" id="lblDis" class="col-sm-2 control-label">Disability :</label>
                <div class="col-sm-10">
                    <asp:CheckBox runat="server" ID="chkDisability" />
                </div>
            </div>


            <div class="form-group">
                <label runat="server" for="inputNote" id="lblNotes" class="col-sm-2 control-label">Notes :</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputNotes" text="Text" />
                </div>
            </div>
            <div class="form-group">
                <label runat="server" for="inputTag" id="lblTag" class="col-sm-2 control-label">Tag Type:</label>
                <div class="col-sm-10">
                    <input runat="server" type="text" class="form-control" id="inputTag" text="Text" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="ddlYearGroupID" id="lblYearGroup" class="col-sm-2 control-label">Year Group ID:</label>
                <div class="col-sm-10">
                    <asp:DropDownList runat="server" ID="ddlYearGroupID" Width="200px">
                        <asp:ListItem Text="Select Year Group" Value="0"></asp:ListItem>
                        <asp:ListItem Text="1st Year" Value="1"></asp:ListItem>
                        <asp:ListItem Text="2nd Year" Value="2"></asp:ListItem>
                        <asp:ListItem Text="3rd Year" Value="3"></asp:ListItem>
                        <asp:ListItem Text="4th Year" Value="4"></asp:ListItem>
                        <asp:ListItem Text="5th Year" Value="5"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputEmail" id="lblEmail" class="col-sm-2 control-label">Email Address:</label>
                <div class="col-sm-10">
                    <input runat="server" type="email" class="form-control" id="inputEmail" placeholder="Email" />
                </div>
            </div>

            <div class="form-group">
                <label runat="server" for="inputPassword" id="lblPassword" class="col-sm-2 control-label">Password:</label>
                <div class="col-sm-10">
                    <input runat="server" type="password" class="form-control" id="inputPassword" placeholder="Password" size="10" />
                </div>
            </div>


            <div class="form-group">
                <label runat="server" for="inputAge" id="lblPrivilage" class="col-sm-2 control-label">Privilage :</label>
                <div class="col-sm-10">
                    <asp:DropDownList runat="server" ID="ddlPrivilage" Width="200px">
                        <asp:ListItem Text="Select Level" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Level 1" Value="Level 1"></asp:ListItem>
                        <asp:ListItem Text="Level 2" Value="Level 2"></asp:ListItem>
                        <asp:ListItem Text="Level 3" Value="Level 3"></asp:ListItem>
                        <asp:ListItem Text="Level 4" Value="Level 4"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button runat="server" ID="btnProceed" OnClick="btnProceed_Click" Text="Proceed" />
                <asp:Button runat="server" ID="clear" Text="Reset" OnClick="clear_Click" />
                <asp:Button runat="server" ID="btnBack" Text="Reset" OnClick="btnBack_Click" />


            </div>

            <div class="col-sm-offset-2 col-sm-10">
                <asp:Label runat="server" ID="lblMessage"></asp:Label>
            </div>


        </div>


    </div>
</asp:Content>





