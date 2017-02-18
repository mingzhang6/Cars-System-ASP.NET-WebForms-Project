using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;

namespace CarsSystem.WebForms.Client.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        protected string SuccessMessage
        {
            get;
            private set;
        }

        private bool HasPassword(UserManager manager)
        {
            return manager.HasPassword(User.Identity.GetUserId());
        }

        protected void Page_Load()
        {
            var manager = Context.GetOwinContext().GetUserManager<UserManager>();
            var user = manager.FindById(User.Identity.GetUserId());
            this.UsernameLabel.Text = user.UserName;
            this.FirstNameLabel.Text = user.FirstName;
            this.SecondNameLabel.Text = user.SecondName;
            this.LastNameLabel.Text = user.LastName;
            this.CityLabel.Text = user.City;

            if (User.IsInRole("User"))
            {
                var car = user.Cars.ToList();
                this.CarTypeLabel.Text = car[0].TypeOfCar.ToString();
                this.ManufacturerLabel.Text = car[0].Manufacturer;
                this.ModelLabel.Text = car[0].Model;
                this.YearManufactoringLabel.Text = car[0].YearOfManufacturing.ToString("dd/MM/yyyy");
                this.AnnualCheckUpLabel.Text = car[0].YearOfManufacturing.ToString("dd/MM/yyyy");
                this.VignetteLabel.Text = car[0].ValidUntilVignette.ToString("dd/MM/yyyy");
                this.InsuranceLabel.Text = car[0].ValidUntilInsurance.ToString("dd/MM/yyyy");
                this.EngineTypeLabel.Text = car[0].TypeOfEngine.ToString();
            }

            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            if (!IsPostBack)
            {
                // Determine the sections to render
                if (HasPassword(manager))
                {
                    ChangePassword.Visible = true;
                }
                else
                {
                    CreatePassword.Visible = true;
                    ChangePassword.Visible = false;
                }

                // Render success message
                var message = Request.QueryString["m"];
                if (message != null)
                {
                    // Strip the query string from action
                    Form.Action = ResolveUrl("~/Account/Manage");

                    SuccessMessage =
                        message == "ChangePwdSuccess" ? "Your password has been changed."
                        : message == "SetPwdSuccess" ? "Your password has been set."
                        : message == "RemoveLoginSuccess" ? "The account was removed."
                        : message == "AddPhoneNumberSuccess" ? "Phone number has been added"
                        : message == "RemovePhoneNumberSuccess" ? "Phone number was removed"
                        : String.Empty;
                    successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
                }
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}