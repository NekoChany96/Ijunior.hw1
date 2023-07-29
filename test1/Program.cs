using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unite Diana = new Unite("Diana", 15, 10, Frashon.Goodness, 100);
            Unite Kosty = new Unite("Kosty", 25, 5, Frashon.Evile, 100);
            for (int i = 0; i < 10; i++)
            {
                Diana.Attak(Kosty);
                Kosty.Attak(Diana);
                if (!Diana.IsLive() || !Kosty.IsLive())
                {
                    break;
                }

            }
        }
    }
}
