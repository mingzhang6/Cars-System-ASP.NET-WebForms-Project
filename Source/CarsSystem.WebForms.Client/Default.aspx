<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarsSystem.WebForms.Client._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2><strong>ASP.NET Web Forms Cars system application.</strong></h2>
        <p class="lead">
            This is application made on ASP .NET Web Forms. 
            It's purpose is to collect information about customers and their cars information.
            The application has administration panel and only user with role "Admin", can add information, about given customer and his car.
            The specific in this application is that the administrator of the application can filter cars by mannual check up, vignette and insurance expiration and on that base to send emails to thoose customers, which expiration is soon.
        </p>
        <h3><strong>Roles in the application and what can they visit.</strong></h3>
        <ul style="list-style-type: circle">
            <li>Admin - can visit all pages in the application.</li>
            <li>Regular user - can visit home, about, profile pages.</li>
            <li>Not registered user - can see only about and home page</li>
        </ul>
    </div>

</asp:Content>
