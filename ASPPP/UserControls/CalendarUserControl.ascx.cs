using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPP.UserControls
{
    public partial class CalendarUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        protected void ImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
                CalendarVisibilityChangedEventArgs eventdata = new CalendarVisibilityChangedEventArgs(false);
                OnCalendarVisibilityChanged(eventdata);
            }
            else
            {
                Calendar1.Visible = true;
                CalendarVisibilityChangedEventArgs eventdata = new CalendarVisibilityChangedEventArgs(true);
                OnCalendarVisibilityChanged(eventdata);
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
            CalendarVisibilityChangedEventArgs eventdata = new CalendarVisibilityChangedEventArgs(false);
            OnCalendarVisibilityChanged(eventdata);
        }

        public string SelectedDate
        {
            get
            {
                return txtDate.Text;
            }
            set
            {
                txtDate.Text = value;
            }
        }

        public event CalendarVisibilityChangedEventHandler CalendarVisibilityChanged;

        protected virtual void OnCalendarVisibilityChanged(CalendarVisibilityChangedEventArgs e)
        {
            if (CalendarVisibilityChanged != null)
            {
                CalendarVisibilityChanged(this, e);
            }
        }

    }

    public class CalendarVisibilityChangedEventArgs : EventArgs
    {
        private bool _isCalendarVisible;

        // Constructor to initialize event data
        public CalendarVisibilityChangedEventArgs(bool isCalendarVisible)
        {
            this._isCalendarVisible = isCalendarVisible;
        }

        // Returns true if the calendar is visible otherwise false
        public bool IsCalendarVisible
        {
            get
            {
                return this._isCalendarVisible;
            }
        }
    }

    public delegate void CalendarVisibilityChangedEventHandler(object sender, CalendarVisibilityChangedEventArgs e);

 
}