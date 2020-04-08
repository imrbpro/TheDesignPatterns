using Adapter;
using DesignPatterns.CreationalPatterns.Factory;
using DesignPatterns.CreationalPatterns.Factory.implementation;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        #region for adapter pattern 
        IJsonConvert _convert;
        public Program()
        {
            _convert = new AdapterClass();
        }
        #endregion
        static void Main(string[] args)
        {
            #region Creational Patterns Calling
            #region Singleton
            //SingletonDemo SingletonObject = SingletonDemo.GetObject();
            //SingletonObject.Print("Hello World");

            //SingletonDemo SingletonObject1 = SingletonDemo.GetObject();
            //SingletonObject1.Print("HELLO DUNYA");

            //SingletonDemo SingletonObject2 = SingletonDemo.GetObject();
            //SingletonObject2.Print("HELLO");

            //Console.ReadLine();
            #endregion
            #region Factory
            //Console.WriteLine("Enter Vehicle type");
            //string vehicletype = Console.ReadLine();
            //IVehicle vehicle = GetVehicle(vehicletype);
            //vehicle.start();
            //vehicle.stop();
            //Console.ReadKey();
            //IVehicle GetVehicle(string vehicleName)
            //{
            //    switch (vehicleName)
            //    {
            //        case "Car":
            //            return new Car();
            //        case "Truck":
            //            return new Truck();
            //        default:
            //            throw new Exception("No such vehicle found");
            //    }
            //}
            #endregion
            #endregion
            #region Structural Patterns Calling
            #region Decorator 
            ////Step 1: Define some dishes, and how many of each we can make
            //FreshSalad caesarSalad = new FreshSalad("Crisp romaine lettuce", "Freshly-grated Parmesan cheese", "House-made Caesar dressing");
            //caesarSalad.Display();

            //Pasta fettuccineAlfredo = new Pasta("Fresh-made daily pasta", "Creamly garlic alfredo sauce");
            //fettuccineAlfredo.Display();

            //Console.WriteLine("\nMaking these dishes available.");

            ////Step 2: Decorate the dishes; now if we attempt to order them once we're out of ingredients, we can notify the customer
            //Available caesarAvailable = new Available(caesarSalad, 3);
            //Available alfredoAvailable = new Available(fettuccineAlfredo, 4);

            ////Step 3: Order a bunch of dishes
            //caesarAvailable.OrderItem("John");
            //caesarAvailable.OrderItem("Sally");
            //caesarAvailable.OrderItem("Manush");

            //alfredoAvailable.OrderItem("Sally");
            //alfredoAvailable.OrderItem("Francis");
            //alfredoAvailable.OrderItem("Venkat");
            //alfredoAvailable.OrderItem("Diana");
            //alfredoAvailable.OrderItem("Dennis"); //There won't be enough for this order.

            //caesarAvailable.Display();
            //alfredoAvailable.Display();

            //Console.ReadKey();
            #endregion
            #region Adapter
            Program p = new Program();
            p.getJson();
            Console.Read();
            #endregion
            #endregion
           
        }
        //for adapter pattern
        public void getJson()
        {
            Console.WriteLine(_convert.ConvertToJson(AdapteeClass.xmls));
        }
    }
}
