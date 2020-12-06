using System;

namespace Homework05122020
{

    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();

            car.Name = "Hyundai";
            car.Consuption = 14;   //100 e 14L          1 km e 1.14
            car.CurrentGas = 10; // hazirda olan benzin
            car.TankCapacity = 60;  // full tank
            car.Money = 70;            // 
            car.FuelPrice = 1.1f;
            Console.WriteLine("Car Model : " + car.Name);
            Console.WriteLine("Car Information >> " + " Tank Capacity : " + car.TankCapacity + "L" + " || " + " Car consiption :  " + car.Consuption + "L" + " || " + " Money : " + car.Money + "Azn");

            Console.WriteLine("Please write distance traveled");
            car.DistanceTraveled = Convert.ToInt32(Console.ReadLine());
            car.Start();




        }

        class Car
        {


            public string Name { get; set; }

            public float Consuption { get; set; }

            public float CurrentGas { get; set; }


            public int TankCapacity { get; set; }

            public int Money { get; set; }

            public int DistanceTraveled { get; set; }

            public float FuelPrice { get; set; }

            public float spentMoney { get; set; }

            public float Fuel { get; set; }

            public float refuel { get; set; }

            public float totalFuel { get; set; }

            public float usingFuel { get; set; }

            public  int Start()
            {
                int currentPoint = 0;
                if (CurrentGas > 0 || RemainingFuel() > 0)
                {

                    currentPoint += DistanceTraveled;
                    Console.WriteLine("Car Start  +" + currentPoint + "km" + "  " + " Remaining Fuel :" + RemainingFuel() + "L");
                }
                return currentPoint;
            }


            public float FuelCalc()
            {
                //float distanceTraveled = 100;
                usingFuel = (DistanceTraveled * Consuption) / 100;

                return usingFuel;           // distance  km e istifade edilen fuel

            }

            public float RemainingFuel()
            {
                float remainingFuel;


                if (CurrentGas < FuelCalc())
                {
                    remainingFuel = CurrentGas - FuelCalc() + Refuel();
                }
                else
                {
                    remainingFuel = CurrentGas - FuelCalc();
                }
                if (remainingFuel <= 0)
                {
                    Console.WriteLine("No Fuel :");
                    // remainingFuel = 0;
                    Refuel();

                    //}
                    return remainingFuel;

                }
                else
                {

                    //Console.WriteLine("Remaining Fuel :" + remainingFuel);
                    return remainingFuel;
                }
            }

            public float Refuel()
            {


                float usingDistanceFuel = (DistanceTraveled * (Consuption / 100)); // distance traveled istifade edilecek fuel
                if (usingDistanceFuel > TankCapacity)
                {
                    float needTankCapacity = usingDistanceFuel / 60;            // distance traveled nece tank lazimdir
                    refuel = TankCapacity - CurrentGas; //ne geder refuel etdik
                    totalFuel = (TankCapacity * needTankCapacity) + CurrentGas;            //distance total lazim olan fuel

                    // Console.WriteLine(totalFuel + "total fuel deyeri ");
                    Fuel = CurrentGas - FuelCalc(); // qalan fuel
                    CurrentGas = TankCapacity;
                    Console.WriteLine("Current Gas  :" + CurrentGas + " " + " ReFuel :" + refuel + "  " + "Need Fuel : " + Fuel + " " + "||" + " Money : ");//  hazirda olan fuel  refuelden sonra
                                                                                                                                                            // Console.WriteLine("using distance fuel :" + usingDistanceFuel + "||" + "total fuel  " + totalFuel);
                }

                else
                {
                    refuel = TankCapacity - CurrentGas; //ne geder refuel etdik
                    Fuel = CurrentGas - FuelCalc(); // qalan fuel
                    CurrentGas = TankCapacity;                  //  hazirda olan fuel  refuelden sonra

                    Console.WriteLine("Refuel");
                    Console.WriteLine("Current Gas  :" + CurrentGas + " " + " ReFuel :" + refuel + "  " + "Need Fuel : " + Fuel + "L " + "||" + " Money : ");
                }

                return CurrentGas;
            }

















        }

    }

}
