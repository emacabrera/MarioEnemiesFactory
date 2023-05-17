using Factory.Interfaces;
using Factory.Models;
using System;

namespace Factory
{
    public class HardEnemyFactory : IEnemyFactory
    {
        private readonly Random random = new Random();

        public IEntity CreateEnemy()
        {
            var randomOption = random.Next(0, 1000);

            if (randomOption > 500)
            {
                Console.WriteLine("Cuidado! Apareció un Boo!");
                return new Boo();
            }
            Console.WriteLine("Cuidado! Apareció un Koopa!");
            return new Koopa();
        }
    }
}
