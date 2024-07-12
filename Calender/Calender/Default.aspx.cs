using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calender
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ShowCalendarButton_Click(object sender, EventArgs e)
        {
            CalendarControl.Visible = true;
        }

        protected void CalendarControl_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = CalendarControl.SelectedDate;
            if (selectedDate >= new DateTime(2024, 7, 29) && selectedDate <= new DateTime(2024, 8, 3))
            {
                SelectedDateTextBox.Text = "Sessional Week";
            }
            else
            {
                SelectedDateTextBox.Text = selectedDate.ToShortDateString();
            }
        }

        protected void CalendarControl_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth)
            {
                e.Cell.CssClass = "other-month";
            }
            else if (e.Day.IsWeekend)
            {
                e.Cell.CssClass = "weekend";
            }

            if (e.Day.Date.Month == DateTime.Now.Month && e.Day.Date.Day == 5)
            {
                e.Cell.Text = "It's Birthday";
            }
        }
    }
}
