using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushka
{
    class Gun 
    {
        private bool isReoled;

        private void Rolead()
        {
            Console.WriteLine("Заряжаю");
            isReoled = true;
            Console.WriteLine("Заряжено");
        }

        public void Shoot()
        {
            if (!isReoled)
            {
                Console.WriteLine("Орудие не заряжено");
                Rolead();
            }
            Console.WriteLine("Пыщь - Пыщь!");
            isReoled = false;

        }
    }    

    class Program
    {
        static void Main(string[] args) 
        {
            Gun gun = new Gun();
            gun.Shoot();

        }

    }
}
