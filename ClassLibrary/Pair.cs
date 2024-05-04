using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   internal class Pair
    {
        private DateTime startTime;
        private DateTime endTime;
        private DateTime breakStartTime;
        private DateTime breakEndTime;
        private WorkShift workShift;
        public Pair(DateTime startTime1, DateTime endTime1, DateTime breakStartTime1, DateTime breakEndTime1, WorkShift workShift1)
        {
            startTime = startTime1 != DateTime.MinValue ? startTime1 : DateTime.Now;
            endTime = endTime1 != DateTime.MinValue ? endTime1 : DateTime.Now;
            breakStartTime = breakStartTime != DateTime.MinValue ? breakStartTime : DateTime.Now;
            breakEndTime = breakEndTime1 != DateTime.MinValue ? breakEndTime1 : DateTime.Now;
            workShift = workShift1;
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
