﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TeacherViewAttendance.aspx.cs" Inherits="OurSMS.Secure.Teacher.TeacherViewAttendance" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <br />
    <br />
    <br />
    <div class="container">
        <ul class="nav navbar-nav">
            <li><a runat="server" href="TeacherHomepage.aspx">Back to Dashboard</a></li>
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
            </div>
        </div>
        <br />
        <br />
        <br />
        <asp:PlaceHolder ID="placeholder" runat="server"></asp:PlaceHolder>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>

