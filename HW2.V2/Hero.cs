using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.V2
{
    internal class Hero
    {
        public string name { get; private set; }
        public HeroStats stats { get; set; }

        public Hero(string name)
        {
            this.name = name;
            this.stats = new HeroStats();
        }

    }
}
