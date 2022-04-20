using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class RdaioButt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Response.Write("Your selection is:" + RadioButton1.Text);
            }
            Response.Write("Your selection is:" + RadioButton2.Text);

        }
    }
}