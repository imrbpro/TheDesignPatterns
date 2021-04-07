using Adapter;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.CreationalPatterns.Factory;
using DesignPatterns.CreationalPatterns.Factory.Implementation;
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
            IPaymentCard card = null;
            Console.WriteLine("Please Select your card type");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "debit":
                    card = new DebitCard();
                    PrintCardDetails(card);
                    break;
                case "gold":
                    card = new GoldCard();
                    PrintCardDetails(card);
                    break;
                case "platinum":
                    card = new PlatinumCard();
                    PrintCardDetails(card);
                    break;
                default:
                    card = null;
                    PrintCardDetails(card);
                    break;
            }

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
            //Program p = new Program();
            //p.getJson();
            //Console.Read();
            #endregion
            #endregion
            #region Behavioral Patterns Calling
            #region Chain Of Responsibility
            // Setup Chain of Responsibility

            //Approver Waqas = new Director();
            //Approver Azeem = new VicePresident();
            //Approver Raheel = new President();

            //Waqas.SetSuccessor(Azeem);
            //Azeem.SetSuccessor(Raheel);

            //// Generate and process purchase requests

            //Purchase pr = new Purchase(2034, 350.00, "Assets");
            //Waqas.ProcessRequest(pr);

            //pr = new Purchase(2035, 32590.10, "Servers");
            //Waqas.ProcessRequest(pr);

            //pr = new Purchase(2036, 122100.00, "Property");
            //Waqas.ProcessRequest(pr);

            //// Wait for user

            //Console.ReadKey();
            #endregion
            #endregion

        }
        public static void PrintCardDetails(IPaymentCard card)
        {
            if (card != null)
            {
                Console.WriteLine("Card Type is : " + card.GetCardType());
                Console.WriteLine("Card Expiry is : " + card.Validity());
                Console.WriteLine("Card Annual Renewal Charges are  : " + card.AnnualCharges());
                Console.WriteLine("Card Limit is  : " + card.CardLimit());
            }
            else
            {
                Console.WriteLine("Invalid Card Type...");
            }
            Console.Read();
        }
        //for adapter pattern
        public void getJson()
        {
            Console.WriteLine(_convert.ConvertToJson(AdapteeClass.xmls));
        }
    }
}
