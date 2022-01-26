using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Cars cars = new Cars();
            Cleancar cleancar = new Cleancar();
            Dirtycar dirtycar = new Dirtycar();
            Random Generator = new Random();

            while (cars.Caramount > 0)
            {
                Console.WriteLine("Search vehicle");
                cars.Caramount = cars.Caramount - 1;
                Console.ReadLine();
                Console.Clear();

                cars.passengeramount = Generator.Next(1, 5);
                Console.WriteLine("Looks like there is " + cars.passengeramount + " passengers in the car");
                Console.ReadLine();

                if (cars.passengeramount == 1 || cars.passengeramount == 2 || cars.passengeramount == 3 || cars.passengeramount == 4)
                {
                    Console.WriteLine("Nothing seems suspicious yet.....");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (cars.passengeramount == 5)
                {
                    Console.WriteLine("5 people in the same car.... i should keep an eye out");
                    Console.ReadLine();
                    Console.Clear();
                }

                cars.Gun = Generator.Next(1, 2);
                if (cars.Gun == 1)
                {
                    Console.WriteLine("There is a gun in the car");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Do i take their gun for the moment?");
                    Console.WriteLine("Type Yes or No");
                    player.Askpassengergun = Console.ReadLine();
                    Console.Clear();
                    if (player.Askpassengergun == "Yes")
                    {
                        Console.WriteLine("Gun was taken");
                    }
                    else if (player.Askpassengergun == "No")
                    {
                        Console.WriteLine("Gun wasnt taken");
                    }

                }

                else if (cars.Gun == 2)
                {
                    Console.WriteLine("I cant see any form of weapons in the car.....yet");
                    Console.ReadLine();
                    Console.Clear();
                }

                cars.Smell = Generator.Next(dirtycar.Smelldrugs, cleancar.Smellfine);

                if (cars.Smell == dirtycar.Smelldrugs)
                {
                    Console.WriteLine("Smells like these passengers smoked weed in the car");
                    Console.ReadLine();
                    Console.WriteLine("I should keep that in mind.....");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (cars.Smell == cleancar.Smellfine)
                {
                    Console.WriteLine("No smell of any drugs");
                    Console.ReadLine();
                    Console.Clear();
                }

                cars.Goods = Generator.Next(1, 2);
                if (cars.Goods == 2)
                {
                    Console.WriteLine("I see a glimps of some simular goods.... i have seen them before");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (cars.Goods == 1)
                {
                    Console.WriteLine("I see a glimps of some regular shopping bags");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("Do i want to perform an arrest?");
                Console.WriteLine("Type Yes or No");
                player.Arrest = Console.ReadLine();
                Console.Clear();

                if (player.Arrest == "Yes")
                {
                    Console.WriteLine("I drawed my gun at the passengers");
                    Console.ReadLine();
                }




            }





        }
    }
}
