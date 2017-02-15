<%@ Page Language="C#" AutoEventWireup="true" Title="Add customer and car page" MasterPageFile="~/Site.Master" CodeBehind="AddCustomer.aspx.cs" Inherits="CarsSystem.WebForms.Client.Administration.AddCustomer" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Adding customer and car page!</h1>
    <script src="http://code.jquery.com/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="http://code.jquery.com/ui/1.10.4/jquery-ui.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".datepicker").datepicker();

        });
    </script>
    <div>
        <div class="well" style="width: 500px">
            <h3>Fill all text boxes for customer information.</h3>
            <div>
                <asp:Label ID="UsernameLabel" runat="server" Text="Username: "></asp:Label>
                <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="FirstNameLabel" runat="server" Text="First name: "></asp:Label>
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="SecondNameLabel" runat="server" Text="Second name: "></asp:Label>
                <asp:TextBox ID="SecondNameTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="LastNameLabel" runat="server" Text="Last name: "></asp:Label>
                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="EGNLabel1" runat="server" Text="EGN: "></asp:Label>
                <asp:TextBox ID="EGNTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="NumberOfIdCardLabel" runat="server" Text="Number of Id card: "></asp:Label>
                <asp:TextBox ID="NumberOfIdCardTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="IssueLabel" runat="server" Text="Date of issue: "></asp:Label>
                <asp:TextBox ID="IssueTextBox" runat="server" CssClass="datepicker"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="CityLabel" runat="server" Text="City: "></asp:Label>
                <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="PhoneLabel" runat="server" Text="Phone number: "></asp:Label>
                <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="EmailLabel" runat="server" Text="E-mail: "></asp:Label>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="well" style="width: 500px">
            <h3>Fill all text boxes for car information.</h3>
            <div>
                <asp:Label ID="ManufacturerLabel" runat="server" Text="Manufacturer: "></asp:Label>
                <asp:TextBox ID="ManufacturerTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="ModelLabel" runat="server" Text="Model: "></asp:Label>
                <asp:TextBox ID="ModelTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="TypeOFEngineLabel" runat="server" Text="Type Of Engine: "></asp:Label>
                <asp:DropDownList ID="TypeOFEngineDropDownList" runat="server">
                </asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="RegistrationLabel" runat="server" Text="Registration Number: "></asp:Label>
                <asp:TextBox ID="RegistrationTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="VINLabel" runat="server" Text="Vin Number: "></asp:Label>
                <asp:TextBox ID="VINTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="CountOfTyresLabel" runat="server" Text="Count of tyres: "></asp:Label>
                <asp:TextBox ID="CountOfTyresTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="CountOfDoorsLabel" runat="server" Text="Count of doors: "></asp:Label>
                <asp:TextBox ID="CountOfDoorsTextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="TypeOfCarLabel" runat="server" Text="Type Of Car: "></asp:Label>
                <asp:DropDownList ID="TypeOfCarDropDownList" runat="server">
                </asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="ManufactoringYearLabel" runat="server" Text="Year of manufactoring: "></asp:Label>
                <asp:TextBox ID="ManufactoringYearTextBox" runat="server" CssClass="datepicker"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="CheckUpLabel" runat="server" Text="Valid until annual check up: "></asp:Label>
                <asp:TextBox ID="CheckUpTextBox" runat="server" CssClass="datepicker"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="VignetteLabel" runat="server" Text="Valid until vignette: "></asp:Label>
                <asp:TextBox ID="VignetteTextBox" runat="server" CssClass="datepicker"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="InsuranceLabel" runat="server" Text="Valid until insurance: "></asp:Label>
                <asp:TextBox ID="InsuranceTextBox" runat="server" CssClass="datepicker"></asp:TextBox>
            </div>
        </div>

        <asp:Button ID="AddInfo" runat="server" Text="Add information for the new Customer and his car!" OnClick="AddInfo_Click" Width="500px" />
    </div>
</asp:Content>
