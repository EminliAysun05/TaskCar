

using System.Security.Cryptography.X509Certificates;

namespace TaskCar
{
    public class Car
    {
        // bu masin indiye qeder ne qeder gedib
        private double Millage { get; set; }
        // ne qeder benzin var onu hesablayir
        private double Fuel { get; set; }
        // 100den ne qeder benzin yandirib
        private double  FuelComsuption { get; set; }

        private double TankCapacity { get; set; }

        public Car(double fuel, double fuelConsuption, double tankCapacity)
        {
            // millage onsuz sifirdi deye ctor'a vermirik
            Fuel = fuel;
            FuelComsuption = fuelConsuption;
            TankCapacity = tankCapacity;
        }
        public Car() //default olacaq gelen deyerlerdir, ctor overloaddir
        {
            Fuel = 20;
            TankCapacity = 40;
            FuelComsuption = 10;
        }

        public bool Drive(double kilometer)
        {
            double needFuel = kilometer * FuelComsuption / 100;
            if(Fuel>+needFuel) 
            { 
            Fuel-=needFuel;
            Millage += kilometer;
                Console.WriteLine($"{kilometer} yol gedildi, benzin {Fuel}");
                return true;
            }
            Console.WriteLine($"Kifayet qeder benzin yoxdur.{needFuel} qeder benzin lazimdir, sizde {Fuel} qeder var");
            return false;
       }
        public bool Refuel(double Amount)//ne qeder benzin doldura biler
        {
            if (Fuel + Amount <= TankCapacity)
            {
                Fuel += Amount;
                Console.WriteLine($"{Amount} qeder benzin dolduruldu, bak {Fuel}");
                return true;
                
            }
            else
            {
                Console.WriteLine($"{TankCapacity-Fuel} qeder bos yeriniz var, hal hazirda daxil etdiyiniz miqdari doldura bilmersiniz");
                return false;
            }
            
        }
        public void ShowFuel()
        {
            Console.WriteLine($"bak {Fuel}");
        }
        public void ShowMillage()
        {
            Console.WriteLine($" Km {Millage}");
        }


    }
   
}
