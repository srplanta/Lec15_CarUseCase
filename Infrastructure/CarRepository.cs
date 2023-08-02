using Models;

namespace Infrastructure
{
    public class CarRepository
    {
        Car[] cars;
        int index;
        public CarRepository()
        {
            cars = new Car[10];
            index = 0;
        }

        public void CreateCar()
        {
            if (index < 10)
            {
                //Car car = new Car();    //cannot create instance of an abstract class
                Car car = new Audi("2000 CC Engine", 4000M, "Audi", "Executive Class", "Red");
                cars[index] = car;
                Console.WriteLine("Car object has been created successfully!");
                index++;
            }
            else
            {
                Console.WriteLine("No more room for object creation.");
            }
        }

        public void DisplayCars()
        {
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine(cars[i].ToString());
                }
            }
            else
            {
                Console.WriteLine("Oops! No record found.");
            }
        }

        public void CompareCars()
        {
            var car1 = new Audi("1500 CC Engine", 5000M, "Audi", "Esecutive", "Red");
            var car2 = new Audi("1500 CC Engine", 5000M, "Audi", "Esecutive", "Red");
            if (car1.Equals(car2))
            {
                Console.WriteLine("Both cars are equal.");
            }
            else
            {
                Console.WriteLine("Both cars are not equals.");
            }
        }
    }
}