using System;

public class Shop
{
    public static void Enter(Player player)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Du har " + player.Money + " pengar");
            Console.WriteLine("1. Kniv - 10 pengar");
            Console.WriteLine("2. Svärd - 20 pengar");
            Console.WriteLine("3. Pistol - 30 pengar");
            Console.WriteLine("4. Tillbaka");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (player.Money >= 10)
                {
                    player.Money -= 10;
                    player.Damage += 2;
                    player.Weapon = "Knife";

                    Console.WriteLine("Du köpte en kniv");
                }
                else
                {
                    Console.WriteLine("Du har inte råd");
                }
            }
            else if (choice == "2")
            {
                if (player.Money >= 20)
                {
                    player.Money -= 20;
                    player.Damage += 5;
                    player.Weapon = "Sword";

                    Console.WriteLine("Du köpte ett svärd");
                }
                else
                {
                    Console.WriteLine("Du har inte råd");
                }
            }
            else if (choice == "3")
            {
                if (player.Money >= 30)
                {
                    player.Money -= 30;
                    player.Damage += 10;
                    player.Weapon = "Pistol";

                    Console.WriteLine("Du köpte en pistol");
                }
                else
                {
                    Console.WriteLine("Du har inte råd");
                }
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Fel val");
            }
        }
    }
}