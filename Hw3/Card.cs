using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3 // Происходит генерация рандомной колоды  карт 
{
    internal class Card
    {

        public string Name { get; private set; }
        public int Power { get; private set; }
        public string Element { get; private set; }
        public string Moral  { get; private set; }
        public string Ethic { get; private set; }

        public Card()
        
        {
            
            Random random = new Random();
            Name = Config.GetRandomName();
            Power = Config.GetRandomPower();
            Element = Config.GetRandomElemet();
            Moral = Config.GetRandomMorals();
            Ethic = Config.GetRandomEthic();


        }
        
    }
}

