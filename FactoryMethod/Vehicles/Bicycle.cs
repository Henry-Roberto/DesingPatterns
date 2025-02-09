using System;

namespace FactoryMethod
{
    class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros de bicicleta!");
        }

        public void StartRoute()
        {
            Console.WriteLine("Iniciando o trajeto.");
            GetCargo();
        }
    }
}
