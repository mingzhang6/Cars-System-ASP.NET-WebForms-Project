using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;

namespace CarsSystem.WebForms.Client.Cars
{
    public partial class CarDetails : System.Web.UI.Page
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

            var id = int.Parse(this.Request.QueryString["id"]);
            var car = CarsService.GetCarById(id);
            var userId = UsersService.GetUserId(car);

            this.ManufacturerLabel.Text = car.Manufacturer;
            this.ModelLabel.Text = car.Model;
            this.TypeOfEngineLabel.Text = car.TypeOfEngine.ToString();
            this.RegistrationNumberLabel.Text = car.RegistrationNumber;
            this.VINLabel.Text = car.VINNumber;
            this.CountOfTyresLabel.Text = car.CountOfTyres.ToString();
            this.CountOfDoorsLabel.Text = car.CountOfDoors.ToString();
            this.TypeOfCarLabel.Text = car.TypeOfCar.ToString();
            this.YearOfManufactoringLabel.Text = car.YearOfManufacturing.ToString("dd.MM.yyyy");
            this.AnnualCkeckLabel.Text = car.ValidUntilAnnualCheckUp.ToString("dd.MM.yyyy");
            this.VignetteLabel.Text = car.ValidUntilVignette.ToString("dd.MM.yyyy");
            this.InsuranceLabel.Text = car.ValidUntilInsurance.ToString("dd.MM.yyyy");
            this.CheckCarOwnerLabel.NavigateUrl = "~/Customers/CustomerDetails.aspx?id=" + userId;
        }
    }
}