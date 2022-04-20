using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class DynamicalUserControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserControls.CalendarUserControl calusctl = (UserControls.CalendarUserControl)LoadControl("~/UserControls/CalendarUserControl.ascx");
            calusctl.ID = "CU1";
            PlaceHolder1.Controls.Add(calusctl);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(((UserControls.CalendarUserControl)PlaceHolder1.FindControl("CU1")).SelectedDate);
        }
    }
}