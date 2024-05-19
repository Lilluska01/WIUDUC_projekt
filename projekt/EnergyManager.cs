using System;
using System.Collections.Generic;
using System.Linq;

namespace projekt
{
    public class EnergyManager
    {
        private List<EnergyConsumption> _energyData;

        public EnergyManager(List<EnergyConsumption> energyData)
        {
            _energyData = energyData;
        }

        public void AddEnergyData()
        {
            Console.Write("Üss be egy dátumot (yyyy-mm-dd): ");
            var date = DateTime.Parse(Console.ReadLine());
            Console.Write("Elfogyasztott energia a megadott dátumon (kWh): ");
            var amount = double.Parse(Console.ReadLine());

            _energyData.Add(new EnergyConsumption { Date = date, Amount = amount });
            Console.WriteLine("Adat hozzáadva.");
            Console.WriteLine();
        }

        public void ViewStatistics()
        {
            if (_energyData.Count == 0)
            {
                Console.WriteLine("Nincs elérhető adat.");
                Console.WriteLine();
                return;
            }

            var totalConsumption = _energyData.Sum(e => e.Amount);
            var averageConsumption = _energyData.Average(e => e.Amount);
            var maxConsumption = _energyData.Max(e => e.Amount);
            var minConsumption = _energyData.Min(e => e.Amount);

            Console.WriteLine($"Teljes fogyasztás: {totalConsumption} kWh");
            Console.WriteLine($"Átlag napi fogyasztás: {averageConsumption} kWh");
            Console.WriteLine($"Legtöbb napi fogyasztás: {maxConsumption} kWh");
            Console.WriteLine($"Legkevesebb napi fogyasztás: {minConsumption} kWh");
            Console.WriteLine();
        }

        public void GetEnergySavingTips()
        {
            if (_energyData.Count == 0)
            {
                Console.WriteLine("Nincs elérhető adat.");
                Console.WriteLine();
                return;
            }

            var averageConsumption = _energyData.Average(e => e.Amount);
            Console.WriteLine("Energiatakarékossági tippek:");
            if (averageConsumption > 30)
            {
                Console.WriteLine("1. Fontold meg az energia takarékos eszközök vásárlását.");
                Console.WriteLine("2. Kapcsold le a lámpákat és kapcsold ki a vezetékes, elektromos eszközeidet amikor nem használod őket.");
            }
            else
            {
                Console.WriteLine("1. Jól csinálod! Csak így tovább!");
                Console.WriteLine("2. Tartsad figyelemmel a további napi energiafogyasztásod.");
            }
            Console.WriteLine(); 
        }
    }
}
