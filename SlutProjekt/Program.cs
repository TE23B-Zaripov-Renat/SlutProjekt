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
                bool end = FightBoss(player);
                if (end == true) break;

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
            else if (input == "c")
        {
            continue; 
        }
        }
    }

    static bool FightBoss(Player player)
    {
        player.HitPoints = 100;
        Boss boss = new Boss();

        Console.WriteLine();
        


        if (player.Weapon != "Pistol")
        {
            Console.WriteLine("Du behöver pistol för att vinna");
            return false;
        }
        else if (player.Weapon == "Pistol")
        {
            Console.WriteLine("Bossen dyker upp");
            while (boss.HitPoints > 0)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Spacebar)
                {
                    player.Attack(boss);

                if (boss.HitPoints > 0)
                {
                     boss.Attack(player);
                }

                    Console.WriteLine("Boss HP: " + boss.HitPoints);
                    Console.WriteLine("Ditt HP: " + player.HitPoints);
                }
            }

        }
        if (player.HitPoints <= 0)
        {
            Console.WriteLine("Du dog mot bossen");
        }
        else
        {
            Console.WriteLine("Du besegrade bossen!");
            Console.WriteLine("Tryck på valfri knapp för att avsluta spelet");
            Console.ReadKey();
        }

        return true;
        
    }
    }