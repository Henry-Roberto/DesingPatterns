using System;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 25 km, ventos ok.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordor, voô autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem.");
        }
    }
}
