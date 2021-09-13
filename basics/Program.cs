using System;
using System.Collections.Generic;

namespace basics
{
    class Program
    {

        // static 
        // static 


        static void Main(string[] args)
        {
            List<Car> usedCars = new List<Car>();
            List<FAQ> faqList = new List<FAQ>();
            // Console.WriteLine("Hello World!");
            // adding cars to usedCars list
            float price = 3.1f;
            string name = "CarName";
            int totalCars = 5;
            // forEach(Car car )
            // replace by foreach
            for (int i = 0; i < totalCars; i++)
            {
                Car newCar = new Car(){ Price = price + i, Name =  name + i.ToString(), Year = new DateTime(2011 + i, i + 1, i + 1), Kilometer = (i + 1) * 1000,TransmissionType = i % 2 == 0 ? Transmission.Manual : Transmission.Automatic, Location = "india"} ;

                usedCars.Add(newCar);
            }
            faqList.Add(new FAQ("What is 7 day moneyback guarantee?", "7 Day Moneyback guarantee is a peace of mind proposition given to buyers who purchase abSure certified cars. Post vehicle delivery, if at any point of time you feel to return the car, you can do it within 7 days of the delivery of the car. You will get 100% money refund no quetions asked. 7 Day Moneyback guarantee policy requires certain conditions to hold true at the time of placing a return request"));
            faqList.Add(new FAQ("Is 7 day moneyback guarantee applicable on all cars?", "No. 7 Day Money Back guarantee is applicable only on CarWale abSure certified cars. These cars are certified by our inhouse expert evaluators who have thorough knowledge about car certification. Also, this offer is not available if you are availing for an auto loan to buy the car. It is only available if you make outright full payment for the car."));
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1. ListAllCars 2.ViewCarDetail 3.ListAll FAQs 4. Exit");

                int optnSelected = Convert.ToInt16(Console.ReadLine());
                switch (optnSelected)
                {
                    case 1:
                        for (int i = 0; i < totalCars; i++)
                        {
                            Console.WriteLine(usedCars[i].Name);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the Car Name to show it's details.");
                        string carName = Console.ReadLine();
                        bool isCarFount = false;
                        for (int i = 0; i < totalCars; i++)
                        {
                            if (carName == usedCars[i].Name)
                            {
                                Console.WriteLine(usedCars[i].ToString());
                                isCarFount = true;
                                break;
                            }
                        }
                        if (!isCarFount)
                        {
                            Console.WriteLine("Car Not Fount");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine(faqList[i].Question);
                        }
                        Console.WriteLine("Enter FAQ number to see its answer");
                        int faqNumber = Convert.ToInt16(Console.ReadLine());
                        faqNumber -= 1;
                        if (faqNumber > -1 && faqNumber < 2)
                        {
                            Console.WriteLine(faqList[faqNumber].Question);
                            Console.WriteLine(faqList[faqNumber].Answer);
                        }
                        else
                        {
                            Console.WriteLine("No FAQ exists with the number you entered");
                        }
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter a Correct Value");
                        break;
                }
                if (optnSelected == 1)
                {

                }
            }
            // for (int i = 0; i < 5; i++)
            // {

            //     Console.WriteLine(usedCars[i].ToString());
            // }
        }

        // Why I am not able to access Name property of car object
        // public void PrintCarDetails(Car car)
        // {
        //     Console.WriteLine($"Car Name:{car.Name}");
        // }
    }

}
