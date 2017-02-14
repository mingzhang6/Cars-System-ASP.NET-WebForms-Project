<%@ Page Language="C#" AutoEventWireup="true" Title="All filters page" MasterPageFile="~/Site.Master" CodeBehind="Filter.aspx.cs" Inherits="CarsSystem.WebForms.Client.Filters.Filter" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Choose filter!</h1>
    <ul>
        <li><a runat="server" href="~/Filters/FilterByAnnualCheckUp">Filter By Annual Check Up</a></li>
        <li><a runat="server" href="~/Filters/FilterByVignette">Filter By Vignette</a></li>
        <li><a runat="server" href="~/Filters/FilterByInsurance">Filter By Insurance</a></li>
    </ul>
</asp:Content>
