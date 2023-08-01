using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal static class Config
    {

        private static List<string> Names = new List<string>()
        {
            "Card1","Card2","Card3","Card4","Card5","Card5"
        };

        private static  List<string> Elements = new List<string> {
            "Fire", "Water", "Earth", "Air"
        };

        private static List<string> Morals = new List<string>
        {
           "Godness", "Neutrality", "Evil"
        };

        private static List<string> Ethics = new List<string>
        {
            "Order","Neutrality","Chaos"
        };

        private static int _maxPowerCard = 20;

        private static Random random = new Random();

        public static string GetRandomName()
        {
            return Names[random.Next(Names.Count)];
        }

        public static string GetRandomElemet()
        {
            return Elements[random.Next(Elements.Count)];
        }

        public static string GetRandomMorals()
        {
            return Morals[random.Next(Morals.Count)];
        }

        public static string GetRandomEthic()
        {
            return Ethics[random.Next(Ethics.Count)];
        }

        public static int GetRandomPower()
        {
            return random.Next(_maxPowerCard);
        }

    }
}
