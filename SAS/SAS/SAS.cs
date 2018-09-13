using System;
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
using System.IO;
using System.IO.Compression;


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
                if (DateTime.Now.CompareTo(Properties.Settings.Default.timeLock) > 0)
                {
                    Properties.Settings.Default.timeLock = DateTime.Now.AddMonths(1);
                    return;
                }
            }
            catch
            {
                if (DateTime.Now.CompareTo(Properties.Settings.Default.timeLock) > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Credentials Expired.");
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadXPS.Visible = false;
            EditDayForm editDayForm = new EditDayForm();
            if (currentDay > 1)
            {
                editDayForm.lastWorkDay = workDays[currentDay - 1];
            }
            editDayForm.StartPosition = FormStartPosition.CenterParent;
            editDayForm.date = reportMonth.AddDays(currentDay);
            editDayForm.schools = schools;

            if(path != null)
            {
                Console.WriteLine("try to read XPS Stuff");
            }

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
        }

        private void PrintImage()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";
            dialog.DefaultExt = "png";
            dialog.AddExtension = true;
            dialog.FileName = "SAS_"+yearTextBox.Text + "_" + monthTextBox.Text + "_" + nameTextBox.Text + "_" + employeeNumberTextBox.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SASImage.BringToFront();
                int width = Convert.ToInt32(printPanel.Width);
                int height = Convert.ToInt32(printPanel.Height);
                Bitmap bmp = new Bitmap(width, height);
                printPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                SASImage.SendToBack();
                bmp.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                Process.Start(dialog.FileName);

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

        string path;
        string unzipPath;

        void readXPS()
        {
            leftTableLayout.Controls.Clear();
            rightTableLayout.Controls.Clear();
            nameTextBox.Text = "";
            employeeNumberTextBox.Text = "";
            areaTextBox.Text = "";
            monthTextBox.Text = "";
            yearTextBox.Text = "";

            List<WorkDay> fromXPS = new List<WorkDay>();

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Schedule files (*.xps)|*.xps; *.XPS; *.OXPS; *.oxps)";

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                Console.WriteLine("Loaded " + path);

                using (ZipArchive archive = ZipFile.OpenRead(path))
                {
                    foreach(ZipArchiveEntry entry in archive.Entries)
                    {
                        Console.WriteLine(entry.Name);
                        if(entry.Name == "1.fpage")
                        {
                            unzipPath = path + "- Unzipped";
                            if (File.Exists(unzipPath))
                            {
                                File.Delete(unzipPath);
                            }
                            entry.ExtractToFile(path + "- Unzipped");
                        }
                    }
                }

                string[] lines = System.IO.File.ReadAllLines(unzipPath);
                int day = 1;

                foreach(string line in lines)
                {
                    string rawValue = readLine(line, "UnicodeString");
                    Console.WriteLine(rawValue);
                    switch (getLineType(line))
                    {
                        case lineType.day:
                            int p;
                            if(int.TryParse(rawValue, out p))
                            {
                                if (rawValue.Length == 4)
                                {
                                    int day1 = int.Parse(rawValue.Substring(0, 2));
                                    int day2 = int.Parse(rawValue.Substring(2, 2));
                                    Console.WriteLine("Day: " + day1);
                                    fromXPS.Add(new WorkDay(day1));
                                    Console.WriteLine("Day: " + day2);
                                    fromXPS.Add(new WorkDay(day2));
                                    day = day2;
                                }
                                else
                                {
                                    Console.WriteLine("Day: " + p);
                                    fromXPS.Add(new WorkDay(p));
                                    day = p;
                                }
                            }
                            break;
                        case lineType.time:
                            DateTime start;
                            DateTime end;
                            if (DateTime.TryParse(rawValue.Split(' ')[0], out start))
                            {
                                if(fromXPS[day-1].startTime == "")
                                    fromXPS[day-1].startTime = start.ToString("HH:mm");

                                end = start.AddHours(1);
                                fromXPS[day - 1].endTime = end.ToString("HH:mm");
                                fromXPS[day - 1].workTime += 1.25M;
                                fromXPS[day - 1].lessons.Add(rawValue);
                            }
                            break;
                        case lineType.location:
                            if (fromXPS.Count > 0 && day > 0)
                            {
                                int schoolNumber;
                                if (int.TryParse(rawValue.Split(' ')[0], out schoolNumber))
                                {
                                    fromXPS[day - 1].schoolNumber = schoolNumber.ToString();
                                    fromXPS[day - 1].schoolName = rawValue.Split(' ')[1];
                                }
                                else
                                {
                                    fromXPS[day - 1].schoolName += rawValue;
                                }
                                if(fromXPS[day-1].schoolName == "OFFICE DAY")
                                {
                                    fromXPS[day - 1].startTime = "11:00";
                                    fromXPS[day - 1].endTime = "16:30";
                                    fromXPS[day - 1].workTime = 5.5M;
                                }
                                if (fromXPS[day - 1].schoolName == "DAY OFF")
                                {
                                    fromXPS[day - 1].schoolName = "";
                                }
                            }
                            break;
                        case lineType.teacher:
                            day = 0;
                            string[] split = rawValue.Split(' ');
                            employeeNumberTextBox.Text = split[1];
                            for(int s=2; s<split.Length; s++)
                            {
                                nameTextBox.Text += split[s] + "\r\n"; 
                            }
                            break;
                        case lineType.area:
                            areaTextBox.Text = rawValue.Split(' ').Last();
                            break;
                        case lineType.month:
                            monthTextBox.Text = rawValue.Split(' ').Last().Substring(3,2).Split('/')[0];
                            yearTextBox.Text = rawValue.Split(' ').Last().Substring(0,2);
                            break;
                        default:
                            break;
                    }
                }
            }
            foreach(WorkDay workday in fromXPS)
            {
                addDay(workday);
            }

        }

        void CreateCSV()
        {
            if(workDays.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Fill out the form first..");
                return;
            }
            List<String> CSVList = new List<string>();
            System.IO.File.WriteAllText("CSV.txt", "Subject,Start Date,Start Time,End Date,End Time,All Day Event,Description,Location,Private" + Environment.NewLine);
            Console.WriteLine(Application.StartupPath);
            foreach (WorkDay day in workDays)
            {
                if (day.workTime > 0)
                {
                    string csvLine = "";
                    Console.WriteLine();
                    if(day.schoolNumber != "")
                    {
                        csvLine += "(" + day.schoolNumber + ") ";
                    }
                    csvLine += day.schoolName + ",";
                    csvLine += day.date.ToShortDateString() + ",";
                    csvLine += string.Format("{0:00}:{1:00}", TimeSpan.Parse(day.startTime).Hours, TimeSpan.Parse(day.startTime).Minutes) + ",";
                    csvLine += day.date.ToShortDateString() + ",";
                    csvLine += string.Format("{0:00}:{1:00}", TimeSpan.Parse(day.endTime).Hours, TimeSpan.Parse(day.endTime).Minutes) + ",";
                    csvLine += "FALSE,";
                    foreach(string lesson in day.lessons)
                    {
                        csvLine += lesson +" ";
                    }
                    csvLine += ",";
                    csvLine += day.schoolName+",";
                    csvLine += "FALSE";
                    File.AppendAllText("CSV.txt", csvLine + Environment.NewLine);
                }
            }

            Process.Start(@Application.StartupPath, @"/e,/select CSV.txt");
            System.Threading.Thread.Sleep(500);
            Activate();

            if (MessageBox.Show(
            "CSV file saved to: "+ Application.StartupPath + "\\CSV.txt.\n\nImport for Google Calendar?", "Export CSV", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://calendar.google.com/calendar/r/settings/export");
                this.WindowState = FormWindowState.Minimized;
                Clipboard.SetText(Application.StartupPath + "\\CSV.txt");
            }
        }

        lineType getLineType(string line)
        {
            //PRINTED 2018/09/13REG　22 G-KITANIHON           AREA 0060 SENDAIUPDATE 2018/09/12MONTH  2018/09TEACHER 01351142  Chris HaydenSC0101
            string rawValue = readLine(line, "UnicodeString");
            if (line.Contains("BoldSimulation"))
            {
                return lineType.day;
            }
            if (rawValue.Contains(":"))
            {
                return lineType.time;
            }
            if (rawValue.Contains("PRINTED"))
            {
                return lineType.none;
            }
            if (rawValue.Contains("AREA"))
            {
                return lineType.area;
            }
            if (rawValue.Contains("UPDATE"))
            {
                return lineType.update;
            }
            if (rawValue.Contains("MONTH"))
            {
                return lineType.month;
            }
            if (rawValue.Contains("TEACHER"))
            {
                return lineType.teacher;
            }
            return lineType.location;
        }

        enum lineType
        {
            none,
            day,
            time,
            location,
            update,
            teacher,
            area,
            month
        }

        string readLine(string line, string target)
        {
            string returnString;
            int from = line.IndexOf(target) + target.Length + 2;
            int to = line.IndexOf(">") - 3;

            if (from > target.Length + 1 && to > from)
            {
                returnString = line.Substring(from, to - from).Trim();
                return returnString;
            }
            return "";
        }

        private void LoadXPS_Click(object sender, EventArgs e)
        {
            readXPS();
            button1.Visible = false;
        }

        private void CSV_Click(object sender, EventArgs e)
        {
            CreateCSV();
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
