using System;
using System.Collections.Generic;

namespace projekt
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var energyData = new List<EnergyConsumption>();
            var energyManager = new EnergyManager(energyData);
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Energiafogyasztás hozzáadása.");
                Console.WriteLine("2. Energiafogyasztási statisztikák megnézése");
                Console.WriteLine("3. Energiatakarékossági tippek");
                Console.WriteLine("4. Kilépés");
                Console.Write("Válassz egy opciót: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        energyManager.AddEnergyData();
                        break;
                    case "2":
                        energyManager.ViewStatistics();
                        break;
                    case "3":
                        energyManager.GetEnergySavingTips();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Érvénytelen opció. Kérlek próbáld újra.");
                        break;
                }
            }
        }
    }
}
