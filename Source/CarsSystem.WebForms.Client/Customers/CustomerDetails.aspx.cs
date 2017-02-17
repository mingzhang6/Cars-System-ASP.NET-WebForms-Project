using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            var carId = CarsService.GetCarId(user);

            this.FirstnameLabel.Text = user.FirstName;
            this.SecondNameLabel.Text = user.SecondName;
            this.LastNameLabel.Text = user.LastName;
            this.EGNLabel.Text = user.EGN.ToString();
            this.NumberOfIdCardLabel.Text = user.NumberOfIdCard.ToString();
            this.DateOfIssueLabel.Text = user.DateOfIssue.ToString();
            this.CityLabel.Text = user.City;
            this.PhoneNumberLabel.Text = user.PhoneNumber;
            this.EmailLabel.Text = user.Email;
            this.CheckCustomerCarLabel.NavigateUrl = "~/Cars/CarDetails.aspx?id=" + carId;
        }
    }
}