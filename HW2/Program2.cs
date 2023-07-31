using HW2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program2
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



            double maxWinrate = 0;
            double minWinrate = double.MaxValue;
            double maxCountMatchs = 0;
            double minCountMatchs = double.MaxValue;
            double maxPeriodWinMatch = 0;

           
            //Вопрос, как лучше, одним проходом или двумя, в одном находим максимальное значение, во втором выбираем игроков с этим значением

            List<Hero> MaxHeroWinrates = new List<Hero>();

            foreach (Hero hero in heroes)
            {
                if (hero.stats.winrate > maxWinrate)
                {
                    maxWinrate = hero.stats.winrate;
                    MaxHeroWinrates.Clear();
                    MaxHeroWinrates.Add(hero);
                }
                else if (hero.stats.winrate == maxWinrate)
                {
                    MaxHeroWinrates.Add(hero);
                }
            }


            List<Hero> MinHeroWinrates = new List<Hero>();

            foreach (Hero hero in heroes)
            {
                if (hero.stats.winrate < minWinrate)
                {
                    minWinrate = hero.stats.winrate;
                    MinHeroWinrates.Clear();
                    MinHeroWinrates.Add(hero);
                }
                else if (hero.stats.winrate == minWinrate)
                {
                    MinHeroWinrates.Add(hero);
                }
            }





            List<Hero> MaxHeroCountMatchs = new List<Hero>();

            foreach (Hero hero in heroes)
            {
                if (hero.stats.countMatchs > maxCountMatchs)
                {
                    maxCountMatchs = hero.stats.countMatchs;
                    MaxHeroCountMatchs.Clear();
                    MaxHeroCountMatchs.Add(hero);
                }
                else if (hero.stats.countMatchs == maxCountMatchs)
                {
                    MaxHeroCountMatchs.Add(hero);
                }
            }


            List<Hero> MinHeroCountMatchs = new List<Hero>();

            foreach (Hero hero in heroes)
            {
                if (hero.stats.countMatchs < minCountMatchs)
                {
                    minCountMatchs = hero.stats.countMatchs;
                    MinHeroCountMatchs.Clear();
                    MinHeroCountMatchs.Add(hero);
                }
                else if (hero.stats.countMatchs == minCountMatchs)
                {
                    MinHeroCountMatchs.Add(hero);
                }
            }




            List<Hero> MaxPeriodWinMatch = new List<Hero>();

            foreach (Hero hero in heroes)
            {
                if (hero.stats.maxConsecutiveWins > maxPeriodWinMatch)
                {
                    maxPeriodWinMatch = hero.stats.maxConsecutiveWins;
                    MaxPeriodWinMatch.Clear();
                    MaxPeriodWinMatch.Add(hero);
                }
                else if (hero.stats.maxConsecutiveWins == maxPeriodWinMatch)
                {
                    MaxPeriodWinMatch.Add(hero);
                }
            }


            Console.Write("Игроки с максимальным винрейтом: ");

            foreach (var hero in MaxHeroWinrates)
            {
                Console.Write($"{hero.name}(винрейт: {hero.stats.winrate.ToString("0.00")}) ");

            }

            Console.Write("\nИгроки с минимальныйм винрейтом: ");

            foreach (var hero in MinHeroWinrates)
            {
                Console.Write($"{hero.name}(винрейт: {hero.stats.winrate.ToString("0.00")}) ");
            }

            Console.Write("\nИгроки с максимальным винстриком: ");

            foreach (var hero in MaxPeriodWinMatch)
            {
                Console.Write($"{hero.name}(винстрик: {hero.stats.maxConsecutiveWins}) ");
            }

            Console.Write("\nЛюбимые игроки: ");

            foreach (var hero in MaxHeroCountMatchs)
            {
                Console.Write($"{hero.name}(сыграно матчей: {hero.stats.countMatchs}) ");
            }

            Console.Write("\nНелюбимые игроки: ");

            foreach (var hero in MinHeroCountMatchs)
            {
                Console.Write($"{hero.name}(сыграно матчей: {hero.stats.countMatchs}) ");
            }
            Console.WriteLine();

        }

    }
}