using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class UserControlDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CalendarUserControl1.CalendarVisibilityChanged += new UserControls.CalendarVisibilityChangedEventHandler(CalendarUserControl1_CalendarVisibilityChanged);
           
        }

        protected void CalendarUserControl1_CalendarVisibilityChanged(object sender, UserControls.CalendarVisibilityChangedEventArgs e)
        {
            Response.Write("Calendar Visible =" + e.IsCalendarVisible.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(CalendarUserControl1.SelectedDate);
        }
    }
}