using System;

namespace Abstraction
{
        public class Laptop
        {
            private string brand;
            private string model;
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            public void LaptopDetails()
            {
                Console.WriteLine("Brand: " + Brand);
                Console.WriteLine("Model: " + Model);
            }
            private void MotherBoardInfo()
            {
                Console.WriteLine("MotheBoard Information");
            }

        static void Main(string[] args)
        {
            Laptop obj = new Laptop();
            obj.Brand = "Lenovo";
            obj.Model = "ThinkPad E15";
            obj.LaptopDetails();
            obj.MotherBoardInfo();

        }
    }    
}