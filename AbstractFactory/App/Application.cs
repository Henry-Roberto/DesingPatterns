using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.App
{
    class Application
    {
        private ILandvehicle landvehicle;
        private IAircraft aircraft;

        public Application(ITransportFactory factory)
        {
            landvehicle = factory.CreateTransportVehicle();
            aircraft = factory.CreateTransportAircraft();
        }

        public void StartRoute()
        {
            aircraft.StartRoute();
            landvehicle.StartRoute();
        }
    }
}
