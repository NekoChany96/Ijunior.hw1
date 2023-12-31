﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal class Fight
    {




        private Card ChoiceCard(Player player)
        {
            

            PrintPlayerCard(player);
            Console.WriteLine($"Игрок {player.Name} юудем менять карту?");
            Console.WriteLine($"0 - нет или укажи номер карты, которую будем менять");

            int answer = int.Parse(Console.ReadLine());

            if (answer != 0)
            {
                player.ChangeSelectCard(answer - 1);
                PrintPlayerCard(player );

            }
            Console.Write($"Игрок {player.Name} выбери карту: ");
            int indexSelectCard = int.Parse(Console.ReadLine()) - 1;
            return player.Cards[indexSelectCard];
        }

        private void PrintPlayerCard(Player player)
        {
            Console.WriteLine();
            Console.WriteLine($"Игрок {player.Name} вот ваши карты:");
            
            int indexcard = 0;
            
            foreach (var card in player.Cards)
            {
                indexcard++;
                Console.WriteLine($"{indexcard} --> {card.Name},{card.Power},{card.Element},{card.Moral},{card.Ethic}");
            }
            Console.WriteLine();
        }
        public bool Attack(Player player1, Player AI)
        {
            bool result = false;
            Card player1Card = ChoiceCard(player1);
            Card AICard = AI.GetRandomCard();

            Console.WriteLine($" Игрок {AI.Name} выбрал {AICard.Name} ");

            Console.WriteLine("выбирите метод сражения (введите число):");
            Console.WriteLine("1 - мирные переговоры, 2 - грубая сила. ");

            if (int.Parse(Console.ReadLine()) == 1)
            {
                //договор
                if (resultCardsWorldview(player1Card, AICard))
                {
                    player1.Score++;
                    result = true;
                };
            }
            
            else
            {
                //бой карт
                if (CardsFight(player1Card, AICard))
                {
                    player1.Score++;
                    result = true;
                };
            }
    

            return result;
        }


        private bool CardsFight(Card playerCard, Card aiCard)
        {
            bool result = false;

            if (playerCard.Element == aiCard.Element)
            {
                double power = playerCard.Power * 0.7;
                if (power > aiCard.Power)
                {
                    result = true;
                }
            }
            else if (playerCard.Power > aiCard.Power)
            {
                result = true;
            }
           
            
            Console.WriteLine($" Сила вашей карты равна {playerCard.Power}, а стихия {playerCard.Element} ");
            Console.WriteLine($" У противника сила карты равна {aiCard.Power}, а стихия {aiCard.Element} ");
            
            return result;
        }
        private int countingCardsWorldview(Card playerCard)
        {

            int weightMoral = 1;
            int weightEthic = 1;

            if (playerCard.Moral == "Godness")
            {
                weightMoral = 1;
            }
            else if (playerCard.Moral == "Neutrality")
            {
                weightMoral = 2;
            }
            else if (playerCard.Moral == "Evil")
            {
                weightMoral = 3;
            }

            if (playerCard.Ethic == "Order")
            {
                weightMoral = 1;
            }
            else if (playerCard.Ethic == "Neutrality")
            {
                weightMoral = 2;
            }
            else if (playerCard.Ethic == "Chaos")
            {
                weightMoral = 3;
            }

            int weight = weightMoral * weightEthic;
            return  weight ;

        }
        private bool resultCardsWorldview(Card playerCard, Card aiCard)
        {

            int weightPlayer1 = countingCardsWorldview(playerCard);
            int weightPlayer2 = countingCardsWorldview(aiCard);
            
            int diff = Math.Abs(weightPlayer1 - weightPlayer2);
            float maxDiff = 9;
            double chance = 1 - diff / maxDiff;

            Console.WriteLine($"Мировозрение вашей карты равно {weightPlayer1}");
            Console.WriteLine($"Мировозрение карты противника равно {weightPlayer2}");



            Random random = new Random();
            double randomDouble = random.NextDouble();

            if (randomDouble < chance)
            {
                return true;
            }
            else
            {
                return false;

            }


        }
    }
}
