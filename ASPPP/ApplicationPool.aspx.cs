using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class ApplicationPool : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Application1_Data"] = "Application 1 Data";
            }
            Response.Write("Identity used = " + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Application1_Data"] != null)
            {
                Response.Write("Application1_Data = " + Session["Application1_Data"]);
            }
            else
            {
                Response.Write("Session Data not available");
            }
        }
    }
}