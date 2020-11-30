using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelAndAsync
{
    class Program
    {
        static void Main1()
        {
            // // Multi Threading
            // Thread thread = new Thread();

            // // TPL - Task Parallel Library
            int[] numbers = { 34, 43, 8, 23, 7, 8, 324, 673, 235, 798, 65 };

            Stopwatch stopwatch = new Stopwatch();

            // Sequential
            stopwatch.Start();
            foreach (var num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"Time taken (Sequential): {stopwatch.ElapsedMilliseconds}ms");

            // 
            stopwatch.Restart();
            Parallel.ForEach(numbers, num =>
            {
                Compute(num);

            });
            Console.WriteLine($"Time taken (Parallel): {stopwatch.ElapsedMilliseconds}ms");


        }



        static void Compute(int x)
        {
            Task.Delay(100);
            Console.WriteLine($"Computed for {x}");
        }

        static async Task Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Task turnOnBurner1 = TurnOnBurner();
            Task putOnKettle = PutOn("Kettle");
            Task addWater = Add("Water");
            Task boilWater = Boil("Water");
            Task grindTeaMasala = GrindTeaMasala();
            Task addSugar = Add("Sugar");
            Task addMasala = Add("Masala");
            Task addMilk = Add("Milk");
            Task boilMilk = Boil("Milk");
            Task turnOnBurner2 = TurnOnBurner();
            Task putOnPan = PutOn("Pan");
            Task addOil = Add("Oil");
            Task crackEggsAndStir = CrackAndStirEggs();
            Task fryEggs = FryEggs();
            Task serve = Serve();

            await turnOnBurner1;
            Console.WriteLine("Burner1 turned on");

            await putOnKettle;
            Console.WriteLine("Put Kettle on Burner");

            await addWater;
            Console.WriteLine("Added Water on Kettle");

            await boilWater;
            Console.WriteLine("Water Boiled");

            await grindTeaMasala;
            Console.WriteLine("Grinded Tea Masala");

            await addSugar;
            Console.WriteLine("Sugar Added");

            await addMasala;
            Console.WriteLine("Masala Added");

            await addMilk;
            Console.WriteLine("Milk Added");

            await boilMilk;
            Console.WriteLine("Milk Boiled");

            await turnOnBurner2;
            Console.WriteLine("Burner2 turned on");

            await putOnPan;
            Console.WriteLine("Put Pan on Burner");

            await addOil; ;
            Console.WriteLine("Added Oil");

            await crackEggsAndStir;
            Console.WriteLine("Cracked and stirred eggs");

            await fryEggs;

            Console.WriteLine("Eggs Fried");

            await serve;
            Console.WriteLine(" Breakfast Served");

             Console.WriteLine($"Time taken (Parallel): {sw.ElapsedMilliseconds}ms");

        }
        static void Main2()
        {
            // Making Breakfast

            // Make Tea
            // Turn on Burner(2s)
            // Put on kettle(1s)
            // Add water (2s)
            // Boil it(3 min)
            // Grind tea masala(10s)
            // Add sugar and masalas(2s)
            // Add Milk(2s)
            // Boil it(2min)

            // Fry eggs
            // Turn on Burner(2s)
            // Put on pan(1s)
            // Add oil (2s)
            // Crack eggs stir it(2 min)
            // Fry it(10s)

            // Everything ready Serve it

            // Sequential
            TurnOnBurner();
            Console.WriteLine("Burner1 turned on");

            PutOn("Kettle");
            Console.WriteLine("Put Kettle on Burner");

            Add("Water");
            Console.WriteLine("Added Water on Kettle");

            Boil("Water");
            Console.WriteLine("Water Boiled");

            GrindTeaMasala();
            Console.WriteLine("Grinded Tea Masala");

            Add("Sugar");
            Console.WriteLine("Sugar and masala added");

            Add("Masala");
            Console.WriteLine("Masala Added");

            Add("Milk");
            Console.WriteLine("Milk Added");

            Boil("Milk");
            Console.WriteLine("Milk Boiled");

            TurnOnBurner();
            Console.WriteLine("Burner2 turned on");

            PutOn("Pan");
            Console.WriteLine("Put Pan on Burner");

            Add("Oil");
            Console.WriteLine("Added Oil");

            CrackAndStirEggs();
            Console.WriteLine("Cracked and stirred eggs");

            FryEggs();

            Console.WriteLine("Eggs Fried");

            Serve();
            Console.WriteLine(" Breakfast Served");





        }

        private static async Task PutOn(string pot)
        {
            await Task.Delay(2000);
        }

        private static async Task TurnOnBurner()
        {
            await Task.Delay(2000);
        }
        private static async Task Add(string item)
        {
            await Task.Delay(2000);
        }

        private static async Task Boil(string item)
        {
            await Task.Delay(10000);
        }

        private static async Task GrindTeaMasala()
        {
            await Task.Delay(10000);
        }

        private static async Task CrackAndStirEggs()
        {
            await Task.Delay(10000);
        }

        private static async Task FryEggs()
        {
            await Task.Delay(10000);
        }

        private static async Task Serve()
        {
            await Task.Delay(5000);
        }
    }
}
