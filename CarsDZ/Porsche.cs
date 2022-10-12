
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Басикукле
{
    internal class Porsche : Car
    {
        public Porsche()
        {
            _enginePower = 340;
            _mark = "Posche Caiman";
            _speed = 360;
            _year = 2020;
            _price = 500000;
        }

        public override void Ride()
        {
            Console.WriteLine($"{_mark} Едет");
        }

        public override void GetInfoAboutCar()
        {
            Console.WriteLine($"Марка машины - {_mark}");
            Console.WriteLine($"Цена - {_price}");
            Console.WriteLine($"Максимальная скорость - {_speed}");
            Console.WriteLine($"Мощность двигателя - {_enginePower}");
            Console.WriteLine($"Год выпуска - {_year}");
            Console.WriteLine();
        }

        public override void Upgrade()
        {
            _enginePower = _enginePower + 20;
            _speed = _speed + 20;
            _price = _price + 10000;
            Console.WriteLine($"Мощность двигателя у {_mark} увеличилась на 20 и равна {_enginePower}");
        }
    }
}
