namespace SAS
{
    partial class EditDayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDayForm));
            this.okButton = new System.Windows.Forms.Button();
            this.schoolNameCombo = new System.Windows.Forms.ComboBox();
            this.BTACheckbox = new System.Windows.Forms.CheckBox();
            this.travelCostTextbox = new System.Windows.Forms.TextBox();
            this.dayTypeSelectionPanel = new System.Windows.Forms.Panel();
            this.paidVacationRadioButton = new System.Windows.Forms.RadioButton();
            this.sickRadioButton = new System.Windows.Forms.RadioButton();
            this.offRadioButton = new System.Windows.Forms.RadioButton();
            this.lessonRadiobutton = new System.Windows.Forms.RadioButton();
            this.schoolNumberCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workHoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.startCombo = new System.Windows.Forms.ComboBox();
            this.endCombo = new System.Windows.Forms.ComboBox();
            this.enterSchoolPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DayPanel = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.dayTypeSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workHoursNumeric)).BeginInit();
            this.enterSchoolPanel.SuspendLayout();
            this.DayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.okButton.Location = new System.Drawing.Point(20, 178);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 31);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // schoolNameCombo
            // 
            this.schoolNameCombo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.schoolNameCombo.FormattingEnabled = true;
            this.schoolNameCombo.Location = new System.Drawing.Point(78, 18);
            this.schoolNameCombo.Name = "schoolNameCombo";
            this.schoolNameCombo.Size = new System.Drawing.Size(341, 27);
            this.schoolNameCombo.TabIndex = 1;
            this.schoolNameCombo.SelectedIndexChanged += new System.EventHandler(this.schoolNameCombo_SelectedIndexChanged);
            // 
            // BTACheckbox
            // 
            this.BTACheckbox.AutoSize = true;
            this.BTACheckbox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BTACheckbox.Location = new System.Drawing.Point(86, 131);
            this.BTACheckbox.Name = "BTACheckbox";
            this.BTACheckbox.Size = new System.Drawing.Size(50, 17);
            this.BTACheckbox.TabIndex = 9;
            this.BTACheckbox.Text = "BTA";
            this.BTACheckbox.UseVisualStyleBackColor = true;
            this.BTACheckbox.CheckedChanged += new System.EventHandler(this.BTACheckbox_CheckedChanged);
            // 
            // travelCostTextbox
            // 
            this.travelCostTextbox.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.travelCostTextbox.Location = new System.Drawing.Point(20, 126);
            this.travelCostTextbox.Name = "travelCostTextbox";
            this.travelCostTextbox.Size = new System.Drawing.Size(60, 26);
            this.travelCostTextbox.TabIndex = 5;
            // 
            // dayTypeSelectionPanel
            // 
            this.dayTypeSelectionPanel.Controls.Add(this.paidVacationRadioButton);
            this.dayTypeSelectionPanel.Controls.Add(this.sickRadioButton);
            this.dayTypeSelectionPanel.Controls.Add(this.offRadioButton);
            this.dayTypeSelectionPanel.Controls.Add(this.lessonRadiobutton);
            this.dayTypeSelectionPanel.Location = new System.Drawing.Point(126, 18);
            this.dayTypeSelectionPanel.Name = "dayTypeSelectionPanel";
            this.dayTypeSelectionPanel.Size = new System.Drawing.Size(422, 28);
            this.dayTypeSelectionPanel.TabIndex = 11;
            // 
            // paidVacationRadioButton
            // 
            this.paidVacationRadioButton.AutoSize = true;
            this.paidVacationRadioButton.Location = new System.Drawing.Point(212, 4);
            this.paidVacationRadioButton.Name = "paidVacationRadioButton";
            this.paidVacationRadioButton.Size = new System.Drawing.Size(94, 16);
            this.paidVacationRadioButton.TabIndex = 3;
            this.paidVacationRadioButton.Text = "Paid Vacation";
            this.paidVacationRadioButton.UseVisualStyleBackColor = true;
            this.paidVacationRadioButton.CheckedChanged += new System.EventHandler(this.paidVacationRadioButton_CheckedChanged);
            // 
            // sickRadioButton
            // 
            this.sickRadioButton.AutoSize = true;
            this.sickRadioButton.Location = new System.Drawing.Point(137, 4);
            this.sickRadioButton.Name = "sickRadioButton";
            this.sickRadioButton.Size = new System.Drawing.Size(69, 16);
            this.sickRadioButton.TabIndex = 2;
            this.sickRadioButton.Text = "Sick Day";
            this.sickRadioButton.UseVisualStyleBackColor = true;
            this.sickRadioButton.CheckedChanged += new System.EventHandler(this.sickRadioButton_CheckedChanged);
            // 
            // offRadioButton
            // 
            this.offRadioButton.AutoSize = true;
            this.offRadioButton.Location = new System.Drawing.Point(68, 4);
            this.offRadioButton.Name = "offRadioButton";
            this.offRadioButton.Size = new System.Drawing.Size(63, 16);
            this.offRadioButton.TabIndex = 1;
            this.offRadioButton.Text = "Day Off";
            this.offRadioButton.UseVisualStyleBackColor = true;
            this.offRadioButton.CheckedChanged += new System.EventHandler(this.offRadioButton_CheckedChanged);
            // 
            // lessonRadiobutton
            // 
            this.lessonRadiobutton.AutoSize = true;
            this.lessonRadiobutton.Checked = true;
            this.lessonRadiobutton.Location = new System.Drawing.Point(3, 4);
            this.lessonRadiobutton.Name = "lessonRadiobutton";
            this.lessonRadiobutton.Size = new System.Drawing.Size(59, 16);
            this.lessonRadiobutton.TabIndex = 0;
            this.lessonRadiobutton.TabStop = true;
            this.lessonRadiobutton.Text = "Lesson";
            this.lessonRadiobutton.UseVisualStyleBackColor = true;
            this.lessonRadiobutton.CheckedChanged += new System.EventHandler(this.lessonRadiobutton_CheckedChanged);
            // 
            // schoolNumberCombo
            // 
            this.schoolNumberCombo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.schoolNumberCombo.FormattingEnabled = true;
            this.schoolNumberCombo.Location = new System.Drawing.Point(3, 18);
            this.schoolNumberCombo.Name = "schoolNumberCombo";
            this.schoolNumberCombo.Size = new System.Drawing.Size(69, 27);
            this.schoolNumberCombo.TabIndex = 0;
            this.schoolNumberCombo.SelectedIndexChanged += new System.EventHandler(this.schoolNumberCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(3, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "¥";
            // 
            // workHoursNumeric
            // 
            this.workHoursNumeric.DecimalPlaces = 1;
            this.workHoursNumeric.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.workHoursNumeric.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.workHoursNumeric.Location = new System.Drawing.Point(153, 74);
            this.workHoursNumeric.Name = "workHoursNumeric";
            this.workHoursNumeric.Size = new System.Drawing.Size(62, 26);
            this.workHoursNumeric.TabIndex = 4;
            // 
            // startCombo
            // 
            this.startCombo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startCombo.FormattingEnabled = true;
            this.startCombo.Items.AddRange(new object[] {
            "11:15",
            "13:15",
            "14:30",
            "15:45",
            "17:00",
            "18:15",
            "20:30",
            "21:45",
            "",
            "11:00",
            "10:30",
            "12:00",
            "13:00",
            "14:00"});
            this.startCombo.Location = new System.Drawing.Point(3, 74);
            this.startCombo.Name = "startCombo";
            this.startCombo.Size = new System.Drawing.Size(69, 27);
            this.startCombo.TabIndex = 2;
            this.startCombo.SelectedIndexChanged += new System.EventHandler(this.startCombo_SelectedIndexChanged);
            // 
            // endCombo
            // 
            this.endCombo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.endCombo.FormattingEnabled = true;
            this.endCombo.Items.AddRange(new object[] {
            "12:15",
            "14:15",
            "15:30",
            "16:45",
            "18:00",
            "19:15",
            "20:30",
            "21:45",
            "",
            "16:30",
            "19:00",
            "22:00"});
            this.endCombo.Location = new System.Drawing.Point(78, 74);
            this.endCombo.Name = "endCombo";
            this.endCombo.Size = new System.Drawing.Size(69, 27);
            this.endCombo.TabIndex = 3;
            this.endCombo.SelectedIndexChanged += new System.EventHandler(this.endCombo_SelectedIndexChanged);
            // 
            // enterSchoolPanel
            // 
            this.enterSchoolPanel.Controls.Add(this.label7);
            this.enterSchoolPanel.Controls.Add(this.label6);
            this.enterSchoolPanel.Controls.Add(this.travelCostTextbox);
            this.enterSchoolPanel.Controls.Add(this.label5);
            this.enterSchoolPanel.Controls.Add(this.BTACheckbox);
            this.enterSchoolPanel.Controls.Add(this.label4);
            this.enterSchoolPanel.Controls.Add(this.workHoursNumeric);
            this.enterSchoolPanel.Controls.Add(this.label3);
            this.enterSchoolPanel.Controls.Add(this.label2);
            this.enterSchoolPanel.Controls.Add(this.endCombo);
            this.enterSchoolPanel.Controls.Add(this.label1);
            this.enterSchoolPanel.Controls.Add(this.startCombo);
            this.enterSchoolPanel.Controls.Add(this.schoolNumberCombo);
            this.enterSchoolPanel.Controls.Add(this.schoolNameCombo);
            this.enterSchoolPanel.Location = new System.Drawing.Point(126, 52);
            this.enterSchoolPanel.Name = "enterSchoolPanel";
            this.enterSchoolPanel.Size = new System.Drawing.Size(422, 157);
            this.enterSchoolPanel.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Work Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "School Name / Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "School No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DayPanel
            // 
            this.DayPanel.Controls.Add(this.dateLabel);
            this.DayPanel.Controls.Add(this.dayOfWeekLabel);
            this.DayPanel.Location = new System.Drawing.Point(20, 18);
            this.DayPanel.Name = "DayPanel";
            this.DayPanel.Size = new System.Drawing.Size(87, 90);
            this.DayPanel.TabIndex = 20;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateLabel.Location = new System.Drawing.Point(2, 34);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(85, 56);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "25";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.Location = new System.Drawing.Point(0, 7);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(87, 19);
            this.dayOfWeekLabel.TabIndex = 2;
            this.dayOfWeekLabel.Text = "WED";
            this.dayOfWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditDayForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 219);
            this.Controls.Add(this.DayPanel);
            this.Controls.Add(this.enterSchoolPanel);
            this.Controls.Add(this.dayTypeSelectionPanel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDayForm";
            this.Text = "Add Day";
            this.dayTypeSelectionPanel.ResumeLayout(false);
            this.dayTypeSelectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workHoursNumeric)).EndInit();
            this.enterSchoolPanel.ResumeLayout(false);
            this.enterSchoolPanel.PerformLayout();
            this.DayPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox schoolNameCombo;
        private System.Windows.Forms.CheckBox BTACheckbox;
        private System.Windows.Forms.TextBox travelCostTextbox;
        private System.Windows.Forms.Panel dayTypeSelectionPanel;
        private System.Windows.Forms.RadioButton paidVacationRadioButton;
        private System.Windows.Forms.RadioButton sickRadioButton;
        private System.Windows.Forms.RadioButton offRadioButton;
        private System.Windows.Forms.RadioButton lessonRadiobutton;
        private System.Windows.Forms.ComboBox schoolNumberCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown workHoursNumeric;
        private System.Windows.Forms.ComboBox startCombo;
        private System.Windows.Forms.ComboBox endCombo;
        private System.Windows.Forms.Panel enterSchoolPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel DayPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dayOfWeekLabel;
    }
}