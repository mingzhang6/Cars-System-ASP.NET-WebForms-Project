<%@ Page Language="C#" AutoEventWireup="true" Title="Customer details page" MasterPageFile="~/Site.Master" CodeBehind="CustomerDetails.aspx.cs" Inherits="CarsSystem.WebForms.Client.Customers.CustomerDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1 class="text-center">Customer details page!</h1>
        <div class="well col-md-6 col-md-offset-3">
            <br />
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="First name: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="FirstnameLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Second name: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="SecondNameLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Last name: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="LastNameLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="EGN: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="EGNLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Number of id card: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="NumberOfIdCardLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Date of issue: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="DateOfIssueLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="City: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="CityLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Phone number: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="PhoneNumberLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Email: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="EmailLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Check customer's car: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:HyperLink  ID="CheckCustomerCarLabel" runat="server" Text="CarInfoLink"></asp:HyperLink>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
