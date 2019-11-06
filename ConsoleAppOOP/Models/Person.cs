using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP.Models
{
    class Person
    {
        private static int idCounter = 0;
        public int Id { get; private set; }
        public string Name { get; set; }

        private List<Car> carsOwned;

        public Person(string name)
        {
            Id = ++idCounter;
            Name = name;
        }

        public void AddCar(Car car)
        {
            carsOwned.Add(car);
        }

        public bool RemoveCar(int id)
        {
            foreach (Car aCar in carsOwned)
            {
                if (aCar.Id == id)
                {
                    carsOwned.Remove(aCar);
                    return true;
                }
            }
            return false;
        }
    }
}
