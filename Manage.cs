using System;
using System.Collections.Generic;

namespace TP_final_C_;

class Manage
{
    List<Car> cars = new List<Car>();
    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void ListCar()
    {
        foreach (var car in cars)
        {
            Console.WriteLine($"Marque: {car.Marque}, Modèle: {car.Model}");
        }
    }

    public void LocationCar()
    {

    }

    public void ReturnCar()
    {

    }
}

class Car
{
    public string Model { get; set;}
    public string Marque { get; set;}

    public Car(string model, string marque)
    {
        Model = model;
        Marque = marque;
    }
}