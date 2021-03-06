﻿using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Xml.Linq;
using System.Xml;

namespace SAS
{
    public partial class SAS : Form
    {

        public DateTime reportMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

        public int currentDay = 0;

        public List<WorkDay> workDays = new List<WorkDay>();
        public List<school> schools = new List<school>();
        public string name;
        public string area;
        public string initials;
        public string employeeNumber;
        public XDocument doc;

        public SAS()
        {
            InitializeComponent();
            yearTextBox.Text = reportMonth.Year.ToString();
            monthTextBox.Text = reportMonth.Month.ToString();
            hideTextbox(yearTextBox);
            hideTextbox(monthTextBox);
            nameTextBox.Select();

            try
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    client.DownloadFile("https://drive.google.com/uc?export=download&id=12lbSOSAkiOnK4x5Sh-fxRFmOit_pr4EM", Application.StartupPath + "Schools.xml");
                }

                doc = XDocument.Load(Application.StartupPath + "Schools.xml");

                if (doc.Descendants().Count() > 0)
                {
                    foreach (XElement schoolArea in doc.Elements("area"))
                    {
                        areaCombo.Items.Add(schoolArea.Element("name").Value);
                    }
                }
            }
            catch
            {
                areaCombo.Enabled = false;
                areaCombo.Text = "No Connection";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditDayForm editDayForm = new EditDayForm();
            if (currentDay > 1)
            {
                editDayForm.lastWorkDay = workDays[currentDay - 1];
            }
            editDayForm.StartPosition = FormStartPosition.CenterParent;
            editDayForm.date = reportMonth.AddDays(currentDay);
            editDayForm.schools = schools;
            editDayForm.updateForm();

            DialogResult result = editDayForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (editDayForm.newWorkDay.schoolNumber != "")
                {
                    if(!schools.Any(s => s.schoolNumber == editDayForm.newWorkDay.schoolNumber))
                    {
                        schools.Add(new school(editDayForm.newWorkDay.schoolNumber, editDayForm.newWorkDay.schoolName, editDayForm.newWorkDay.cost));
                    } else
                    {
                        schools.First(s => s.schoolNumber == editDayForm.newWorkDay.schoolNumber).travelCost = editDayForm.newWorkDay.cost;
                    }
                }
                addDay(editDayForm.newWorkDay);
                currentDay++;
                if (currentDay >= DateTime.DaysInMonth(reportMonth.Year, reportMonth.Month))
                {
                    button1.Enabled = false;
                } else
                {
                    button1.PerformClick();
                }
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            initials = new Regex(@"(\b[a-zA-Z])[a-zA-Z]* ?").Replace(nameTextBox.Text, "$1");

            hideTextbox(nameTextBox);
            button1.Enabled = true;

        }

        private void employeeNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            employeeNumber = employeeNumberTextBox.Text;

