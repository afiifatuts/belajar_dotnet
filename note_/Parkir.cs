// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace FundamentalUpskilling;

// public class ParkingLot
// {
//     public string Name { get; set; }
//     public int Capacity { get; set; }
//     public List<Vehicle> ParkedVehicles { get; set; }

//     public ParkingLot(string name, int capacity)
//     {
//         Name = name;
//         Capacity = capacity;
//         ParkedVehicles = new List<Vehicle>();
//     }

//     public bool IsFull()
//     {
//         return ParkedVehicles.Count >= Capacity;
//     }

//     public void ParkVehicle(Vehicle vehicle)
//     {
//         if (IsFull())
//         {
//             Console.WriteLine("Parking lot is full. Cannot park the vehicle.");
//         }
//         else
//         {
//             ParkedVehicles.Add(vehicle);
//             Console.WriteLine("Vehicle parked successfully.");
//         }
//     }

//     public void RemoveVehicle(Vehicle vehicle)
//     {
//         if (ParkedVehicles.Contains(vehicle))
//         {
//             ParkedVehicles.Remove(vehicle);
//             Console.WriteLine("Vehicle removed from the parking lot.");
//         }
//         else
//         {
//             Console.WriteLine("The vehicle is not parked in this parking lot.");
//         }
//     }
// }

// public class Vehicle
// {
//     public string LicensePlate { get; set; }
//     public string Make { get; set; }
//     public string Model { get; set; }
//     public int Year { get; set; }

//     public Vehicle(string licensePlate, string make, string model, int year)
//     {
//         LicensePlate = licensePlate;
//         Make = make;
//         Model = model;
//         Year = year;
//     }

//     public void DisplayInfo()
//     {
//         Console.WriteLine($"License Plate: {LicensePlate}");
//         Console.WriteLine($"Make: {Make}");
//         Console.WriteLine($"Model: {Model}");
//         Console.WriteLine($"Year: {Year}");
//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         int parkingLotSize = 0;
//         List<ParkingLot> parkingLots = new List<ParkingLot>();
//         List<Vehicle> parkedVehicles = new List<Vehicle>();

//         while (true)
//         {
//             string input = Console.ReadLine();
//             string[] command = input.Split(" ");

//             switch (command[0])
//             {
//                 case "create_parking_lot":
//                     parkingLotSize = int.Parse(command[1]);
//                     for (int i = 1; i <= parkingLotSize; i++)
//                     {
//                         parkingLots.Add(new ParkingLot(i));
//                     }
//                     Console.WriteLine($"Created a parking lot with {parkingLotSize} slots");
//                     break;

//                 case "park":
//                     if (parkingLotSize == 0)
//                     {
//                         Console.WriteLine("Please create a parking lot first");
//                         break;
//                     }

//                     if (parkedVehicles.Count == parkingLotSize)
//                     {
//                         Console.WriteLine("Sorry, parking lot is full");
//                         break;
//                     }

//                     string registrationNumber = command[1];
//                     string color = command[3];
//                     string type = command[2];
//                     Vehicle vehicle = new Vehicle(registrationNumber, color, type);

//                     ParkingLot availableParkingLot = parkingLots.Where(lot => lot.Vehicle == null).FirstOrDefault();
//                     if (availableParkingLot == null)
//                     {
//                         Console.WriteLine("Sorry, parking lot is full");
//                         break;
//                     }

//                     availableParkingLot.Vehicle = vehicle;
//                     parkedVehicles.Add(vehicle);
//                     Console.WriteLine($"Allocated slot number: {availableParkingLot.Number}");
//                     break;

//                 case "leave":
//                     int slotNumber = int.Parse(command[1]);
//                     ParkingLot parkingLot = parkingLots.FirstOrDefault(lot => lot.Number == slotNumber);
//                     if (parkingLot == null)
//                     {
//                         Console.WriteLine($"Slot number {slotNumber} not found");
//                         break;
//                     }

//                     if (parkingLot.Vehicle == null)
//                     {
//                         Console.WriteLine($"Slot number {slotNumber} is already empty");
//                         break;
//                     }

//                     Vehicle leavingVehicle = parkingLot.Vehicle;
//                     parkedVehicles.Remove(leavingVehicle);
//                     parkingLot.Vehicle = null;
//                     Console.WriteLine($"Slot number {slotNumber} is free");
//                     break;

//                 case "status":
//                     Console.WriteLine("Slot No.  Registration No    Colour      Type");
//                     foreach (ParkingLot lot in parkingLots)
//                     {
//                         if (lot.Vehicle != null)
//                         {
//                             Console.WriteLine($"{lot.Number}        {lot.Vehicle.RegistrationNumber}      {lot.Vehicle.Color}      {lot.Vehicle.Type}");
//                         }
//                     }
//                     break;

//                 case "registration_numbers_for_vehicles_with_colour":
//                     string colorToSearch = command[1];
//                     List<string> registrationNumbersWithColor = parkedVehicles.Where(vehicle => vehicle.Color == colorToSearch)
//                         .Select(vehicle => vehicle.RegistrationNumber).ToList();
//                     Console.WriteLine(string.Join(", ", registrationNumbersWithColor));
//                     break;

//                 case "slot_numbers_for_vehicles_with_colour":
//                     string colorToSearch2 = command[1];
//                     List<int> slotNumbersWithColor = parkingLots.Where(lot => lot.Vehicle != null && lot.Vehicle.Color == colorToSearch2)
//                         .Select(lot => lot.Number).ToList();
//                     Console.WriteLine(string.Join(", ", slotNumbersWithColor));
//                     break;

//                 case "slot_number_for_registration_number":
//                     string registrationNumberToSearch = command[1];
//                     ParkingLot parkingLotWithVehicle = parkingLots.FirstOrDefault(lot => lot.Vehicle != null && lot.Vehicle.RegistrationNumber == registrationNumberToSearch);
//                     if (parkingLotWithVehicle == null)
//                     {
//                         Console.WriteLine($"Registration number {registrationNumberToSearch} not found");
//                     }
//                     else
//                     {
//                         Console.WriteLine(parkingLotWithVehicle.Number.ToString());
//                     }
//                     break;
//             }
//         }
//     }
// }
