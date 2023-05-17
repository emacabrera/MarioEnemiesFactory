using Factory.Interfaces;
using Factory.Models;
using System;

namespace Factory
{
    public class EasyEnemyFactory : IEnemyFactory
    {
        public IEntity CreateEnemy()
        {
            Console.WriteLine("Cuidado! Apareció un Goomba!");
            return new Goomba();
        }
    }
}
