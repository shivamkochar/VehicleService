using System;
using System.Collections.Generic;

namespace VehicleService
{
    class Program
    {
        static CreateSchedule createSchedule;
        static void Main(string[] args)
        {
            List<Vehicles> vehicle = new List<Vehicles>();
            createSchedule = new CreateSchedule();


            vehicle.Add(new Cars {vVehicleType="Car", vTireDiameter = 5.0f, vColor = "red", vMake = "Honda", vModel = "Civic", vOwnerName = "Rohit", vAccountNumber = "789456123" });
            vehicle.Add(new Cars {vVehicleType = "Car", vTireDiameter = 4.0f, vColor = "blue", vMake = "Hyundai", vModel = "SantaFe", vOwnerName = "Arun", vAccountNumber = "456789123" });
            vehicle.Add(new Cars {vVehicleType = "Car", vTireDiameter = 4.5f, vColor = "black", vMake = "Lexus", vModel = "Rx60", vOwnerName = "Ashish", vAccountNumber = "987123654" });
            vehicle.Add(new Cars {vVehicleType = "Car", vTireDiameter = 5.2f, vColor = "green", vMake = "Audi", vModel = "RS7", vOwnerName = "Shivam", vAccountNumber = "987654123" });
            vehicle.Add(new Cars {vVehicleType = "Car", vTireDiameter = 4.9f, vColor = "neon", vMake = "Tesla", vModel = "Model S", vOwnerName = "Himanshu", vAccountNumber = "147852369" });
            vehicle.Add(new Trucks {vVehicleType = "Truck", vTireDiameter = 8.0f, vColor = "black", vMake = "Tata", vModel = "Garbage", vOwnerName = "Tarun", vAccountNumber = "963258741" });
            vehicle.Add(new Trucks {vVehicleType = "Truck", vTireDiameter = 8.5f, vColor = "blue", vMake = "Honda", vModel = "Tank", vOwnerName = "Gurdeep", vAccountNumber = "852147963" });
            vehicle.Add(new Trucks {vVehicleType = "Truck", vTireDiameter = 7.8f, vColor = "dark blue", vMake = "Suzuki", vModel = "Dump", vOwnerName = "Jatin", vAccountNumber = "778899445" });
            vehicle.Add(new Vans {vVehicleType = "Van", vTireDiameter = 6.0f, vColor = "orange", vMake = "Honda", vModel = "Odyssey", vOwnerName = "Gagan", vAccountNumber = "951753852" });
            vehicle.Add(new Vans {vVehicleType = "Van", vTireDiameter = 6.1f, vColor = "purple", vMake = "Volvo", vModel = "Omni", vOwnerName = "Rishi", vAccountNumber = "159789354" });
 

            Console.WriteLine("Welcome to the Garage :");
           
            bool list = true;

            do {
                Console.WriteLine("Press 1 to List all Vehicles");
                Console.WriteLine("Press 2 to Create a Schedule");
                Console.WriteLine("Press 3 to Display the day's Schedule");
                Console.WriteLine("Press 4 to Exit the Program");
                
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1: // Display the list of vehicles
                            displayVehicle();
                            list = false;
                            break;
                        case 2: // Create a Schedule for the vehicle
                            if (createSchedule.Count < 8)
                            {
                                displayVehicle();

                                Console.WriteLine("Select a Vehicle from 1 to 10 to create a schedule:");
                                int choice = int.Parse(Console.ReadLine());
                                CreateAppointment(choice);
                                list = false;
                            }
                            else
                            {
                                Console.WriteLine("Cannot add more appointments");
                                list = false;
                            }

                            break;
                        case 3: // Display the day's Schedule
                            displayAppointment();
                                list = false;
                            break;
                        case 4: // Exit the program
                            System.Environment.Exit(0);
                            Console.ReadLine();
                            break;
                        default: Console.WriteLine("Please enter the valid input");
                            list = false;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter the valid input");
                    list = false;
                }
            } while (list != true);



            
            void CreateAppointment(int choice)
            {

                Vehicles selection = vehicle[index: choice - 1];

                AppointmentDelegate appointmentDelegate = new AppointmentDelegate(selection);
                Console.WriteLine("Details of selected vehicle : ");
                    selection.display();

                bool operation = true;
                do
                {
                   
                    Console.WriteLine("Choose the Operation you want to perform on this vehicle");
                    Console.WriteLine("1. Tire Change");
                    Console.WriteLine("2. Oil Change");
                    Console.WriteLine("3. Diagnosis");
                    Console.WriteLine("4. Engine Tune-up");
                    Console.WriteLine("5. Brake Replacement");
                    Console.WriteLine("6. Additional operation");
                    
                    try
                    { 
                    int operations = int.Parse(Console.ReadLine());
                    
                    switch(operations)
                    {
                        case 1:
                            appointmentDelegate.MyCreateAppointment += selection.TireChange;
                                operation = true;

                            break;
                        case 2:
                            appointmentDelegate.MyCreateAppointment += selection.TireChange;
                                operation = true;
                                break;
                        case 3:
                            appointmentDelegate.MyCreateAppointment += selection.TireChange;
                                operation = true;
                                break;
                        case 4:
                            appointmentDelegate.MyCreateAppointment += selection.TireChange;
                                operation = true;
                                break;
                        case 5:
                            appointmentDelegate.MyCreateAppointment += selection.TireChange;
                                operation = true;
                                break;
                        case 6: appointmentDelegate.MyCreateAppointment += selection.Generic;
                                operation = true;
                                break;
                        default: Console.WriteLine("Choose the correct operation");
                                operation = false;
                                break;

                    }
                    createSchedule.Add(appointmentDelegate);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter the correct input");
                        operation = false;
                    }
                } while (operation != true);

        
            }

            void displayVehicle()
            {
                int i = 0;
                foreach (Vehicles aVehicle in vehicle)
                {
                    i++;
                    Console.WriteLine("Vehicle number is: " + i);
                    aVehicle.display();
                }
            }

            void displayAppointment()
            {
               
                for(int i=0; i<createSchedule.Count; i++)
                {
                    createSchedule[i].Vehicle.display();
                    createSchedule[i].MyCreateAppointment();
                }
            }

            Console.ReadLine();
        }
    }

}
