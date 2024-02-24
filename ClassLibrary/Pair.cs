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
        //private OtherClass otherClass;

        public Pair(DateTime startTime, DateTime endTime, DateTime breakStartTime, DateTime breakEndTime, string shiftLink)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.breakStartTime = breakStartTime;
            this.breakEndTime = breakEndTime;
            //this.otherClass = new OtherClass(shiftLink);
        }
    }
}
