using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int randConstPlus = 1;
            int countBlows = 0;
            Single healthPlayer, healthEnemy;
            Int32 damagePlayer, damageEnemy;
            Int32 armorPlayer, armorEnemy;
            Random rand = new Random();
            Console.WriteLine("Write your player characteristics.");
            Console.Write("Your health is - ");
            while (!Single.TryParse(Console.ReadLine(), out healthPlayer) || healthPlayer <= 0)
            {
                Console.WriteLine("You have mistake. Try agan ");
                Console.Write("Your health is - ");
            }
            Console.Write("Your damage is - ");
            while (!Int32.TryParse(Console.ReadLine(), out damagePlayer) || damagePlayer <= 0)
            {
                Console.WriteLine("You have mistake. Try agan ");
                Console.Write("Your damage is - ");
            }
            Console.Write("Your armor is - ");
            while (!Int32.TryParse(Console.ReadLine(), out armorPlayer) || armorPlayer <= 0)
            {
                Console.WriteLine("You have mistake. Try agan ");
                Console.Write("Your armor is - ");
            }
            healthEnemy = rand.Next(Convert.ToInt32(healthPlayer -10),Convert.ToInt32(healthPlayer+10));
            damageEnemy = rand.Next(damagePlayer - 10, damagePlayer + 10);
            armorEnemy = rand.Next(armorPlayer - 10, armorPlayer + 10);
            Console.WriteLine($"Your enemy have {healthEnemy} health, {damageEnemy} damage and {armorEnemy} armor.");
            Console.WriteLine("Enter any key to start fight with enemy.");
            Console.ReadKey();
            while (healthPlayer > 0 && healthEnemy > 0) 
            {
                countBlows++;
                healthPlayer -= Convert.ToSingle(rand.Next(0, damageEnemy + randConstPlus)) / 100 * armorPlayer;
                healthEnemy -= Convert.ToSingle(rand.Next(0, damagePlayer + randConstPlus)) / 100 * armorEnemy;

                Console.WriteLine($"Your player have {healthPlayer} health.");
                Console.WriteLine($"Enemy have {healthEnemy} health.");

                Console.WriteLine();
                Console.WriteLine($"The number of strokes is {countBlows}");
                Console.WriteLine("___________________________");
            }
            if (healthPlayer < 0 && healthEnemy < 0)
            {
                Console.WriteLine($"The result of the battle is a draw. The battle ended in {countBlows} strokes.");
            }
            else if (healthPlayer < 0)
            {
                Console.WriteLine($"The result of the battle - lose. The battle ended in {countBlows} strokes.");
            }
            else
            {
                Console.WriteLine($"The result of the battle - win. The battle ended in {countBlows} strokes.");
            }
            Console.ReadKey();

        }
    }
}
