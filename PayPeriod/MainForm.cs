/**
 * Author: Jared Potter
 * 
 * PayPeriod calculator
 * 
 * This purpose of this project was to allow me to calculate 
 * the number of hours I'd obtain during a pay-period at my 
 * job. Because I do not work an even number of hours for each
 * day of the week, I needed a way to quickly calculate the number
 * of hours I worked during a pay period to accurately estimate 
 * my paychecks for budgeting reasons. 
 * 
 * 
 * There are a handful of expansions I plan to make to this project. Here are a few
 *  TODO:
 *  expansions: 
 *      -add a pay-period range
 *      -load directly into excel spreadsheed
 *      -nicer interface w/ user instructions
 *      -holidays - if regular hours during holiday is greater than holiday paid-hours (6 or 8), then subtract, else if regular hours during holi-
 *      day is less than holiday paid-hours (6 or 8), the add differance
 *      -add optional hour field
 *      -add optional tax % field
 *      -add saturday and sunday options
 *      - handle more special (error) cases
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace PayPeriod
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        // variables to hold the start and end date
        private DateTime startDate = DateTime.Today;
        private DateTime endDate   = DateTime.Today;

        // setting up hour count variables
        private double monHours = 0.0;
        private double tueHours = 0.0;
        private double wedHours = 0.0;
        private double thuHours = 0.0;
        private double friHours = 0.0;

        // list to maintain each row in the pay-period table
        private List<ListViewItem> theList = new List<ListViewItem>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // by default, load zeros into hour fields
            MondayHourBox.Text      = "0";
            TuesdayHourBox.Text     = "0";
            WednesdayHourBox.Text   = "0";
            ThursdayHourBox.Text    = "0";
            FridayHourBox.Text      = "0";

            // table setup methods
            OutputTable.View = View.Details;
            OutputTable.GridLines = true;
            OutputTable.FullRowSelect = true;

            // settings column labels
            OutputTable.Columns.Add("Date Range", 115, HorizontalAlignment.Center);
            OutputTable.Columns.Add("Hours", 75, HorizontalAlignment.Center);

            // adds control
            this.Controls.Add(OutputTable);
        }

        //private void button1_Click(object sender, EventArgs e)
        private void GoButton_Click(object sender, EventArgs e)
        {

            // special cases 

            // same day
            if (startDate.Equals(endDate))
            {
                MessageBox.Show("Start and End date are the same. Please select different dates.", "PayPeriod", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //startDate is after than endDate
            if (startDate.CompareTo(endDate) > 0)
            {
                MessageBox.Show("The end date is before the start date. Please select a start date that is before the end date.", "PayPeriod", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // prepares the output table and listview by clearing it
            OutputTable.Clear();
            theList.Clear();
            OutputTable.Items.Clear();

            // settings column labels - required to display correctly
            OutputTable.Columns.Add("Date Range", 100, HorizontalAlignment.Center);
            OutputTable.Columns.Add("Hours", 2, HorizontalAlignment.Center);

            this.Controls.Add(OutputTable);

            // grab hour values
            monHours = Convert.ToDouble(MondayHourBox.Text);
            tueHours = Convert.ToDouble(TuesdayHourBox.Text);
            wedHours = Convert.ToDouble(WednesdayHourBox.Text);
            thuHours = Convert.ToDouble(ThursdayHourBox.Text);
            friHours = Convert.ToDouble(FridayHourBox.Text);

            // set current date as start date
            DateTime currentDate = startDate;

            // set hour sum to zero
            double hourSum = 0;

            // loop until the current date is 1 day past the end date
            while (!currentDate.Equals(endDate.AddDays(1)))
            {
                // if the current date is 1-15th of the month
                if (currentDate.Day < 16)
                {
                    // loop until the 16th, summing hours
                    while (currentDate.Day < 16)
                    {
                        if (currentDate.Equals(endDate.AddDays(1)))
                            break;

                        // string version of day of week. E.G. "Monday"
                        string s = currentDate.DayOfWeek.ToString();

                        // fetch the hours worked for that day
                        hourSum += PayPeriodSum(s);

                        // increment day
                        currentDate = currentDate.AddDays(1);
                    }

                    // add -1 days in order to get previous date for display purposes
                    currentDate = currentDate.AddDays(-1);

                    // add hour and date range to item list
                    string dateRangeTemp = "";

                    // grabs the 3 letter version of the month to add to table
                    string monthName3Letter = currentDate.ToString("MMM", CultureInfo.InvariantCulture);
                    dateRangeTemp = dateRangeTemp + monthName3Letter + " 1 - " + monthName3Letter + " " + currentDate.Day.ToString();
                    ListViewItem item1 = new ListViewItem(dateRangeTemp, 0);

                    // adding the hours
                    item1.SubItems.Add(hourSum.ToString());
                    // adding item to list
                    theList.Add(item1);

                    // re-adjusting back to regular date
                    currentDate = currentDate.AddDays(1);

                    // zero out hourSum
                    hourSum = 0;
                }

                // if the current date is 16-end of month
                else if (currentDate.Day > 15)
                {
                    while (currentDate.Day != 1) // infin loop going on here
                    {
                        if (currentDate.Equals(endDate))
                            break;


                        // string version of day of week. E.G. "Monday"
                        string s = currentDate.DayOfWeek.ToString();

                        // fetch the hours worked for that day
                        hourSum += PayPeriodSum(s);

                        // increment day
                        currentDate = currentDate.AddDays(1);
                    }

                    // add -1 days in order to get previous date for display purposes
                    currentDate = currentDate.AddDays(-1);

                    // add hour and date range to item list
                    string dateRangeTemp = "";

                    // grabs the 3 letter version of the month to add to table
                    string monthName3Letter = currentDate.ToString("MMM", CultureInfo.InvariantCulture);
                    dateRangeTemp = dateRangeTemp + monthName3Letter + " 16 - " + monthName3Letter + " " + currentDate.Day.ToString();
                    ListViewItem item1 = new ListViewItem(dateRangeTemp, 0);

                    // adding the hours
                    item1.SubItems.Add(hourSum.ToString());
                    // adding item to list
                    theList.Add(item1);

                    // re-adjusting back to regular date
                    currentDate = currentDate.AddDays(1);

                    // zero out hourSum
                    hourSum = 0;
                }

                if (currentDate.Equals(endDate))
                    break;
            }

            // add everything to the listView
            OutputTable.Items.AddRange(theList.ToArray());


            // settings column labels
            //OutputTable.Columns.Add("Date Range", 115, HorizontalAlignment.Center);
            //OutputTable.Columns.Add("Hours", 75, HorizontalAlignment.Center);

            OutputTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            OutputTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        /// <summary>
        /// <param name="s"> String s is the day of the week. Ex: Monday, Tuesday, etc</param>
        /// This method takes in a weekday in String form with a capital first letter. 
        /// It then processes through a switch case to sum the correct value, which it 
        /// then returns.
        /// </summary>
        private double PayPeriodSum(String s)
        {
            double hourSum = 0;

            switch (s)
            {
                case "Monday":
                    hourSum = monHours;
                    break;
                case "Tuesday":
                    hourSum = tueHours;
                    break;
                case "Wednesday":
                    hourSum = wedHours;
                    break;
                case "Thursday":
                    hourSum = thuHours;
                    break;
                case "Friday":
                    hourSum = friHours;
                    break;
            }

            return hourSum;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            startDate = e.Start;
            StartDateLabel.Text = "Start Date: " + startDate.ToShortDateString();
        }

        private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            startDate = e.Start;
            StartDateLabel.Text = "Start Date: " + startDate.ToShortDateString();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            endDate = e.Start;
            EndDateLabel.Text = "End Date: " + endDate.ToShortDateString();
        }

        private void monthCalendar2_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            endDate = e.Start;
            EndDateLabel.Text = "End Date: " + endDate.ToShortDateString();
        }
    }
}
