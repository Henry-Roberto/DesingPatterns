﻿using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();
            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine($"Criando um veículo do tipo: {sedan.VehicleType}");

            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();
            Console.WriteLine($"Criando um veículo do tipo: {truck.VehicleType}");

            director.ConstructSUV();
            Vehicle suv = builder.GetVehicle();
            Console.WriteLine($"Criando um veículo do tipo: {suv.VehicleType}");


            Console.ReadLine();
        }
    }
}
