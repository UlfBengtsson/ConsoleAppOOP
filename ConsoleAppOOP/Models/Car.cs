using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP.Models
{
    public class Car
    {
        private static int carCounter = 1;

        public int Id { get; private set; }
        private string brand;
        private string modelName;
        private string regPlate;
        public string RegPlate
        {
            get
            {
                return regPlate;
            }
            set
            {
                if (value.Length == 6)
                {
                    regPlate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Reg.Plate", "6 symbols on reg.plate only");
                }
            }
        }
        private int wheels;

        public Car(string brand, string model, string regPlate)
        {
            Id = carCounter++;
            wheels = 4;

            this.brand = brand;
            modelName = model;
            RegPlate = regPlate;// use our filter
        }

        public string Info()
        {
            return $"Car Id: {Id}\nBrand: {brand}\nModel: {modelName}\nReg.Plate: {RegPlate}";
        }

        public override string ToString()
        {
            return $"{Id}: {brand} {modelName}";
        }
    }
}
