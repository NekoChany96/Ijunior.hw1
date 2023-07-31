using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    enum Faction
    {
        Goodness, 
        Evile,
        Neutrality
    }
    internal class Unit
    {
        private string _name;
        private double _damage;
        private double _armor;
        private Faction _faction;
        private int _hp;
        private int _unitHp;
        public bool IsLive { get; private set; }


        public Unit(string name, int damage, int armor, Faction frashon, int hp)
        {
            _name = name;
            _hp = hp; 
            _unitHp = hp;
            _damage = damage;
            _armor = armor;
            _faction = frashon;
            IsLive = true;
            
        }

       
        

        private bool IsBerserk()
        {
            return _hp <= _unitHp;
        }

        public void Attack(Unit Enemy)
        {
            double attackDamage = _damage;

            if (IsBerserk())
            { 
               
                attackDamage = _damage * 2;
               
            }

            if (_faction != Faction.Neutrality || Enemy._faction != Faction.Neutrality)
            {
                if (_faction == Enemy._faction)
                {
                    attackDamage = attackDamage / 2;
                }
                else
                {
                    attackDamage = attackDamage * 1.5;
                }

            }

            Console.WriteLine($"Персонаж {_name} нанес {attackDamage} урон персонажу {Enemy._name}");
            Enemy.TakeDamage(attackDamage);

        }
        public void TakeDamage(double damage)
        {
            if (!IsLive)
            {
                Console.WriteLine("Бить мертвых нехорошо ");
            }
            else
            {
                double attackArmor = _armor;

                if (IsBerserk())
                {
                    attackArmor = _armor * 0.2;

                }

                _hp = _hp - (int)((damage * (1 - (attackArmor / 100))));

                if (_hp <= 0)
                {
                    Console.WriteLine($"Персонаж {_name} получил урон {damage} и умер");
                    IsLive = false;
                }
                else
                {
                    Console.WriteLine($"Персонаж {_name} получил урон {damage} и здоровье стало {_hp}");
                }
            }
        }
    }
}
