﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    enum Frashon
    {
        Goodness, 
        Evile,
        Netralitet
    }
    internal class Unite
    {
        string name;
        double damage;
        double armor;
        Frashon frashon;
        bool isBerserk;
        int hp;
        int uniteHp;
        bool isLive;

        public Unite(string name, int damage, int armor, Frashon frashon, int hp)
        {
            this.name = name;
            this.hp = hp;
            uniteHp = hp;
            this.damage = damage;
            this.armor = armor;
            this.frashon = frashon;
            isLive = true;
        }

        public bool IsLive()
        {
            return isLive;
        }

        private bool IsBerserk()
        {
            if (hp <= uniteHp / 2)
            {
                isBerserk = true;
                
            }
            else
            {
                isBerserk = false;
                
            }

            return isBerserk;
        }

        public void Attak(Unite Vrag)
        {
            double atackDamage = damage;
            double atackArmor = armor;

            if (IsBerserk())
            { 
               
                atackDamage = damage * 2;
                atackArmor = armor * 0.2;
               
            }

            //Сначала проверяем не принадлежим ли мы к Нитралетету
            if (frashon == Frashon.Netralitet || Vrag.frashon == Frashon.Netralitet)
            {
                
            }
            else if (frashon == Vrag.frashon)
            {
                atackDamage = atackDamage / 2;
            }
            else 
            {
                atackDamage = atackDamage * 1.5;
            }

            Console.WriteLine($"Персонаж {name} нанес {atackDamage} урон персонажу {Vrag.name}");
            Vrag.Armor(atackDamage);



        }
        public void Armor(double damage)
        {
            if (!isLive)
            {
                Console.WriteLine($"Бить мертвых нехорошо ");
            }
            else
            {
                double thisArmor = armor;

                if (IsBerserk())
                {
                    thisArmor = armor * 0.2;

                }

                hp = hp - (int)((damage * (1 - (thisArmor / 100))));

                if (hp <= 0)
                {
                    Console.WriteLine($"Персонаж {name} получил урон {damage} и умер");
                    isLive = false;
                }
                else
                {
                    Console.WriteLine($"Персонаж {name} получил урон {damage} и здоровье стало {hp}");
                }
            }
        }
    }
}