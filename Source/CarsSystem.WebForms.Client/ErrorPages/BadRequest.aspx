<%@ Page Language="C#" AutoEventWireup="true" Title="Bad request page" MasterPageFile="~/Site.Master" CodeBehind="BadRequest.aspx.cs" Inherits="CarsSystem.WebForms.Client.ErrorPages.BadRequest" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="Server">
    <br />
    <div class="row">
        <div class="well col-md-8 col-md-offset-2 text-center">
            <h2>400 ERROR</h2>
            <p>
                Bad request!
            </p>
            <p>
                The server cannot or will not process the request due to an apparent client error! :/
            </p>
        </div>
    </div>
</asp:Content>