using Factory;
using Factory.Interfaces;
using System;

namespace MarioEnemiesFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dificultad Difícil: Boos and Koopas");
            IEnemyFactory factory = new HardEnemyFactory();
            RenderEnemies(factory);
            Console.WriteLine();

            Console.WriteLine("Dificultad Media: Boos, Koopas and Goombas");
            factory = new MediumEnemyFactory();
            RenderEnemies(factory);
            Console.WriteLine();

            Console.WriteLine("Dificultad Fácil: Solo Goombas");
            factory = new EasyEnemyFactory();
            RenderEnemies(factory);

            Console.ReadLine();
        }

        private static void RenderEnemies(IEnemyFactory factory)
        {
            for (int i = 0; i < 10; i++)
            {
                factory.CreateEnemy();
            }
        }
    }
}
