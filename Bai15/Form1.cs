namespace Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // --- Cấu hình ban đầu cho Ex1 ---
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Black");
            dudColor.Items.Add("Orange");
            dudColor.Items.Add("Purple");
            dudColor.SelectedIndex = 0; // Default: Green

            nudSize.Value = 16;
            lblSampleText.ForeColor = Color.Green;
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, 16f);

            // --- Cấu hình ban đầu cho Ex2 ---
            lblStartDate.Text = "StartDate:\n" + monthCalendar1.SelectionStart.ToShortDateString();
            lblEndDate.Text = "EndDate:\n" + monthCalendar1.SelectionEnd.ToShortDateString();
            radLongDate.Checked = true;

            // --- Cấu hình ban đầu cho Ex3 ---
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 45;
            lblPercentage.Text = "Percentage Complete: 45%";
            trackBar1.Value = 5;
            timer1.Interval = (11 - trackBar1.Value) * 50;
            timer1.Start();

            // --- Cấu hình ban đầu cho Ex4 ---
            radOK.Checked = true;
            radInformation.Checked = true;
            radLayoutTop.Checked = true;
        }

        // ==========================================
        // Ex1: DomainUpDown and NumericUpDown
        // ==========================================
        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            // Typecast the object to DomainUpDown
            DomainUpDown dudColor = (DomainUpDown)sender;
            // Change color of lblSampleText to selected color
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            // Typecast the object to NumericUpDown
            NumericUpDown nudSize = (NumericUpDown)sender;
            // Change the font of lblSampleText to selected font
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }

        // ==========================================
        // Ex2: MonthCalendar and DateTimePicker
        // ==========================================
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStartDate.Text = "StartDate:\n" + monthCalendar1.SelectionStart.ToShortDateString();
            lblEndDate.Text = "EndDate:\n" + monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void radLongDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radLongDate.Checked)
                dtpProductLaunch.Format = DateTimePickerFormat.Long;
        }

        private void radShortDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radShortDate.Checked)
                dtpProductLaunch.Format = DateTimePickerFormat.Short;
        }

        // ==========================================
        // Ex3: Timer, TrackBar, and ProgressBar
        // ==========================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            else
            {
                progressBar1.Value = 0;
            }
            lblPercentage.Text = $"Percentage Complete: {progressBar1.Value}%";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Slide the TrackBar to control processing speed
            int speed = trackBar1.Value;
            timer1.Interval = Math.Max(10, (11 - speed) * 50);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnStartStop.Text = "Start Progress";
            }
            else
            {
                timer1.Start();
                btnStartStop.Text = "Pause Progress";
            }
        }

        // ==========================================
        // Ex4: TabControl & MessageBox Generator
        // ==========================================
        private void btnShow_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string caption = txtCaption.Text;

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (radOKCancel.Checked) buttons = MessageBoxButtons.OKCancel;
            else if (radRetryCancel.Checked) buttons = MessageBoxButtons.RetryCancel;
            else if (radYesNo.Checked) buttons = MessageBoxButtons.YesNo;
            else if (radYesNoCancel.Checked) buttons = MessageBoxButtons.YesNoCancel;

            MessageBoxIcon icon = MessageBoxIcon.None;
            if (radError.Checked) icon = MessageBoxIcon.Error;
            else if (radInformation.Checked) icon = MessageBoxIcon.Information;
            else if (radQuestion.Checked) icon = MessageBoxIcon.Question;
            else if (radWarning.Checked) icon = MessageBoxIcon.Warning;

            MessageBox.Show(message, caption, buttons, icon);
        }

        private void radLayout_CheckedChanged(object sender, EventArgs e)
        {
            if (radLayoutLeft.Checked) tabControlEx4.Alignment = TabAlignment.Left;
            else if (radLayoutRight.Checked) tabControlEx4.Alignment = TabAlignment.Right;
            else if (radLayoutTop.Checked) tabControlEx4.Alignment = TabAlignment.Top;
            else if (radLayoutBottom.Checked) tabControlEx4.Alignment = TabAlignment.Bottom;
        }
    }
}
