using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleService
{
     public delegate void CreateAppointment();
    public class AppointmentDelegate
    {
        private Vehicles vehicle;
        private CreateAppointment createAppointment;

      //  public Vehicles GetVehicles()
        //{
          //  return vehicle;
       // }
       // public void SetVehicle(Vehicles vehicleChoice)
        //{
          //  vehicle = vehicleChoice;
        //}



        public AppointmentDelegate()
        {
            vehicle = null;
            createAppointment = null;
        }

        public CreateAppointment MyCreateAppointment
        {
            get => createAppointment;
            set => createAppointment = value;
        }

        public Vehicles Vehicle
        {
            get => vehicle;
            set => vehicle = value;
        }
        public AppointmentDelegate(Vehicles vehicle)
        {
            this.vehicle = vehicle;
            createAppointment = null;
        }
    }
}
