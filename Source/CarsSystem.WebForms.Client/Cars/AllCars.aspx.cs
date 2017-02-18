using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace CarsSystem.WebForms.Client.Cars
{
    public partial class AllCars : System.Web.UI.Page
    {
        [Inject]
        public ICarsService Service { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            this.AllCarsGridView.DataSource = Service.GetAllCars().ToList();
            this.AllCarsGridView.DataBind();
        }
    }
}