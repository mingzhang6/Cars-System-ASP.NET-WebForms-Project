using CarsSystem.Data.Models;
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

        }
    }
}