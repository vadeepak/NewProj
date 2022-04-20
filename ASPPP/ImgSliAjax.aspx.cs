using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP
{
    public partial class ImgSliAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SetImageUrl();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            int i = (int)ViewState["ImageDisplayed"];
            i = i + 1;
            ViewState["ImageDisplayed"] = i;

            DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
            if (imageDataRow != null)
            {
                Image1.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
                lblImageName.Text = imageDataRow["name"].ToString();
                lblImageOrder.Text = imageDataRow["order"].ToString();
            }
            else
            {
                SetImageUrl();
            }
        }


        private void SetImageUrl()
        {
            DataSet ds = new DataSet();
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("spGetImageData", con);
            da.Fill(ds, "image");
            ViewState["ImageData"] = ds;
            ViewState["ImageDisplayed"] = 1;

            DataRow imageDataRow = ds.Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == "1");
            Image1.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
            lblImageName.Text = imageDataRow["name"].ToString();
            lblImageOrder.Text = imageDataRow["order"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Timer1.Enabled)
            {
                Timer1.Enabled = false;
                Button1.Text = "Start Slideshow";
            }
            else
            {
                Timer1.Enabled = true;
                Button1.Text = "Stop Slideshow";
            }
        }
        //private void SetImageUrl()
        //{
        //    if (ViewState["ImageDisplayed"] == null)
        //    {
        //        Image1.ImageUrl = "~/Images/1.jpg";
        //        ViewState["ImageDisplayed"] = 1;
        //        Label1.Text = "Displaying Image - 1";
        //    }
        //    else
        //    {
        //        int i = (int)ViewState["ImageDisplayed"];
        //        if (i == 8)
        //        {
        //            Image1.ImageUrl = "~/Images/1.jpg";
        //            ViewState["ImageDisplayed"] = 1;
        //            Label1.Text = "Displaying Image - 1";
        //        }
        //        else
        //        {
        //            i = i + 1;
        //            Image1.ImageUrl = "~/Images/" + i.ToString() + ".jpg";
        //            ViewState["ImageDisplayed"] = i;
        //            Label1.Text = "Displaying Image - " + i.ToString();
        //        }
        //    }
        //}

        //private void SetImageUrl()
        //{
        //    // Create an instance of Random class
        //    Random _rand = new Random();
        //    // Generate a random number between 1 and 8
        //    int i = _rand.Next(1, 8);
        //    // Set ImageUrl using the generated random number
        //    Image1.ImageUrl = "~/Images/" + i.ToString() + ".jpg";
        //}
    }
}