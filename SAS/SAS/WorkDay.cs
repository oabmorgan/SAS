using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS
{
    public class WorkDay
    {
        public DateTime date;
        public string startTime;
        public string endTime;
        public decimal workTime;
        public string schoolNumber;
        public string schoolName;
        public string cost;

        public WorkDay(int day)
        {
            this.date = new DateTime(2018, 10, day);
            this.startTime = "";
            this.endTime = "";
            this.workTime = 0;
            this.schoolName = "";
            this.schoolNumber = "";
            this.cost = "";
        }

        public WorkDay(DateTime date, string startTime, string endTime, decimal workTime, string schoolName, string schoolNumber, string cost)
        {
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.workTime = workTime;
            this.schoolName = schoolName;
            this.schoolNumber = schoolNumber;
            this.cost = cost;
        }
    }
}
