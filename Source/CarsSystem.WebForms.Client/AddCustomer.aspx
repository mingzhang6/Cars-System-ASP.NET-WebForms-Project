<%@ Page Language="C#" AutoEventWireup="true" Title="Add customer and car page" MasterPageFile="~/Site.Master" CodeBehind="AddCustomer.aspx.cs" Inherits="CarsSystem.WebForms.Client.Administration.AddCustomer" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <div class="row">
        <h1 class="text-center">Adding customer and car page!</h1>
        <div class="well col-md-8 col-md-offset-2">
            <h3 class="text-center">Fill all text boxes for customer information.</h3>
            <br />
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="UsernameLabel" runat="server" Text="Username: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="UsernameTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="UsernameTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="FirstNameLabel" runat="server" Text="First name: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="FirstNameTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="FirstNameTextBox"
                        Text="The field is required and lenght between 2 and 20 symbols!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="SecondNameLabel" runat="server" Text="Second name: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="SecondNameTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="SecondNameTextBox" Text="The field is required and lenght between 2 and 20 symbols!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="LastNameLabel" runat="server" Text="Last name: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="LastNameTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="LastNameTextBox" Text="The field is required and lenght between 2 and 20 symbols!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="EGNLabel1" runat="server" Text="EGN: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="EGNTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="EGNTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="NumberOfIdCardLabel" runat="server" Text="Number of Id card: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="NumberOfIdCardTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="NumberOfIdCardTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="IssueLabel" runat="server" Text="Date of issue: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="IssueTextBox" runat="server" CssClass="firstDatepicker form-control my-width"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="IssueTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="CityLabel" runat="server" Text="City: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="CityTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="CityTextBox" Text="The field is required and lenght between 0 and 20 symbols!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="PhoneLabel" runat="server" Text="Phone number: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="PhoneTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="PhoneTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="EmailLabel" runat="server" Text="E-mail: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="EmailTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="EmailTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="well col-md-8 col-md-offset-2">
            <h3 class="text-center">Fill all text boxes for car information.</h3>
            <br />
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="ManufacturerLabel" runat="server" Text="Manufacturer: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="ManufacturerTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ControlToValidate="ManufacturerTextBox" Text="The field is required and lenght between 2 and 20 symbols!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="ModelLabel" runat="server" Text="Model: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="ModelTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" ControlToValidate="ModelTextBox" Text="The field is required and lenght between 2 and 20 symbols!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="TypeOFEngineLabel" runat="server" Text="Type Of Engine: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:DropDownList CssClass="form-control my-width" ID="TypeOFEngineDropDownList" runat="server">
                    </asp:DropDownList>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" ControlToValidate="TypeOFEngineDropDownList" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="RegistrationLabel" runat="server" Text="Registration Number: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="RegistrationTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" ControlToValidate="RegistrationTextBox" Text="The field is required and lenght between 4 and 10 symbols!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="VINLabel" runat="server" Text="Vin Number: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="VINTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" ControlToValidate="VINTextBox" Text="The field is required and lenght exactly 17 symbols!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="CountOfTyresLabel" runat="server" Text="Count of tyres: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="CountOfTyresTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" ControlToValidate="CountOfTyresTextBox" Text="The field is required and range between 2 and 10!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="CountOfDoorsLabel" runat="server" Text="Count of doors: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control my-width" ID="CountOfDoorsTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" ControlToValidate="CountOfDoorsTextBox" Text="The field is required and range between 2 and 6!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="TypeOfCarLabel" runat="server" Text="Type Of Car: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:DropDownList CssClass="form-control my-width" ID="TypeOfCarDropDownList" runat="server">
                    </asp:DropDownList>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" ControlToValidate="TypeOfCarDropDownList" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="ManufactoringYearLabel" runat="server" Text="Year of manufactoring: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="ManufactoringYearTextBox" runat="server" CssClass="secondDatepicker form-control my-width"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator19" ControlToValidate="ManufactoringYearTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="CheckUpLabel" runat="server" Text="Valid until annual check up: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="CheckUpTextBox" runat="server" CssClass="thirdDatepicker form-control my-width"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" ControlToValidate="CheckUpTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="VignetteLabel" runat="server" Text="Valid until vignette: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="VignetteTextBox" runat="server" CssClass="fourthDatepicker form-control my-width"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" ControlToValidate="VignetteTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-md-3 text-right">
                    <asp:Label ID="InsuranceLabel" runat="server" Text="Valid until insurance: "></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="InsuranceTextBox" runat="server" CssClass="fifthDatepicker form-control my-width"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" ControlToValidate="InsuranceTextBox" Text="The field is required!" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="text-center">
            <div class="col-md-3"></div>
            <div class="col-md-4">
                <asp:Button CssClass="form-control" ID="AddInfo" runat="server" Text="Add information for the new Customer and his car!" OnClick="AddInfo_Click" Width="500px" />
            </div>
        </div>
    </div>
    <script src="http://code.jquery.com/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="http://code.jquery.com/ui/1.10.4/jquery-ui.js" type="text/javascript"></script>
    <script type="text/javascript" src="Scripts/datepicker.js"></script>
</asp:Content>
