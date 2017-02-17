<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="CarsSystem.WebForms.Client.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-offset-4">
            <h2><%: Title %>.</h2>

            <div>
                <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
                    <p class="text-success"><%: SuccessMessage %></p>
                </asp:PlaceHolder>
            </div>

            <div class="row">
                <div class="col-md-12">
                    <div class="form-horizontal">
                        <h4>Change your account settings</h4>
                        <dl class="dl-horizontal">
                            <dt>Username:</dt>
                            <dd>
                                <asp:Label ID="UsernameLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>First name:</dt>
                            <dd>
                                <asp:Label ID="FirstNameLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Second name:</dt>
                            <dd>
                                <asp:Label ID="SecondNameLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Last name:</dt>
                            <dd>
                                <asp:Label ID="LastNameLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>City:</dt>
                            <dd>
                                <asp:Label ID="CityLabel" runat="server"></asp:Label>
                            </dd>
                            <% if (System.Web.HttpContext.Current.User.IsInRole("User"))
                                {%>
                            <dt>Car's type:</dt>
                            <dd>
                                <asp:Label ID="CarTypeLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Car manufacturer:</dt>
                            <dd>
                                <asp:Label ID="ManufacturerLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Car model:</dt>
                            <dd>
                                <asp:Label ID="ModelLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Car's year of manufactoring:</dt>
                            <dd>
                                <asp:Label ID="YearManufactoringLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Annual check valid until:</dt>
                            <dd>
                                <asp:Label ID="AnnualCheckUpLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Vignette valid until:</dt>
                            <dd>
                                <asp:Label ID="VignetteLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Insurance valid until:</dt>
                            <dd>
                                <asp:Label ID="InsuranceLabel" runat="server"></asp:Label>
                            </dd>
                            <dt>Car's type of engine:</dt>
                            <dd>
                                <asp:Label ID="EngineTypeLabel" runat="server"></asp:Label>
                            </dd>
                            <% } %>
                            <dt>Change password:</dt>
                            <dd>
                                <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />
                                <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />
                            </dd>
                        </dl>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