            hideTextbox(employeeNumberTextBox);
        }

        private void hideTextbox(TextBox textBoxToHide)
        {
            if (textBoxToHide.Text.Length > 0)
            {
                textBoxToHide.BackColor = Color.White;
                textBoxToHide.BorderStyle = BorderStyle.None;
            } else
            {
                textBoxToHide.BackColor = Color.Gold;
                textBoxToHide.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PrintImage();
            decimal totalTime = 0;
            float totalCost = 0;
            foreach(WorkDay day in workDays)
            {
                float dayCost;
                if (float.TryParse(day.cost, out dayCost)){
                    totalCost += dayCost;
                }
                totalTime += day.workTime;
            }

            Report.Text = "("+employeeNumber+"/"+area+") "+name+" "+totalTime + " Hours ¥" + totalCost;
        }

        private void PrintImage()
        {
            


            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";
            dialog.DefaultExt = "png";
            dialog.AddExtension = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SASImage.BringToFront();
                int width = Convert.ToInt32(printPanel.Width);
                int height = Convert.ToInt32(printPanel.Height);
                Bitmap bmp = new Bitmap(width, height);
                printPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                SASImage.SendToBack();
                
                bmp.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            
        }

        public static string Ordinal(int n)
        {
            int r = n % 100, m = n % 10;

            return (r < 4 || r > 20) && (m > 0 && m < 4) ? n + "  stndrd".Substring(m * 2, 2) : n + "th";
        }

        private void addDay(WorkDay newDay)
        {
            int day = newDay.date.Day;

            TableLayoutPanel targetPanel = leftTableLayout;
            if (day > 16)
            {
                targetPanel = rightTableLayout;
            }

            var culture = new System.Globalization.CultureInfo("en-GB");

            targetPanel.SuspendLayout();
            for (int i = 0; i < 8; i++)
            {
                TextBox newTextBox = formattedTextBox();
                switch (i)
                {
                    case 0://Day of the month
                        newTextBox.Text = Ordinal(newDay.date.Day);
                        break;
                    case 1://Day of the week
                        newTextBox.Text = culture.DateTimeFormat.GetShortestDayName(newDay.date.DayOfWeek);
                        break;
                    case 2://Work or off
                        switch (newDay.schoolName)
                        {
                            case "":
                                newTextBox.Text = "Off";
                                break;
                            case "Paid Vacation":
                                newTextBox.Text = "Off";
                                break;
                            case "Sick":
                                newTextBox.Text = "Off";
                                break;
                            default:
                                newTextBox.Text = initials;
                                break;
                        }
                        break;
                    case 3://check in
                        newTextBox.Text = newDay.startTime;
                        break;
                    case 4://check out
                        newTextBox.Text = newDay.endTime;
                        break;
                    case 5://total hours
                        if(newDay.workTime > 0)
                            newTextBox.Text = newDay.workTime.ToString();
                        break;
                    case 6://location
                        string locationString = "";
                        if(newDay.schoolNumber != "")
                        {
                            locationString += "(" + newDay.schoolNumber + ") ";
                        }
                        locationString += newDay.schoolName;

                        newTextBox.Text = locationString;
                        break;
                    case 7://cost
                        newTextBox.Text = newDay.cost;
                        break;
                }
                if(day <= 16)
                {
                    targetPanel.Controls.Add(newTextBox, i, day - 1);
                } else
                {
                    targetPanel.Controls.Add(newTextBox, i, day - 17);
                }
                
            }
            targetPanel.ResumeLayout();
            workDays.Add(newDay);
        }

        private TextBox formattedTextBox()
        {
            TextBox newTextBox = new TextBox();
            newTextBox.BorderStyle = BorderStyle.None;
            newTextBox.Margin = new Padding(1, 7, 1, 0);
            newTextBox.TextAlign = HorizontalAlignment.Center;
            newTextBox.Width = 200;
            return newTextBox;
        }

        private void areaTextBox_TextChanged(object sender, EventArgs e)
        {
            area = areaTextBox.Text;

            hideTextbox(areaTextBox);
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void SASImage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void areaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (XElement schoolArea in doc.Elements("area"))
            {
                if (schoolArea.Element("name").Value == areaCombo.SelectedItem.ToString()){
                    schools.Clear();
                    foreach (XElement loadedSchool in schoolArea.Elements("school"))
                    {
                        schools.Add(new school(loadedSchool.Element("number").Value, loadedSchool.Element("name").Value, loadedSchool.Element("cost").Value));
                    }
                }
            }
            areaTextBox.Text = areaCombo.Text;
        }

        private void monthTextBox_TextChanged(object sender, EventArgs e)
        {
            int updateMonth;
            if(int.TryParse(monthTextBox.Text, out updateMonth)){
                if (updateMonth > 0 && updateMonth <= 12)
                {
                    reportMonth = new DateTime(reportMonth.Year, int.Parse(monthTextBox.Text), reportMonth.Day);
                }
            }
        }
    }

    public class school
    {
        public string schoolNumber;
        public string schoolName;
        public string travelCost;

        public school(string number, string name, string cost)
        {
            schoolName = name;
            schoolNumber = number;
            travelCost = cost;
        }
    }
}
