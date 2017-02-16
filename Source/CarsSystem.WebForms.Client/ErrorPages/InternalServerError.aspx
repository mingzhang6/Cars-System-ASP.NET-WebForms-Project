<%@ Page Language="C#" AutoEventWireup="true" Title="Internal server error page !" MasterPageFile="~/Site.Master" CodeBehind="InternalServerError.aspx.cs" Inherits="CarsSystem.WebForms.Client.ErrorPages.InternelServerError" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="Server">
    <br />
    <div class="row">
        <div class="well col-md-8 col-md-offset-2 text-center">
            <h2>500 ERROR</h2>
            <p>
                Internal server error!
            </p>
            <p>
                Sorry, the application will be back soon! :/
            </p>
        </div>
    </div>
</asp:Content>
