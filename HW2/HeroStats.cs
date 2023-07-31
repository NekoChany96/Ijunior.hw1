using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{

    internal class HeroStats
    {
        public double winrate { get; private set; }
        public double countMatchs { get; private set; }
        public double maxConsecutiveWins { get; private set; }


        public void RecordingStatistics (List<string> resultHero)
        {
            int wins = 0;
            int maxConsecutiveWins = 0;
            int currentConsecutiveWins = 0;

            foreach (string match in resultHero)
            {
                if (match == "win")
                {
                    wins++;
                    currentConsecutiveWins++;

                    if (currentConsecutiveWins > maxConsecutiveWins)
                    {
                        maxConsecutiveWins = currentConsecutiveWins;
                    }
                }
                else 
                {
                    currentConsecutiveWins = 0;
                }
                
            }

            double winRate = (double)wins / resultHero.Count();

            this.winrate = winRate;
            this.countMatchs = resultHero.Count();
            this.maxConsecutiveWins = maxConsecutiveWins;

        }
    }

}
