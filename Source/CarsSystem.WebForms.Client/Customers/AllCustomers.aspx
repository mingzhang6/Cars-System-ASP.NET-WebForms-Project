<%@ Page Language="C#" AutoEventWireup="true" Title="All customers page" MasterPageFile="~/Site.Master" CodeBehind="AllCustomers.aspx.cs" Inherits="CarsSystem.WebForms.Client.Customers.AllCustomers" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row col-md-offset-4">
        <asp:Label ID="SearchLabel" runat="server" Text="Type EGN:"></asp:Label>
        <asp:TextBox ID="SearchTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SearchButton" runat="server" Text="Search" OnClick="SearchButton_Click" CssClass="btn btn-default" Width="143px"/>
    </div>
    <div class="row">
        <br />
        <div class="well col-md-4 col-md-offset-4">
            <h1 class="text-center">All customers page!</h1>
            <br />
            <asp:GridView ID="AllCustomersGridView" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-hover text-center form-group">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="First name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last name" />
                    <asp:HyperLinkField
                        HeaderText="Username"
                        DataTextField="Username"
                        DataNavigateUrlFields="Id"
                        DataNavigateUrlFormatString="~/Customers/CustomerDetails.aspx?id={0}" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
