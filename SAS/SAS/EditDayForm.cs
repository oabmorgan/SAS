using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace SAS
{
    public partial class EditDayForm : Form
    {
        public DateTime date;
        public WorkDay newWorkDay;
        public WorkDay lastWorkDay;
        TimeSpan startTime;
        TimeSpan endTime;

        public List<school> schools = new List<school>();

        public EditDayForm()
        {
            InitializeComponent();
            updateForm();
            this.AcceptButton = okButton;
            schoolNumberCombo.Select();
        }


        public void updateForm()
        {
            dayOfWeekLabel.Text = date.ToString("ddd").ToUpper();
            dateLabel.Text = date.Day.ToString();

            foreach(school school in schools)
            {
                schoolNameCombo.Items.Add(school.schoolName);
                schoolNumberCombo.Items.Add(school.schoolNumber);
            }

            if(date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Monday)
            {
                DayPanel.BackColor = Color.CornflowerBlue;
            } else
            {
                DayPanel.BackColor = Color.DarkGray;
            }

            if (lastWorkDay != null)
            {
                schoolNumberCombo.Text = lastWorkDay.schoolNumber;
                schoolNameCombo.Text = lastWorkDay.schoolName;
                travelCostTextbox.Text = lastWorkDay.cost;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        void inputError(int errorID)
        {
        }

        bool verifyOK()
        {
            if (lessonRadiobutton.Checked)
            {
                TimeSpan startTime;
                if (!TimeSpan.TryParse(startCombo.Text, out startTime))
                {
                    return false;
                }

                TimeSpan endTime;
                if (!TimeSpan.TryParse(endCombo.Text, out endTime))
                {
                    return false;
                }

                if(travelCostTextbox.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (verifyOK())
            {
                newWorkDay = new WorkDay(date, startCombo.Text, endCombo.Text, workHoursNumeric.Value, schoolNameCombo.Text, schoolNumberCombo.Text, travelCostTextbox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void dayLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void toggleSchoolInfoEnter(bool state = false)
        {
            enterSchoolPanel.Enabled = state;
        }

        private void offRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toggleSchoolInfoEnter();
            schoolNameCombo.Text = "";
            schoolNumberCombo.Text = "";
            travelCostTextbox.Text = "";
        }

        private void schoolNumberCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(school school in schools)
            {
                if(school.schoolNumber == schoolNumberCombo.Text){
                    schoolNameCombo.Text = school.schoolName;
                    travelCostTextbox.Text = school.travelCost;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lessonRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            toggleSchoolInfoEnter(true);
            schoolNameCombo.Text = "";
        }

        private void sickRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toggleSchoolInfoEnter();
            schoolNameCombo.Text = "Sick";
            schoolNumberCombo.Text = "";
            travelCostTextbox.Text = "";
        }

        private void paidVacationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            toggleSchoolInfoEnter();
            schoolNameCombo.Text = "Paid Vacation";
            schoolNumberCombo.Text = "";
            travelCostTextbox.Text = "";
        }

        private void startCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan.TryParse(startCombo.Text, out startTime);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void endCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TimeSpan.TryParse(endCombo.Text, out endTime))
            {
            }
            if (endTime > startTime)
            {
                float rounded = (float)(endTime - startTime).TotalHours;
                rounded = (float)Math.Round((rounded * 2), MidpointRounding.AwayFromZero) / 2;
                workHoursNumeric.Value = (decimal)rounded;
            }
        }

        private void BTACheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BTACheckbox.Checked)
            {
                travelCostTextbox.Text = "BTA";
                travelCostTextbox.Enabled = false;
            } else
            {
                travelCostTextbox.Text = "";
                travelCostTextbox.Enabled = true;
            }
        }

        private void schoolNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (school school in schools)
            {
                if (school.schoolName == schoolNameCombo.Text)
                {
                    schoolNumberCombo.Text = school.schoolNumber;
                    travelCostTextbox.Text = school.travelCost;
                }
            }
        }
    }
}