using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace CarsSystem.WebForms.Client.Customers
{
    public partial class AllCustomers : System.Web.UI.Page
    {
        [Inject]
        public IUsersService Service { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            this.AllCustomersGridView.DataSource = Service.GetAllUsers().ToList();
            this.AllCustomersGridView.DataBind();
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            var egn = long.Parse(this.SearchTextBox.Text);
            this.AllCustomersGridView.DataSource = Service.GetUserByEGN(egn).ToList();
            this.AllCustomersGridView.DataBind();
        }
    }
}