using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Web.UI;

namespace CarsSystem.WebForms.Client.Customers
{
    public partial class CustomerDetails : System.Web.UI.Page
    {
        [Inject]
        public IUsersService UsersService { get; set; }

        [Inject]
        public ICarsService CarsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            var id = this.Request.QueryString["id"];
            var user = UsersService.GetUserById(id);

            this.FirstnameLabel.Text = user.FirstName;
            this.SecondNameLabel.Text = user.SecondName;
            this.LastNameLabel.Text = user.LastName;
            this.EGNLabel.Text = user.EGN.ToString();
            this.NumberOfIdCardLabel.Text = user.NumberOfIdCard.ToString();
            this.DateOfIssueLabel.Text = user.DateOfIssue.ToString("dd.MM.yyyy");
            this.CityLabel.Text = user.City;
            this.PhoneNumberLabel.Text = user.PhoneNumber;
            this.EmailLabel.Text = user.Email;

            try
            {
                var carId = CarsService.GetCarId(user);
                this.CheckCustomerCarLabel.NavigateUrl = "~/Cars/CarDetails.aspx?id=" + carId;
            }
            catch(Exception ex)
            {
                this.CheckCustomerCarLabel.Text = "None";
                this.CheckCustomerCarLabel.Style[HtmlTextWriterStyle.TextDecoration] = "none";
                this.CheckCustomerCarLabel.Style[HtmlTextWriterStyle.Color] = "red";
            }
        }
    }
}