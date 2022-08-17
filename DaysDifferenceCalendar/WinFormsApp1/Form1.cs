namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DateTime startDateDT;
        DateTime endDateDT;        
        DateTime holdStart;
        DateTime holdEnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void daysResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            startDate.Clear();
            endDate.Clear();
            startDate.Enabled = true;
            endDate.Enabled = true;
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (startDate.Text != null)
            {
                startDate.Text = holdStart.ToString();
                startDate.Enabled = false;
                startDate.Visible = true;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(startDate.Text, out startDateDT);
            DateTime.TryParse(endDate.Text, out endDateDT); 
            daysResult.Text = (endDateDT - startDateDT).TotalDays.ToString();
        }

        private void startDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            holdStart = e.End;
            holdEnd = e.End;

        }

        private void selectEnd_Click(object sender, EventArgs e)
        {
            if (startDate.Text != null)
            {
                endDate.Text = holdEnd.ToString();
                endDate.Enabled = false;
                endDate.Visible = true;
            }
        }
    }
}