// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Infrastructure;

bool isTerminate = false;
CarRepository carRepository = new CarRepository();
while (!isTerminate)
{
    Console.WriteLine("Welcome to Portal");
    Console.WriteLine("Press 1) to create new account");
    Console.WriteLine("Press 2) to list all accounts");
    Console.WriteLine("Press 3) to compare accounts");
    Console.WriteLine("Press 0) to terminate");
    var userInput = Console.ReadLine();
    //var input = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            carRepository.CreateCar();
            break;
        case "2":
            carRepository.DisplayCars();
            break;
        case "3":
            carRepository.CompareCars();
            break;
        case "0":
            Console.WriteLine("Terminating Program");
            isTerminate = true;
            break;
        default:
            Console.WriteLine("Oops! Invalid entry.");
            break;
    }
}