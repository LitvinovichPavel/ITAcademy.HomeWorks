using System;
using System.Collections.Generic;
using System.Text;

namespace hm_12
{
    class Motorcycle
    {
        static int _counter;
        int Id { get; set; }
        string Name { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        int Odometer { get; set; }
        public Motorcycle()
        {
            _counter++;
            Logger.Log.Info($"Created a Motorcycle Number {_counter}");
        }
        public static Motorcycle CreateMotorcycle(string name, string model, int year, int odometer)
        {
            Motorcycle moto = new Motorcycle();
            moto.Id = _counter;
            moto.Name = name;
            moto.Model = model;
            moto.Year = year;
            moto.Odometer = odometer;
            Logger.Log.Info($"Motorcycle Number {_counter} is {moto.Name} - " +
                            $"{moto.Model} from {moto.Year} with {moto.Odometer}km on Odometer");
            return moto;
        }
        public static Motorcycle DeleteMotorcycle(ref Motorcycle moto)
        {
            Logger.Log.Info($"Motorcycle Number {_counter} deleted");
            moto = null;
            return moto;
        }
        public static void GetMotorcycles(Motorcycle moto)
        {
            if (moto != null)
            {
                Console.WriteLine($"ID - {moto.Id};\nName - {moto.Name};\n" +
                    $"Model - {moto.Model};\nYear - {moto.Year};\nOdometer - {moto.Odometer}\n");
                Logger.Log.Info($"Inputing motorcycle No.{_counter} on console.");
            }
            else Console.WriteLine("Motorcycle not set or deleted\n");
        }
        public static Motorcycle UpdateMotorcycle(Motorcycle moto, int addedKM)
        {
            moto.Odometer += addedKM;
            Logger.Log.Info($"In Moto No.{_counter} changed Odometer to {moto.Odometer}");
            return moto;
        }
        public static void GetMotorcycleById(Motorcycle[] motos, int ID)
        {
            Logger.Log.Info($"Trying to find Motorcycle with ID - {ID}");
            Motorcycle comparedMoto = null;
            for (int i = 0; i < motos.Length; i++)
            {
                if (motos[i] != null && motos[i].Id == ID)
                {
                    Logger.Log.Info($"Successful");
                    comparedMoto = motos[i];
                    GetMotorcycles(motos[i]);
                }
            }
            if (comparedMoto == null)
            {
                Logger.Log.Info($"Search Failed");
                Console.WriteLine("Not found. Perhaps, specified ID don't exist");
            }
        }
    }
}
