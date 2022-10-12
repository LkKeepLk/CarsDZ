

using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;
using Басикукле;

User user = new User();
int money = 10000000;
bool bar = false;
while (true)
{
    void GetMenu()
    {
        if (bar == false)
        {
            Console.WriteLine();
            Console.WriteLine($" Ваш бюджет {money}");
            Console.WriteLine();
            Console.WriteLine("1. Купить автомобиль");
            Console.WriteLine("2. Апгрейд автомобиля");
            Console.WriteLine("3. Информация об автомобиле");
            Car car = FuncMenu();
            user.BuyAuto(car);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("1. Поменять автомобиль");
            Console.WriteLine("2. Апгрейд автомобиля");
            Console.WriteLine("3. получить инфо об автомобиле");
            Console.WriteLine("4. Поехать");
            Console.WriteLine();
            string menu2 = Console.ReadLine();
            int menu3 = int.Parse(menu2);

            if (menu3 == 1)
            {
                Car car = FuncMenu();
                user.BuyAuto(car);

            }

            else if (menu3 == 2)
            {
                if (bar == true)
                {
                    if (money >= 50000)
                    {
                        Console.WriteLine();
                        user.UpgradeAuto();
                        money = money - 50000;
                        Console.WriteLine($"Денег осталось - {money}");
                    }
                    else
                    {
                        Console.WriteLine($"Денег нехватает, баланс {money}");
                    }
                }
            }
            else if (menu3 == 3)
            {

                if (bar == true)
                {
                    Console.WriteLine();
                    user.GetInfo();
                }
            }
            else if (menu3 == 4)
            {
                user.Ride();
            }
        }
        Car FuncMenu()
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            if (b == 1)
            {
                Console.WriteLine($"Выберите марку авто");
                Console.WriteLine($"1. Porsche - 5000000");
                Console.WriteLine($"2. Lada - 150000");
                Console.WriteLine($"3. BMW - 5000");
                Console.WriteLine($"4. Mercedes - 2000000");

                string j = Console.ReadLine();
                int c = int.Parse(j);
                if (c == 1)
                {
                    if (money >= 5000000)
                    {

                        money = money - 5000000;
                        Console.WriteLine("Поздравляю с покупкой четкого авто Porsche Caiman");
                        bar = true;
                        return new Porsche();
                    }
                    GetMenu();
                    Console.WriteLine();
                }
                else if (c == 2)
                {
                    if (money >= 150000)
                    {

                        money = money - 150000;
                        Console.WriteLine("Поздравляю с покупкой четкого авто Lada Proira");
                        bar = true;
                        return new Lada();
                    }
                }
                else if (c == 3)
                {
                    if (money >= 5000)
                    {
                        money = money - 5000;
                        Console.WriteLine("Поздравляю с покупкой не четкого авто BMW Govno");
                        bar = true;
                        return new BMW();
                    }
                }
                else if (c == 4)
                {
                    if (money >= 2000000)
                    {
                        money = money - 2000000;

                        Console.WriteLine("Поздравляю с покупкой четкого авто Mercedes Benz E63");
                        bar = true;
                        return new Mercedes();
                    }
                }
            }

            else if (b == 2)
            {
                if (bar == false)
                {


                    Console.WriteLine($"Сначала возьми тачку");
                    GetMenu();
                    FuncMenu();
                }
                else if (bar == true)
                {
                    if (money >= 10000)
                    {
                        Console.WriteLine();
                        user.UpgradeAuto();
                        money = money - 10000;
                        Console.WriteLine($"Осталось столько денег {money}");
                    }
                    else
                    {
                        Console.WriteLine($"Недостаточно средств Баланс = {money}");
                    }
                }
            }
            else if (b == 3)
            {
                if (bar == false)
                {
                    Console.WriteLine($"купи тачку сначала");
                    GetMenu();
                    FuncMenu();
                }
                else if (bar == true)
                {
                    user.GetInfo();
                }
            }
            return new BMW();
        }
    }
    GetMenu();
}