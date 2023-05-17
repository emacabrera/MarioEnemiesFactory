using Factory.Interfaces;
using Factory.Models;
using System;

namespace Factory
{
    public class MediumEnemyFactory : IEnemyFactory
    {
        private readonly Random random = new Random();

        public IEntity CreateEnemy()
        {
            var randomOption = random.Next(0, 1000);

            if (randomOption > 666)
            {
                Console.WriteLine("Cuidado! Apareció un Boo!");
                return new Boo();
            }
            else if (randomOption > 333)
            {
                Console.WriteLine("Cuidado! Apareció un Koopa!");
                return new Koopa();
            }
            
            Console.WriteLine("Cuidado! Apareció un Goomba!");
            return new Goomba();
        }
    }
}
