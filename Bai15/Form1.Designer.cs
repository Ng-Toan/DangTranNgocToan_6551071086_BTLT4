namespace Bai15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainTabControl = new TabControl();
            tabEx1 = new TabPage();
            lblSampleText = new Label();
            nudSize = new NumericUpDown();
            dudColor = new DomainUpDown();
            lblSize = new Label();
            lblColor = new Label();
            tabEx2 = new TabPage();
            radShortDate = new RadioButton();
            radLongDate = new RadioButton();
            dtpProductLaunch = new DateTimePicker();
            lblProductLaunch = new Label();
            lblEndDate = new Label();
            lblStartDate = new Label();
            monthCalendar1 = new MonthCalendar();
            lblTravelPrompt = new Label();
            tabEx3 = new TabPage();
            btnStartStop = new Button();
            trackBar1 = new TrackBar();
            lblSlideTrackBar = new Label();
            lblPercentage = new Label();
            progressBar1 = new ProgressBar();
            lblProgressIndicator = new Label();
            tabEx4 = new TabPage();
            grpTabLayout = new GroupBox();
            radLayoutBottom = new RadioButton();
            radLayoutRight = new RadioButton();
            radLayoutTop = new RadioButton();
            radLayoutLeft = new RadioButton();
            btnShow = new Button();
            tabControlEx4 = new TabControl();
            tabMessage = new TabPage();
            grpMessageOptions = new GroupBox();
            txtCaption = new TextBox();
            lblCapPrompt = new Label();
            txtMessage = new TextBox();
            lblMsgPrompt = new Label();
            tabButtons = new TabPage();
            grpButtonsOptions = new GroupBox();
            radYesNoCancel = new RadioButton();
            radYesNo = new RadioButton();
            radRetryCancel = new RadioButton();
            radOKCancel = new RadioButton();
            radOK = new RadioButton();
            tabIcon = new TabPage();
            grpIconOptions = new GroupBox();
            radWarning = new RadioButton();
            radQuestion = new RadioButton();
            radNone = new RadioButton();
            radInformation = new RadioButton();
            radError = new RadioButton();
            lblMessageBoxOptions = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            mainTabControl.SuspendLayout();
            tabEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            tabEx2.SuspendLayout();
            tabEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabEx4.SuspendLayout();
            grpTabLayout.SuspendLayout();
            tabControlEx4.SuspendLayout();
            tabMessage.SuspendLayout();
            grpMessageOptions.SuspendLayout();
            tabButtons.SuspendLayout();
            grpButtonsOptions.SuspendLayout();
            tabIcon.SuspendLayout();
            grpIconOptions.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 

            mainTabControl.Controls.Add(tabEx1);
            mainTabControl.Controls.Add(tabEx2);
            mainTabControl.Controls.Add(tabEx3);
            mainTabControl.Controls.Add(tabEx4);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(500, 480);
            mainTabControl.TabIndex = 0;
            // 
            // tabEx1
            // 
            tabEx1.Controls.Add(lblSampleText);
            tabEx1.Controls.Add(nudSize);
            tabEx1.Controls.Add(dudColor);
            tabEx1.Controls.Add(lblSize);
            tabEx1.Controls.Add(lblColor);
            tabEx1.Location = new Point(4, 26);
            tabEx1.Name = "tabEx1";
            tabEx1.Padding = new Padding(3);
            tabEx1.Size = new Size(492, 450);
            tabEx1.TabIndex = 0;
            tabEx1.Text = "Ex1: DomainUpDown & NumericUpDown";
            tabEx1.UseVisualStyleBackColor = true;
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSampleText.ForeColor = Color.Green;
            lblSampleText.Location = new Point(140, 220);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(139, 30);
            lblSampleText.TabIndex = 4;
            lblSampleText.Text = "Sample Text";
            // 
            // nudSize
            // 
            nudSize.Font = new Font("Segoe UI", 9.5F);
            nudSize.Location = new Point(160, 108);
            nudSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(180, 24);
            nudSize.TabIndex = 3;
            nudSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // dudColor
            // 
            dudColor.Font = new Font("Segoe UI", 9.5F);
            dudColor.Location = new Point(160, 48);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(180, 24);
            dudColor.TabIndex = 2;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 10F);
            lblSize.Location = new Point(80, 110);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(35, 19);
            lblSize.TabIndex = 1;
            lblSize.Text = "Size:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 10F);
            lblColor.Location = new Point(80, 50);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(45, 19);
            lblColor.TabIndex = 0;
            lblColor.Text = "Color:";
            // 
            // tabEx2
            // 
            tabEx2.Controls.Add(radShortDate);
            tabEx2.Controls.Add(radLongDate);
            tabEx2.Controls.Add(dtpProductLaunch);
            tabEx2.Controls.Add(lblProductLaunch);
            tabEx2.Controls.Add(lblEndDate);
            tabEx2.Controls.Add(lblStartDate);
            tabEx2.Controls.Add(monthCalendar1);
            tabEx2.Controls.Add(lblTravelPrompt);
            tabEx2.Location = new Point(4, 26);
            tabEx2.Name = "tabEx2";
            tabEx2.Padding = new Padding(3);
            tabEx2.Size = new Size(492, 450);
            tabEx2.TabIndex = 1;
            tabEx2.Text = "Ex2: MonthCalendar & DateTimePicker";
            tabEx2.UseVisualStyleBackColor = true;
            // 
            // radShortDate
            // 
            radShortDate.AutoSize = true;
            radShortDate.Font = new Font("Segoe UI", 9.5F);
            radShortDate.Location = new Point(160, 310);
            radShortDate.Name = "radShortDate";
            radShortDate.Size = new Size(88, 21);
            radShortDate.TabIndex = 7;
            radShortDate.Text = "Short Date";
            radShortDate.UseVisualStyleBackColor = true;
            radShortDate.CheckedChanged += radShortDate_CheckedChanged;
            // 
            // radLongDate
            // 
            radLongDate.AutoSize = true;
            radLongDate.Checked = true;
            radLongDate.Font = new Font("Segoe UI", 9.5F);
            radLongDate.Location = new Point(30, 310);
            radLongDate.Name = "radLongDate";
            radLongDate.Size = new Size(86, 21);
            radLongDate.TabIndex = 6;
            radLongDate.TabStop = true;
            radLongDate.Text = "Long Date";
            radLongDate.UseVisualStyleBackColor = true;
            radLongDate.CheckedChanged += radLongDate_CheckedChanged;
            // 
            // dtpProductLaunch
            // 
            dtpProductLaunch.Font = new Font("Segoe UI", 9.5F);
            dtpProductLaunch.Location = new Point(30, 270);
            dtpProductLaunch.Name = "dtpProductLaunch";
            dtpProductLaunch.Size = new Size(250, 24);
            dtpProductLaunch.TabIndex = 5;
            // 
            // lblProductLaunch
            // 
            lblProductLaunch.AutoSize = true;
            lblProductLaunch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProductLaunch.Location = new Point(30, 245);
            lblProductLaunch.Name = "lblProductLaunch";
            lblProductLaunch.Size = new Size(137, 17);
            lblProductLaunch.TabIndex = 4;
            lblProductLaunch.Text = "Product Launch Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9.5F);
            lblEndDate.Location = new Point(280, 110);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(61, 34);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "EndDate:\n6/14/2002";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9.5F);
            lblStartDate.Location = new Point(280, 50);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(65, 34);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "StartDate:\n6/10/2002";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(30, 50);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // lblTravelPrompt
            // 
            lblTravelPrompt.AutoSize = true;
            lblTravelPrompt.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTravelPrompt.Location = new Point(30, 20);
            lblTravelPrompt.Name = "lblTravelPrompt";
            lblTravelPrompt.Size = new Size(170, 17);
            lblTravelPrompt.TabIndex = 0;
            lblTravelPrompt.Text = "Select the days you will travel:";
            // 
            // tabEx3
            // 
            tabEx3.Controls.Add(btnStartStop);
            tabEx3.Controls.Add(trackBar1);
            tabEx3.Controls.Add(lblSlideTrackBar);
            tabEx3.Controls.Add(lblPercentage);
            tabEx3.Controls.Add(progressBar1);
            tabEx3.Controls.Add(lblProgressIndicator);
            tabEx3.Location = new Point(4, 26);
            tabEx3.Name = "tabEx3";
            tabEx3.Padding = new Padding(3);
            tabEx3.Size = new Size(492, 450);
            tabEx3.TabIndex = 2;
            tabEx3.Text = "Ex3: Timer, TrackBar & ProgressBar";
            tabEx3.UseVisualStyleBackColor = true;
            // 
            // btnStartStop
            // 
            btnStartStop.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnStartStop.Location = new Point(40, 270);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(150, 32);
            btnStartStop.TabIndex = 5;
            btnStartStop.Text = "Pause Progress";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(40, 210);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(380, 45);
            trackBar1.TabIndex = 4;
            trackBar1.Value = 5;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // lblSlideTrackBar
            // 
            lblSlideTrackBar.AutoSize = true;
            lblSlideTrackBar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSlideTrackBar.Location = new Point(40, 180);
            lblSlideTrackBar.Name = "lblSlideTrackBar";
            lblSlideTrackBar.Size = new Size(270, 17);
            lblSlideTrackBar.TabIndex = 3;
            lblSlideTrackBar.Text = "Slide the TrackBar to control processing speed:";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 9.5F);
            lblPercentage.Location = new Point(40, 115);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(160, 17);
            lblPercentage.TabIndex = 2;
            lblPercentage.Text = "Percentage Complete: 45%";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(40, 65);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(380, 35);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 45;
            // 
            // lblProgressIndicator
            // 
            lblProgressIndicator.AutoSize = true;
            lblProgressIndicator.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProgressIndicator.Location = new Point(40, 35);
            lblProgressIndicator.Name = "lblProgressIndicator";
            lblProgressIndicator.Size = new Size(125, 17);
            lblProgressIndicator.TabIndex = 0;
            lblProgressIndicator.Text = "Progress Indicator:";
            // 
            // tabEx4
            // 
            tabEx4.Controls.Add(grpTabLayout);
            tabEx4.Controls.Add(btnShow);
            tabEx4.Controls.Add(tabControlEx4);
            tabEx4.Controls.Add(lblMessageBoxOptions);
            tabEx4.Location = new Point(4, 26);
            tabEx4.Name = "tabEx4";
            tabEx4.Padding = new Padding(3);
            tabEx4.Size = new Size(492, 450);
            tabEx4.TabIndex = 3;
            tabEx4.Text = "Ex4: TabControl Controls";
            tabEx4.UseVisualStyleBackColor = true;
            // 
            // grpTabLayout
            // 
            grpTabLayout.Controls.Add(radLayoutBottom);
            grpTabLayout.Controls.Add(radLayoutRight);
            grpTabLayout.Controls.Add(radLayoutTop);
            grpTabLayout.Controls.Add(radLayoutLeft);
            grpTabLayout.Font = new Font("Segoe UI", 9F);
            grpTabLayout.Location = new Point(20, 360);
            grpTabLayout.Name = "grpTabLayout";
            grpTabLayout.Size = new Size(440, 60);
            grpTabLayout.TabIndex = 3;
            grpTabLayout.TabStop = false;
            grpTabLayout.Text = "Tab Layout";
            // 
            // radLayoutBottom
            // 
            radLayoutBottom.AutoSize = true;
            radLayoutBottom.Location = new Point(330, 25);
            radLayoutBottom.Name = "radLayoutBottom";
            radLayoutBottom.Size = new Size(65, 19);
            radLayoutBottom.TabIndex = 3;
            radLayoutBottom.Text = "Bottom";
            radLayoutBottom.UseVisualStyleBackColor = true;
            radLayoutBottom.CheckedChanged += radLayout_CheckedChanged;
            // 
            // radLayoutRight
            // 
            radLayoutRight.AutoSize = true;
            radLayoutRight.Location = new Point(230, 25);
            radLayoutRight.Name = "radLayoutRight";
            radLayoutRight.Size = new Size(53, 19);
            radLayoutRight.TabIndex = 2;
            radLayoutRight.Text = "Right";
            radLayoutRight.UseVisualStyleBackColor = true;
            radLayoutRight.CheckedChanged += radLayout_CheckedChanged;
            // 
            // radLayoutTop
            // 
            radLayoutTop.AutoSize = true;
            radLayoutTop.Checked = true;
            radLayoutTop.Location = new Point(130, 25);
            radLayoutTop.Name = "radLayoutTop";
            radLayoutTop.Size = new Size(45, 19);
            radLayoutTop.TabIndex = 1;
            radLayoutTop.TabStop = true;
            radLayoutTop.Text = "Top";
            radLayoutTop.UseVisualStyleBackColor = true;
            radLayoutTop.CheckedChanged += radLayout_CheckedChanged;
            // 
            // radLayoutLeft
            // 
            radLayoutLeft.AutoSize = true;
            radLayoutLeft.Location = new Point(30, 25);
            radLayoutLeft.Name = "radLayoutLeft";
            radLayoutLeft.Size = new Size(45, 19);
            radLayoutLeft.TabIndex = 0;
            radLayoutLeft.Text = "Left";
            radLayoutLeft.UseVisualStyleBackColor = true;
            radLayoutLeft.CheckedChanged += radLayout_CheckedChanged;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnShow.Location = new Point(175, 315);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(130, 32);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show!";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // tabControlEx4
            // 
            tabControlEx4.Controls.Add(tabMessage);
            tabControlEx4.Controls.Add(tabButtons);
            tabControlEx4.Controls.Add(tabIcon);
            tabControlEx4.Font = new Font("Segoe UI", 9F);
            tabControlEx4.Location = new Point(20, 45);
            tabControlEx4.Name = "tabControlEx4";
            tabControlEx4.SelectedIndex = 0;
            tabControlEx4.Size = new Size(440, 255);
            tabControlEx4.TabIndex = 1;
            // 
            // tabMessage
            // 
            tabMessage.Controls.Add(grpMessageOptions);
            tabMessage.Location = new Point(4, 24);
            tabMessage.Name = "tabMessage";
            tabMessage.Padding = new Padding(3);
            tabMessage.Size = new Size(432, 227);
            tabMessage.TabIndex = 0;
            tabMessage.Text = "Message";
            tabMessage.UseVisualStyleBackColor = true;
            // 
            // grpMessageOptions
            // 
            grpMessageOptions.Controls.Add(txtCaption);
            grpMessageOptions.Controls.Add(lblCapPrompt);
            grpMessageOptions.Controls.Add(txtMessage);
            grpMessageOptions.Controls.Add(lblMsgPrompt);
            grpMessageOptions.Dock = DockStyle.Fill;
            grpMessageOptions.Location = new Point(3, 3);
            grpMessageOptions.Name = "grpMessageOptions";
            grpMessageOptions.Size = new Size(426, 221);
            grpMessageOptions.TabIndex = 0;
            grpMessageOptions.TabStop = false;
            // 
            // txtCaption
            // 
            txtCaption.Location = new Point(25, 135);
            txtCaption.Name = "txtCaption";
            txtCaption.Size = new Size(370, 23);
            txtCaption.TabIndex = 3;
            txtCaption.Text = "TabControl Demo";
            // 
            // lblCapPrompt
            // 
            lblCapPrompt.AutoSize = true;
            lblCapPrompt.Location = new Point(25, 110);
            lblCapPrompt.Name = "lblCapPrompt";
            lblCapPrompt.Size = new Size(183, 15);
            lblCapPrompt.TabIndex = 2;
            lblCapPrompt.Text = "Enter a Caption for MessageBox:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(25, 55);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(370, 23);
            txtMessage.TabIndex = 1;
            txtMessage.Text = "Sample Message";
            // 
            // lblMsgPrompt
            // 
            lblMsgPrompt.AutoSize = true;
            lblMsgPrompt.Location = new Point(25, 30);
            lblMsgPrompt.Name = "lblMsgPrompt";
            lblMsgPrompt.Size = new Size(151, 15);
            lblMsgPrompt.TabIndex = 0;
            lblMsgPrompt.Text = "Enter the message to display:";
            // 
            // tabButtons
            // 
            tabButtons.Controls.Add(grpButtonsOptions);
            tabButtons.Location = new Point(4, 24);
            tabButtons.Name = "tabButtons";
            tabButtons.Padding = new Padding(3);
            tabButtons.Size = new Size(432, 227);
            tabButtons.TabIndex = 1;
            tabButtons.Text = "Buttons";
            tabButtons.UseVisualStyleBackColor = true;
            // 
            // grpButtonsOptions
            // 
            grpButtonsOptions.Controls.Add(radYesNoCancel);
            grpButtonsOptions.Controls.Add(radYesNo);
            grpButtonsOptions.Controls.Add(radRetryCancel);
            grpButtonsOptions.Controls.Add(radOKCancel);
            grpButtonsOptions.Controls.Add(radOK);
            grpButtonsOptions.Dock = DockStyle.Fill;
            grpButtonsOptions.Location = new Point(3, 3);
            grpButtonsOptions.Name = "grpButtonsOptions";
            grpButtonsOptions.Size = new Size(426, 221);
            grpButtonsOptions.TabIndex = 0;
            grpButtonsOptions.TabStop = false;
            // 
            // radYesNoCancel
            // 
            radYesNoCancel.AutoSize = true;
            radYesNoCancel.Location = new Point(30, 160);
            radYesNoCancel.Name = "radYesNoCancel";
            radYesNoCancel.Size = new Size(129, 19);
            radYesNoCancel.TabIndex = 4;
            radYesNoCancel.Text = "Yes, No and Cancel";
            radYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // radYesNo
            // 
            radYesNo.AutoSize = true;
            radYesNo.Location = new Point(30, 125);
            radYesNo.Name = "radYesNo";
            radYesNo.Size = new Size(84, 19);
            radYesNo.TabIndex = 3;
            radYesNo.Text = "Yes and No";
            radYesNo.UseVisualStyleBackColor = true;
            // 
            // radRetryCancel
            // 
            radRetryCancel.AutoSize = true;
            radRetryCancel.Location = new Point(30, 90);
            radRetryCancel.Name = "radRetryCancel";
            radRetryCancel.Size = new Size(111, 19);
            radRetryCancel.TabIndex = 2;
            radRetryCancel.Text = "Retry and Cancel";
            radRetryCancel.UseVisualStyleBackColor = true;
            // 
            // radOKCancel
            // 
            radOKCancel.AutoSize = true;
            radOKCancel.Location = new Point(30, 55);
            radOKCancel.Name = "radOKCancel";
            radOKCancel.Size = new Size(100, 19);
            radOKCancel.TabIndex = 1;
            radOKCancel.Text = "OK and Cancel";
            radOKCancel.UseVisualStyleBackColor = true;
            // 
            // radOK
            // 
            radOK.AutoSize = true;
            radOK.Checked = true;
            radOK.Location = new Point(30, 20);
            radOK.Name = "radOK";
            radOK.Size = new Size(41, 19);
            radOK.TabIndex = 0;
            radOK.TabStop = true;
            radOK.Text = "OK";
            radOK.UseVisualStyleBackColor = true;
            // 
            // tabIcon
            // 
            tabIcon.Controls.Add(grpIconOptions);
            tabIcon.Location = new Point(4, 24);
            tabIcon.Name = "tabIcon";
            tabIcon.Padding = new Padding(3);
            tabIcon.Size = new Size(432, 227);
            tabIcon.TabIndex = 2;
            tabIcon.Text = "Icon";
            tabIcon.UseVisualStyleBackColor = true;
            // 
            // grpIconOptions
            // 
            grpIconOptions.Controls.Add(radWarning);
            grpIconOptions.Controls.Add(radQuestion);
            grpIconOptions.Controls.Add(radNone);
            grpIconOptions.Controls.Add(radInformation);
            grpIconOptions.Controls.Add(radError);
            grpIconOptions.Dock = DockStyle.Fill;
            grpIconOptions.Location = new Point(3, 3);
            grpIconOptions.Name = "grpIconOptions";
            grpIconOptions.Size = new Size(426, 221);
            grpIconOptions.TabIndex = 0;
            grpIconOptions.TabStop = false;
            // 
            // radWarning
            // 
            radWarning.AutoSize = true;
            radWarning.Location = new Point(30, 160);
            radWarning.Name = "radWarning";
            radWarning.Size = new Size(70, 19);
            radWarning.TabIndex = 4;
            radWarning.Text = "Warning";
            radWarning.UseVisualStyleBackColor = true;
            // 
            // radQuestion
            // 
            radQuestion.AutoSize = true;
            radQuestion.Location = new Point(30, 125);
            radQuestion.Name = "radQuestion";
            radQuestion.Size = new Size(73, 19);
            radQuestion.TabIndex = 3;
            radQuestion.Text = "Question";
            radQuestion.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            radNone.AutoSize = true;
            radNone.Location = new Point(30, 90);
            radNone.Name = "radNone";
            radNone.Size = new Size(54, 19);
            radNone.TabIndex = 2;
            radNone.Text = "None";
            radNone.UseVisualStyleBackColor = true;
            // 
            // radInformation
            // 
            radInformation.AutoSize = true;
            radInformation.Checked = true;
            radInformation.Location = new Point(30, 55);
            radInformation.Name = "radInformation";
            radInformation.Size = new Size(88, 19);
            radInformation.TabIndex = 1;
            radInformation.TabStop = true;
            radInformation.Text = "Information";
            radInformation.UseVisualStyleBackColor = true;
            // 
            // radError
            // 
            radError.AutoSize = true;
            radError.Location = new Point(30, 20);
            radError.Name = "radError";
            radError.Size = new Size(50, 19);
            radError.TabIndex = 0;
            radError.Text = "Error";
            radError.UseVisualStyleBackColor = true;
            // 
            // lblMessageBoxOptions
            // 
            lblMessageBoxOptions.AutoSize = true;
            lblMessageBoxOptions.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMessageBoxOptions.Location = new Point(20, 15);
            lblMessageBoxOptions.Name = "lblMessageBoxOptions";
            lblMessageBoxOptions.Size = new Size(230, 17);
            lblMessageBoxOptions.TabIndex = 0;
            lblMessageBoxOptions.Text = "Select options to create a message box:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 480);
            Controls.Add(mainTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 15: Sử dụng các control của Visual Studio";
            Load += Form1_Load;
            mainTabControl.ResumeLayout(false);
            tabEx1.ResumeLayout(false);
            tabEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            tabEx2.ResumeLayout(false);
            tabEx2.PerformLayout();
            tabEx3.ResumeLayout(false);
            tabEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabEx4.ResumeLayout(false);
            tabEx4.PerformLayout();
            grpTabLayout.ResumeLayout(false);
            grpTabLayout.PerformLayout();
            tabControlEx4.ResumeLayout(false);
            tabMessage.ResumeLayout(false);
            grpMessageOptions.ResumeLayout(false);
            grpMessageOptions.PerformLayout();
            tabButtons.ResumeLayout(false);
            grpButtonsOptions.ResumeLayout(false);
            grpButtonsOptions.PerformLayout();
            tabIcon.ResumeLayout(false);
            grpIconOptions.ResumeLayout(false);
            grpIconOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage tabEx1;
        private TabPage tabEx2;
        private TabPage tabEx3;
        private TabPage tabEx4;
        private Label lblColor;
        private Label lblSize;
        private DomainUpDown dudColor;
        private NumericUpDown nudSize;
        private Label lblSampleText;
        private Label lblTravelPrompt;
        private MonthCalendar monthCalendar1;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblProductLaunch;
        private DateTimePicker dtpProductLaunch;
        private RadioButton radLongDate;
        private RadioButton radShortDate;
        private Label lblProgressIndicator;
        private ProgressBar progressBar1;
        private Label lblPercentage;
        private Label lblSlideTrackBar;
        private TrackBar trackBar1;
        private Button btnStartStop;
        private Label lblMessageBoxOptions;
        private TabControl tabControlEx4;
        private TabPage tabMessage;
        private TabPage tabButtons;
        private TabPage tabIcon;
        private GroupBox grpMessageOptions;
        private TextBox txtMessage;
        private Label lblMsgPrompt;
        private TextBox txtCaption;
        private Label lblCapPrompt;
        private GroupBox grpButtonsOptions;
        private RadioButton radOK;
        private RadioButton radOKCancel;
        private RadioButton radRetryCancel;
        private RadioButton radYesNo;
        private RadioButton radYesNoCancel;
        private GroupBox grpIconOptions;
        private RadioButton radError;
        private RadioButton radInformation;
        private RadioButton radNone;
        private RadioButton radQuestion;
        private RadioButton radWarning;
        private Button btnShow;
        private GroupBox grpTabLayout;
        private RadioButton radLayoutLeft;
        private RadioButton radLayoutRight;
        private RadioButton radLayoutTop;
        private RadioButton radLayoutBottom;
        private System.Windows.Forms.Timer timer1;
    }
}
