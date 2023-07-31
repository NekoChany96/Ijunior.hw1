using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.V2
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();


            Hero Luciana = new Hero("Luciana");
            Luciana.stats.RecordingStatistics(new List<string>()
            {
                 "defeat", "win", "win"
            });

            heroes.Add(Luciana);


            Hero Corkes = new Hero("Corkes");

            Corkes.stats.RecordingStatistics(new List<string>()
            {
                "win", "win","win", "defeat",  "win"
            });

            heroes.Add(Corkes);


            Hero Nove = new Hero("Nova");

            Nove.stats.RecordingStatistics(new List<string>()
            {
                "win", "win", "defeat", "win", "win", "win", "defeat"
            });

            heroes.Add(Nove);


            Hero YoonJin = new Hero("Yoon Jin");

            YoonJin.stats.RecordingStatistics(new List<string>()
            {
                "win", "defeat", "defeat"
            });

            heroes.Add(YoonJin);


            Hero RVanco = new Hero("R.Vanco");

            RVanco.stats.RecordingStatistics(new List<string>()
            {
                "defeat", "defeat", "win", "win",  "defeat"
            });

            heroes.Add(RVanco);








            double maxWinrateForHero = heroes.Max(x => x.stats.winrate);
            double minWinrateForHero = heroes.Min(x => x.stats.winrate);
            double maxWinPeriodForHero = heroes.Max(x => x.stats.maxWinPeriod);
            double minCountMatchForHero = heroes.Min(x => x.stats.countMatchs);
            double maxCountMatchForHero = heroes.Max(x => x.stats.countMatchs);

            IEnumerable<Hero> MaxWinrateHeros = heroes.Where(x => x.stats.winrate == maxWinrateForHero);
            IEnumerable<Hero> MinWinrateHeros = heroes.Where(x => x.stats.winrate == minWinrateForHero);
            IEnumerable<Hero> MaxWinPeriodHeros = heroes.Where(x => x.stats.maxWinPeriod == maxWinPeriodForHero);
            IEnumerable<Hero> MinCountMatchHeros = heroes.Where(x => x.stats.countMatchs == minCountMatchForHero);
            IEnumerable<Hero> MaxCountMatchHeros = heroes.Where(x => x.stats.countMatchs == maxCountMatchForHero);





           Console.Write("Игроки с максимальным винрейтом: ");
               
            foreach (var hero in MaxWinrateHeros)
            {
                Console.Write($"{hero.name}(винрейт: {hero.stats.winrate.ToString("0.00")}) ");
            
            }

           Console.Write("\nИгроки с минимальныйм винрейтом: ");
           
            foreach (var hero in MinWinrateHeros)
            {
                Console.Write($"{hero.name}(винрейт: {hero.stats.winrate.ToString("0.00")}) ");
            }

           Console.Write("\nИгроки с максимальным винстриком: ");
            
            foreach (var hero in MaxWinPeriodHeros)
            {
                Console.Write($"{hero.name}(винстрик: {hero.stats.maxWinPeriod}) ");
            }

           Console.Write("\nЛюбимые игроки: ");
            
            foreach (var hero in MaxCountMatchHeros)
            {
                Console.Write($"{hero.name}(сыграно матчей: {hero.stats.countMatchs}) ");
            }

           Console.Write("\nНелюбимые игроки: ");
            
            foreach (var hero in MinCountMatchHeros)
            {
                Console.Write($"{hero.name}(сыграно матчей: {hero.stats.countMatchs}) ");
            }
            Console.WriteLine();
        }

    }
}
