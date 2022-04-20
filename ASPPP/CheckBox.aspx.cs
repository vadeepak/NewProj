using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class CheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //CheckBox2.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbUserChoices = new StringBuilder();
            if (CheckBox1.Checked)
            {
                sbUserChoices.Append(CheckBox1.Text);
            }
            if (CheckBox2.Checked)
            {
                sbUserChoices.Append(", " + CheckBox2.Text);
            }
            if (CheckBox3.Checked)
            {
                sbUserChoices.Append(", " + CheckBox3.Text);
            }
            Response.Write("Your Selections: " + sbUserChoices.ToString());
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Graduate Checkbox Selection changed");
        }
    }
}