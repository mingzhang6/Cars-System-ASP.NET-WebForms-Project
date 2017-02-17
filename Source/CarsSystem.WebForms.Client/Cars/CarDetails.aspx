<%@ Page Language="C#" AutoEventWireup="true" Title="Car details page" MasterPageFile="~/Site.Master" CodeBehind="CarDetails.aspx.cs" Inherits="CarsSystem.WebForms.Client.Cars.CarDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1 class="text-center">Car details page!</h1>
        <div class="well col-md-6 col-md-offset-3">
            <br />
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Manufacturer: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="ManufacturerLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Model: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="ModelLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Type of engine: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="TypeOfEngineLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Registration number: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="RegistrationNumberLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="VIN number: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="VINLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Count Of tyres: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="CountOfTyresLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Count of doors: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="CountOfDoorsLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Type of car: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="TypeOfCarLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Year of manufactoring: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="YearOfManufactoringLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Annual check up valid until: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="AnnualCkeckLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Vignette valid until: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="VignetteLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Insurance valid until: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="InsuranceLabel" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-6 text-right">
                    <asp:Label runat="server" Text="Check car's owner: "></asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:HyperLink  ID="CheckCarOwnerLabel" runat="server" Text="OwnerInfoLink"></asp:HyperLink>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
