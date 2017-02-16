<%@ Page Language="C#" AutoEventWireup="true" Title="Forbidden page!" MasterPageFile="~/Site.Master" CodeBehind="Forbidden.aspx.cs" Inherits="CarsSystem.WebForms.Client.ErrorPages.Forbidden" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="Server">
    <br />
    <div class="row">
        <div class="well col-md-8 col-md-offset-2 text-center">
            <h2>403 ERROR</h2>
            <p>
                Access is denied!
            </p>
            <p>
                You do not have permission to view this directory or page using the credentials that you supplied! :/
            </p>
        </div>
    </div>
</asp:Content>
