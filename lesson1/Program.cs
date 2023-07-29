using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int healf = 100;
            
            int armorUnite1 = 0;
            int armorUnite2 = 0;
           
            int damageEvile = 30;
            int damageGoodness = 30;
            int damageNeutrality = 20;

            Console.WriteLine("Выбор своего персонажа");
            Console.WriteLine("0 - выход из программы");
            Console.WriteLine("1 - персонаж фракции Зла");
            Console.WriteLine("2 - персонаж фракции Добра");
            Console.WriteLine("3 - персонаж фракции Неймтралитета");

            int inputFractionUnite1 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Введите значение брони для вашего персонажа в диапозоне от 0 до 100");

                string inputArmorUnite1 = Console.ReadLine();
                bool typeArmorUnite1 = int.TryParse(inputArmorUnite1, out armorUnite1);

            } while (typeArmorUnite1 == false || armorUnite1 > 100);

            if (inputFractionUnite1 == 0)
            {
                Console.WriteLine(" Have a good day!");
            }
            else if (inputFractionUnite1 == 1)
            {
                int unit1EvilHealf = healf + armorUnite1;
            }
            else if (inputFractionUnite1 == 2)
            {
                int unit1GoodnessHealf = healf + armorUnite1;
            }
            else
            {
                int unit1NeutralityHealf = healf + armorUnite1;
            }

            Console.WriteLine("Выбор противника");
            Console.WriteLine("0 - выход из программы");
            Console.WriteLine("1 - персонаж фракции Зла");
            Console.WriteLine("2 - персонаж фракции Добра");
            Console.WriteLine("3 - персонаж фракции Неймтралитета");

            int inputFractionUnite2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Введите значение брони для противника в диапозоне от 0 до 100");

                string inputArmorUnite2 = Console.ReadLine();
                bool typeArmorUnite2 = int.TryParse(inputArmorUnite2, out armorUnite2);

            } while (typeArmorUnite2 == false || armorUnite2 > 100);

            if (inputFractionUnite2 == 0)
            {
                Console.WriteLine(" Have a good day!");
            }
            else if (inputFractionUnite2 == 1)
            {
                int unit2EvilHealf = healf + armorUnite2;
            }
            else if (inputFractionUnite2 == 2)
            {
                int unit2GoodnessHealf = healf + armorUnite2;
            }
            else
            {
                int unit2NeutralityHealf = healf + armorUnite2;

            }


           







        }
    }
}
