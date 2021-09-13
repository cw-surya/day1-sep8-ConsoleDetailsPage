using System;

namespace basics
{
    public enum Transmission
    {
        Manual,
        Automatic
    }
    

    public class Car
    {
        // int tmp = 5;

        public float Price { get; set; }
        // private string name;
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public int Kilometer { get; set; }
        public Transmission TransmissionType { get; set; }
        public string Location { get; set; }
        // public string GetName(){
        //     return Name;
        // }
        // public Car(float price, string name, DateTime year, int kilometer, Transmission transmissionType,String location)
        // {
        //     Price = price;
        //     Name = name;
        //     Year = year;
        //     Kilometer = kilometer;
        //     TransmissionType = transmissionType;
        //     Location = location;

        // }

        public override string ToString()
        {
            return $"Car_Name:{Name}, Car_Price:{Price}, Car_Year:{Year.ToShortDateString()}, Kilometer_Travelled:{Kilometer}, Transmission_Type:{TransmissionType.ToString()}, Location:{Location} ";
        }
    }
}
