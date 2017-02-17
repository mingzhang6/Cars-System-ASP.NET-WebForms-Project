<%@ Page Language="C#" AutoEventWireup="true" Title="All customers page" MasterPageFile="~/Site.Master" CodeBehind="AllCustomers.aspx.cs" Inherits="CarsSystem.WebForms.Client.Customers.AllCustomers" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>All customers page!</h1>
    <asp:GridView ID="AllCustomersGridView" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="FirstName" HeaderText="First name"/>
            <asp:BoundField DataField="LastName" HeaderText="Last name"/>
            <asp:HyperLinkField 
                    HeaderText="Username"
                    DataTextField="Username"
                    DataNavigateUrlFields="Id"
                    DataNavigateUrlFormatString="~/Customers/CustomerDetails.aspx?id={0}"/>
        </Columns>
    </asp:GridView>
</asp:Content>
