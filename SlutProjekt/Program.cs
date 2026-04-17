using System;

public class Program
{
    static void Main()
    {
        string[] menuChoices = ["Döda zombies", "Shop", "Döda bossen"];

        Console.WriteLine("Hej och välkommen till gruvan");
        Console.WriteLine("Ditt mål är att döda bossen");
        Console.WriteLine("Du blir starkare när du dödar zombies");

        Player player = new Player("Spelare");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. " + menuChoices[0]);
            Console.WriteLine("2. " + menuChoices[1]);
            Console.WriteLine("3. " + menuChoices[2]);

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                FightZombies(player);
            }
            else if (choice == "2")
            {
                Shop.Enter(player);
            }
            else if (choice == "3")
            {
                FightBoss(player);
            }
            else
            {
                Console.WriteLine("Fel val");
            }
        }
    }

    static void FightZombies(Player player)
    {
        while (true)
        {
            player.HitPoints = 100;
            Zombie zombie = new Zombie();

            Console.WriteLine();
            Console.WriteLine("En zombie dyker upp");
            Console.WriteLine("Tryck på space för att attackera");

            while (zombie.HitPoints > 0)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Spacebar)
                {
                    player.Attack(zombie);
                    zombie.Attack(player);

                    Console.WriteLine("Zombie HP: " + zombie.HitPoints);
                    Console.WriteLine("Ditt HP: " + player.HitPoints);
                }
            }

            player.ZombiesKilled++;
            player.Money += 5;
            player.UpgradeDamage();

            Console.WriteLine("Du dödade zombien");
            Console.WriteLine("Damage: " + player.Damage);
            Console.WriteLine("Pengar: " + player.Money);

            Console.WriteLine("Tryck c för att fortsätta");
            Console.WriteLine("Tryck b för att gå tillbaka");

            string input = Console.ReadLine();

            if (input == "b")
            {
                break;
            }
        }
    }

    static void FightBoss(Player player)
    {
        Boss boss = new Boss();

        Console.WriteLine();
        Console.WriteLine("Bossen dyker upp");

        if (player.Weapon != "Pistol")
        {
            Console.WriteLine("Du behöver pistol för att vinna");
        }
    }
    }