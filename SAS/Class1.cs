using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS
{
    public class WorkDay
    {
        DateTime date;
        string startTime;
        string endTime;
        decimal workTime;
        string location;
        string cost;

        public WorkDay(DateTime date, string startTime, string endTime, decimal workTime, string location, string cost)
        {
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.workTime = workTime;
            this.location = location;
            this.cost = cost;
        }
    }
}
