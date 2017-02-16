<%@ Page Language="C#" AutoEventWireup="true" Title="All filters page" MasterPageFile="~/Site.Master" CodeBehind="Filter.aspx.cs" Inherits="CarsSystem.WebForms.Client.Filters.Filter" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <br />
        <div class="well col-md-6 col-md-offset-3">
            <h1 class="text-center">Choose filter!</h1>
            <ul class="filterList">
                <li class="listitems col-md-4 text-center"><a runat="server" href="~/Filters/FilterByAnnualCheckUp">Filter By Annual Check Up</a></li>
                <li class="listitems col-md-4 text-center"><a runat="server" href="~/Filters/FilterByVignette">Filter By Vignette</a></li>
                <li class="listitems col-md-4 text-center"><a runat="server" href="~/Filters/FilterByInsurance">Filter By Insurance</a></li>
            </ul>
        </div>
    </div>
</asp:Content>
