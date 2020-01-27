using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleService
{
    public class CreateSchedule
    {
        private List<AppointmentDelegate> scheduleList = null;

        public CreateSchedule()
        {
            scheduleList = new List<AppointmentDelegate>();
        }
        

        public void Add(AppointmentDelegate t)
        {
            scheduleList.Add(t);
        }

        public int Count
        {
            get { return scheduleList.Count; }
        }
        
        public AppointmentDelegate this[int i]
        {
            get { return scheduleList[i]; }
            set { scheduleList[i] = value; }

        }

    }
}
