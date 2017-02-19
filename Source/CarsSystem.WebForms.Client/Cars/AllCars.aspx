<%@ Page Language="C#" AutoEventWireup="true" Title="All cars page" MasterPageFile="~/Site.Master" CodeBehind="AllCars.aspx.cs" Inherits="CarsSystem.WebForms.Client.Cars.AllCars" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <br />
        <div class="well col-md-4 col-md-offset-4">
            <h1 class="text-center">All cars page!</h1>
            <br />
            <asp:GridView ID="AllCarsGridView" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-hover text-center form-group">
                <Columns>
                    <asp:BoundField DataField="Manufacturer" HeaderText="Manufacturer" />
                    <asp:BoundField DataField="Model" HeaderText="Model" />
                    <asp:HyperLinkField
                        HeaderText="Registration number"
                        DataTextField="RegistrationNumber"
                        DataNavigateUrlFields="Id"
                        DataNavigateUrlFormatString="~/Cars/CarDetails.aspx?id={0}" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
