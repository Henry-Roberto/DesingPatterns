using FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Transport transport = null;

            if (args.Length == 0)
            {
                Console.WriteLine("Selecione o tipo da entrega.");
                Console.ReadLine();
                return;
            }

            string arg = args[0];

            switch (arg)
            {
                case "--uber":
                    transport = new CarTransport();
                    break;
                case "--log":
                    transport = new MotorcycleTransport();
                    break;
                case "--eats":
                    transport = new BicycleTransport();
                    break;
                default:
                    Console.WriteLine("Selecione o tipo da entrega.");
                    break;
            }

            if (transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadLine();


        }
    }
}
