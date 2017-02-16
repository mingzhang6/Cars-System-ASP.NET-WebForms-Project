<%@ Page Language="C#" AutoEventWireup="true" Title="Unauthorized page !" MasterPageFile="~/Site.Master" CodeBehind="UnauthorizedAccess.aspx.cs" Inherits="CarsSystem.WebForms.Client.UnauthorizedAccess" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="Server">
    <br />
    <div class="row">
        <div class="well col-md-8 col-md-offset-2 text-center">
            <h2>Unauthorized Access</h2>
            <p>
                You have attempted to access a page that you are not authorized to view.
            </p>
            <p>
                If you have any questions, please contact the site administrator.
            </p>
        </div>
    </div>
</asp:Content>
