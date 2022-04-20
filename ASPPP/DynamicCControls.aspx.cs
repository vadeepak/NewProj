using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class DynamicCControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox TB = new TextBox();
            TB.ID = "TB1";
            PlaceHolder1.Controls.Add(TB);
            TB.Visible = false;

            DropDownList DDL = new DropDownList();
            DDL.ID = "DDL1";
            DDL.Items.Add("NewYork");
            DDL.Items.Add("New Jersey");
            DDL.Items.Add("Chennai");
            PlaceHolder1.Controls.Add(DDL);
            DDL.Visible = false;

            if(DropDownList1.SelectedValue == "TB")
            {
                TB.Visible = true;
            }
            else if (DropDownList1.SelectedValue == "DDL")
            {
                DDL.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "TB")
            {
              Response.Write(((TextBox)PlaceHolder1.FindControl("TB1")).Text);
            }
            else if (DropDownList1.SelectedValue == "DDL")
            {
                Response.Write(((DropDownList)PlaceHolder1.FindControl("DDL1")).SelectedItem.Text);
            }
        }
    }
}