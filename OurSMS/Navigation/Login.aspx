<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OurSMS.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <div class="container">
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="form-signin">
            <h2 class="form-signin-heading">Please sign in</h2>

            <div class=".form-signin input[type='email']">
                <div style="width:450px;">
                    <input runat="server" type="email" class="form-control" id="inputEmail" placeholder="Email" size="20"/>

                </div>

            </div>
            <div class=".form-signin input[type='password']">
                <div style="width:450px;">
                    <input runat="server" type="password" class="form-control" id="inputPassword" placeholder="Password" size="20" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-10">
                    <asp:Button runat="server" ID="btnSignIn" OnClick="btnSignIn_Click" Text="Sign-in" />
                </div>
            </div>
        </div>


    </div>
    <!-- /container -->

</asp:Content>

