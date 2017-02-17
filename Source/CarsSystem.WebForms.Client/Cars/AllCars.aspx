<%@ Page Language="C#" AutoEventWireup="true" Title="All cars page" MasterPageFile="~/Site.Master" CodeBehind="AllCars.aspx.cs" Inherits="CarsSystem.WebForms.Client.Cars.AllCars" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>All cars page!</h1>
    <asp:GridView ID="AllCarsGridView" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Manufacturer" HeaderText="Manufacturer"/>
            <asp:BoundField DataField="Model" HeaderText="Model"/>
            <asp:HyperLinkField 
                    HeaderText="Registration number"
                    DataTextField="RegistrationNumber"
                    DataNavigateUrlFields="Id"
                    DataNavigateUrlFormatString="~/Cars/CarDetails.aspx?id={0}"/>
        </Columns>
    </asp:GridView>
</asp:Content>
