using System.Net.Http.Headers;

namespace TaskCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankda ne qeder benzin var?");
            double fuel = double.Parse(Console.ReadLine());
            restart:
            Console.WriteLine("Bakin hecmi ne qederdir?");
            double capacity = double.Parse(Console.ReadLine());
            
            if(fuel> capacity)
            {
                Console.WriteLine("Hecm benzinden kicik olmamalidir");
                goto restart;
            }

            Console.WriteLine("Masin 100 kilometere ne qeder benzin yandirir");
             
            double comsuption = double.Parse(Console.ReadLine());

           Car car = new Car(fuel, comsuption, capacity);
             restartApp:
            Console.WriteLine("1. Sur\n 2. Zaprafkaya gir\n 3.Getdiyin yolu goster\n 0. exit");
            string result = Console.ReadLine();
           switch(result)
            {
                case "1":
                    Console.WriteLine("Nece km yol getmek isteyirsen?");
                    double kilometer = double.Parse(Console.ReadLine());
                    car.Drive(kilometer);
                    break;
                case "2":
                    Console.WriteLine("Ne qeder yanacaq doldurmaq isteyirsen?");
                    double amount = double.Parse(Console.ReadLine());
                    car.Refuel(amount);
                    break;
                case "3":
                    car.ShowFuel();
                    break;
                case "4":
                    car.ShowMillage();
                    break;
                case "0":
                    Console.WriteLine("Program dayandi...");
                    return;
                    break;
                default:
                    Console.WriteLine("Duzgun deyer daxil edin");
                    break;
                
                    
            }
             
            goto restartApp;
        }
    }
}
