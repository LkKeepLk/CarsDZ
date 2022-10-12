
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Басикукле
{
    internal class User
    {
        private int _money;
        private Car _car;
        private Car _mark;

        public void BuyAuto(Car car)
        {
            _car = car;
        }
        public void UpgradeAuto()
        {
            _car.Upgrade();
        }
        public void GetInfo()
        {
            _car.GetInfoAboutCar();
        }
        public void Ride()
        {
            _car.Ride();
        }
    }
}