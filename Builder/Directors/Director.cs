using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    class Director
    {
        IBuilder builder;

        public Director(IBuilder builder) 
        { 
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicleType(Components.VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(Components.VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
        }

        public void ConstructSUV()
        {
            builder.SetVehicleType(Components.VehicleType.SUV);
            builder.SetEngine(new Engine(3000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.SEMI_AUTOMATIC);
            builder.SetAirBags(new Airbag());
        }
    }
}
