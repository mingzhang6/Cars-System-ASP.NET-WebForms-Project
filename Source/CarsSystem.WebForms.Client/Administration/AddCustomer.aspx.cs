using CarsSystem.Data;
using CarsSystem.Data.Models;
using CarsSystem.Data.Repositories;
using CarsSystem.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsSystem.WebForms.Client.Administration
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TypeOfCarDropDownList.DataSource = Enum.GetNames(typeof(CarType));
            this.TypeOfCarDropDownList.DataBind();
            this.TypeOFEngineDropDownList.DataSource = Enum.GetNames(typeof(EngineType));
            this.TypeOFEngineDropDownList.DataBind();
        }

        protected void AddInfo_Click(object sender, EventArgs e)
        {
            var data = new CarsSystemDbContext();
            var carRepo = new EfGenericRepository<Car>(data);
            CarsService service = new CarsService(carRepo);

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

        }
    }
}