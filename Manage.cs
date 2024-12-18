using System;
using System.Collections.Generic;

namespace TPfinalC
{
    class Manage
    {
        List<Voiture> cars = new List<Voiture>();

        public void AddCar(Voiture car)
        {
            cars.Add(car);
        }

        public int GetID()
        {
            return cars.Count;
        }

        public void ListCar()
        {
            foreach (var car in cars)
            {
                car.AfficherVoiture();
            }
        }

        public void LocationCar()
        {

        }

        public void ReturnCar()
        {

        }
    }
}