using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleService
{
    public class Vehicles
    {
            public float vTireDiameter;
            public string vColor;
            public string vMake;
            public string vModel;
            public string vOwnerName;
            public string vAccountNumber;// The account number should be displayed with the first six numbers replaced by Xs.
            public string vVehicleType;

            public Vehicles()
            {
                vTireDiameter = 0.0f;
                vColor = string.Empty;
                vMake = string.Empty;
                vModel = string.Empty;
                vOwnerName = string.Empty;
                vAccountNumber = string.Empty;
                vVehicleType = string.Empty;
            }

            public string AccountNumber(string accountValue)
            {
            return accountValue.Remove(0, 6).Insert(0, "xxxxxx");
            }
            public Vehicles(float tireDiameter, string color, string make, string model, string ownerName, string accountNumber)
            {
                vTireDiameter = tireDiameter;
                vColor = color;
                vMake = make;
                vModel = model;
                vOwnerName = ownerName;
                vAccountNumber = accountNumber;
            }

            public void display()
            {
                Console.WriteLine("Vehicle Type :" + vVehicleType);
                Console.WriteLine("Tire Diameter :"+ vTireDiameter);
                Console.WriteLine("Color :"+ vColor);
                Console.WriteLine("Make :"+ vMake);
                Console.WriteLine("Model :"+ vModel);
                Console.WriteLine("Owner Name :"+ vOwnerName);
                Console.WriteLine("Account Number :"+ AccountNumber(vAccountNumber));
                Console.WriteLine("--------------------------------------\n");
           
            }
            public void TireChange()
            {
                Console.WriteLine("The TireChange was performed \n------------------------------------");
            }

            public void OilChange()
            {
                Console.WriteLine("The Oil Change was performed \n------------------------------------");
            }

            public void Diagnosis()
            {
                Console.WriteLine("The Diagnosis was performed\n--------------------------------------");
            }

            public void EngineTuneUp()
            {
                Console.WriteLine("The Engine Tune Up was performed\n----------------------------------");
            }

            public void BrakeReplace()
            {
                Console.WriteLine("The Brake Replace was performed\n-----------------------------------");
            }

            public virtual void Generic()
            {
                
            }


    }
    }

