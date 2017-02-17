using CarsSystem.Data.Models;
using CarsSystem.Services.Data.Contracts;
using CarsSystem.WebForms.Client.Helpers;
using Common;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Ninject;
using System;
using System.Web;

namespace CarsSystem.WebForms.Client.Administration
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        [Inject]
        public ICarsService Service { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            this.TypeOfCarDropDownList.DataSource = Enum.GetNames(typeof(CarType));
            this.TypeOfCarDropDownList.DataBind();
            this.TypeOFEngineDropDownList.DataSource = Enum.GetNames(typeof(EngineType));
            this.TypeOFEngineDropDownList.DataBind();
        }

        protected void AddInfo_Click(object sender, EventArgs e)
        {
            string manufacturer = this.ManufacturerTextBox.Text;
            string model = this.ModelTextBox.Text;
            EngineType typeOfEngine = (EngineType)Enum.Parse(typeof(EngineType), this.TypeOFEngineDropDownList.Text);
            string registrationNumber = this.RegistrationTextBox.Text;
            string vinNumber = this.VINTextBox.Text;
            byte countOfTyres = byte.Parse(this.CountOfTyresTextBox.Text);
            byte countOfDoors = byte.Parse(this.CountOfDoorsTextBox.Text);
            CarType typeOfCar = (CarType)Enum.Parse(typeof(CarType), this.TypeOfCarDropDownList.Text);
            DateTime yearOfManufactoring = DateTime.Parse(this.ManufactoringYearTextBox.Text);
            DateTime validUntilAnnualCheckUp = DateTime.Parse(this.CheckUpTextBox.Text);
            DateTime validUntilVignette = DateTime.Parse(this.VignetteTextBox.Text);
            DateTime validUntilInsurance = DateTime.Parse(this.InsuranceTextBox.Text);

            string username = this.UsernameTextBox.Text;
            string firstName = this.FirstNameTextBox.Text;
            string secondName = this.SecondNameTextBox.Text;
            string lastName = this.LastNameTextBox.Text;
            long egn = long.Parse(this.EGNTextBox.Text);
            int numberOfIdCard = int.Parse(this.NumberOfIdCardTextBox.Text);
            DateTime dateOfIssue = DateTime.Parse(this.IssueTextBox.Text);
            string city = this.CityTextBox.Text;
            string phoneNumber = this.PhoneTextBox.Text;
            string email = this.EmailTextBox.Text;


            var manager = Context.GetOwinContext().GetUserManager<UserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();

            var userToAdd = new User()
            {
                UserName = username,
                FirstName = firstName,
                SecondName = secondName,
                LastName = lastName,
                EGN = egn,
                NumberOfIdCard = numberOfIdCard,
                DateOfIssue = dateOfIssue,
                City = city,
                PhoneNumber = phoneNumber,
                Email = email
            };

            IdentityResult result = manager.Create(userToAdd, "123456");

            var carToAdd = new Car()
            {
                Manufacturer = manufacturer,
                Model = model,
                TypeOfEngine = typeOfEngine,
                RegistrationNumber = registrationNumber,
                VINNumber = vinNumber,
                CountOfTyres = countOfTyres,
                CountOfDoors = countOfDoors,
                TypeOfCar = typeOfCar,
                YearOfManufacturing = yearOfManufactoring,
                ValidUntilAnnualCheckUp = validUntilAnnualCheckUp,
                ValidUntilVignette = validUntilVignette,
                ValidUntilInsurance = validUntilInsurance,
                UserId = userToAdd.Id
            };

            if (result.Succeeded)
            {
                manager.AddToRole(userToAdd.Id, ApplicationConstants.UserRole);
                Service.AddCar(carToAdd);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                // does not work
            }
        }
    }
}