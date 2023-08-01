using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal class Player
    {
        public List<Card> Cards { get; private set; }

        public string Name { get; private set; }
        public int Score { get; set; }

        private int _maxCoundCards = 5;

        public Player(string name)
        {
            Name = name;
            Cards = new List<Card>();


            for (int i = 0; i < _maxCoundCards; i++)
            {
                Cards.Add(new Card());
            }
        }

        public Card GetRandomCard()
        {
            Random random = new Random();
            return Cards[random.Next(Cards.Count)];
        }

        public void ChangeSelectCard(int numberChangeCard)
        {
            Cards[numberChangeCard] = new Card();
        }



    }
}
