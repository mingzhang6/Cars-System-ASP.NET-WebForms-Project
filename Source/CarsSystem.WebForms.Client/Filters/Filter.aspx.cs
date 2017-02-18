using System;

namespace CarsSystem.WebForms.Client.Filters
{
    public partial class Filter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }
        }
    }
}