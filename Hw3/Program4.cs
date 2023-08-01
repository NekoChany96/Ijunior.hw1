using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Player Diana = new Player("Diana");
            Player AI = new Player("AI");

            Fight fight = new Fight();

           while (true)
           {
                if (!fight.Attack(Diana, AI))
                {
                    Console.WriteLine($"Игрок {Diana.Name} проиграл :(");
                    Console.WriteLine($"Вы набрали очков: {Diana.Score}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Игрок {Diana.Name} победили, игра продолжается!");
                }
           }

        }
    }
}
