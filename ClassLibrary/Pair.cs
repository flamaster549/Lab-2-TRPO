using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pair
    {
        private DateTime startTime;
        private DateTime endTime;
        private DateTime breakStartTime;
        private DateTime breakEndTime;
        private WorkShift workShift;
        public Pair(DateTime startTime, DateTime endTime, DateTime breakStartTime, DateTime breakEndTime, WorkShift workShift)
        {
            StartTime = startTime != DateTime.MinValue ? startTime : DateTime.Now;
            EndTime = endTime != DateTime.MinValue ? endTime : DateTime.Now;
            BreakStartTime = breakStartTime != DateTime.MinValue ? breakStartTime : DateTime.Now;
            BreakEndTime = breakEndTime != DateTime.MinValue ? breakEndTime : DateTime.Now;
            WorkShift = workShift;
        }
        public WorkShift WorkShift
        {
            get { return workShift; }
            set { workShift = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public DateTime BreakStartTime
        {
            get { return breakStartTime; }
            set { breakStartTime = value; }
        }
        public DateTime BreakEndTime
        {
            get { return breakEndTime; }
            set { breakEndTime = value; }
        }
    }
}