/*
 * Desecrate Void
 * JOSHUA,2020
 * 
 * School Opdracht
 */

using SpaceAdventure;
using System;
using System.Collections.Generic;
namespace SpaceAdventure
{
    static class Game
    {
        static string[] PartOne =
        {
                "You awaken on a strange, foreign planet. The atmosphere is dense and there isn't a lot of fauna, nor flora. \nYou are only equipped with a spacesuit, and are surrounded by broken metal. \na= Scavenge scrap, b= Search for signal",
                "You look around, you know that this alloyed metal is that of a spaceship, you find a part of scrap metal with a familiar logo: \"Void Corporation\". \nIt must be part of a spacship somewhat nearby, or at least, what's left of it.",
                "You wander for about ten minutes until you hear a rapid beep coming from your spacesuit, \nit has picked up some sort of distress signal not too far away. \nThe signal has been repeating for about twenty minutes."
        };

        static string[] PartTwo =
        {
                "You decide to look around for the spaceship, and wondrously, you find it. it has a couple of chunks missing but it's mostly intact. \na= Try to repair the ship with the scrap, b= Aquire hyper beacon",
                "Strangely, none of the scrap you find seem to match the spaceship. \nafter a small bit of research, you figure out that the scrap is not that of a spaceship, but instead, that of a freighter. \nmeaning there has to be a freighter somewhere in near space.",
                "You rip the beacon from the perfectly fine spaceship, seemingly destroying it. Whilst inspecting the beacon, the spaceship starts burning and after a while, explodes. \nNow all you are left with is a hyper beacon and some burnt scrap."
        };

        static string[] PartThree =
        {
                "You tune in to the signal saying \"Who's there?\", you hear a faint female voice saying \"I'm hurt and in danger, do you copy?\", \nyou respond by saying \"Copy, transmit your coordinates and i'll be on my way.\"\nThe moment the stranger transmits their coordinates, the signal fades. \na= Find high ground to find signal, b= Walk in the direction the signal came from",
                "You climb onto a nearby mountain and the signal returns. The voice is now crying, screaming \"COPY, COPY?!\", \nYou calmly respond by explaining what happened and asking for the coordinates once again.\nThe stranger, only barely remaining calm, transmits their coordinates. You tell them it's going to be all right and that you'll be there soon.",
                "You walk in the direction you found the signal from, after you walk over a small hill, you see a tiny settlement, \nyour spacesuit mentions that this is the place the signal came from.\nHowever, the path is blocked by a menacing creature."
        };

        static string[] PartFour =
{
                "You stand around, thinking, you're out of options. There's so much hope, yet so little to do. \nYou can either still take the beacon from the ship, or sit and wait. \na= Aquire hyper beacon, b= Sit and wait",
                "You walk on back to the spaceship, determined, and rip out the beacon. \nWhilst inspecting the beacon, the spaceship starts burning and after a while, explodes.",
                "You sit down, then lay down.\nSlowly, your life starts to fade away and eventually, you die."
        };
        
        static string[] PartFive =
{
                "\"So, we can look at that spaceship there later.\" she says. \n\"Just get me some medical supplies and we can get out of here..\"\na= Search for medical supplies, b= Take the spaceship and leave her",
                "You find medical supplies in a cupboard somewhere in the settlement. \nYou apply bandages on the woman's wounds and you both walk over to the ship.\nEntering the ship, you look at eachother, she seems like the happiest person in the world, \nmore importantly, she seems relieved.",
                "You bolt to the ship, leaving the stranger behind. Once you enter the ship, you look at her, she looks angry, and sad."
        };

        static string[] PartSix =
{
                "The beacon is a long-ranged signalling device. \nYou know little about it but you do know it's used for communication, but can also be used in emergency situations.",
        };

        static string[] PartSeven =
{
                "After a mere 10 seconds, you locate a settlement, it looks mostly in-tact and you can see a spaceship idle.\nAs you approach you see the stranger, sitting, wounded.",
                "\"Yes, the spaceship works, just... just get me some medical supplies or something, okay? Please.\"",
                "\"Oh, yes i'm fine, thank you for asking, really. It kind of hurts, maybe you can find some medical supplies, or something?\"",
                "\"We went to spacecraft maintenance study together. Do you really not know me? Well doesn't matter, can you like, find some medical supplies for me?\""
        };

        static string[] PartEight =
{
                "Together you leave the planet. Once you reach outer space, you realise you made it.\nAfter a while you reach the freighter and you both get out of your spaceship.\nYou don't know how you two got on that planet, but you're glad it's over. \nThe freighter is set to leave in a couple of minutes, and you'll both be on your way home.",
        };

        static string[] PartNine =
{
                "Once you're in the spaceship, you leave into outer space. You feel bad for what happened at the settlement.\nAt least you make it to the freighter, alive. You don't know how you got on the planet in the first place, so that's a mystery. \nBut the freighter will leave in 10 minutes, on it's way back to earth.",
        };

        static string[] PartThirteen =
{
                "You made the right decisions. You leave into space, and fly to the freighter you came from. \nOnce you land on the freighter, you realise that you made it, you hear the freighter leaves towards earth in 16 minutes."
        };

        static string[] PartTen =
{
                "You walk over to the settlement, you see a spaceship and some buildings.\nEverything looks dead... even the stranger who was sending the distress signal.\na=Get in the spaceship, b=Look for supplies",
                "You look around, and realise there's nothing of value here. You get in the spaceship and leave.",
                "You look around for supplies, you find a lot of good stuff, like medical supplies and money.\nThen a weird slug-like alien jumps on your head and eats your brain."
        };

        static string[] PartEleven =
{
                "The alien creature looks hungry, wanting to eat something.\nSeeing as there isn't a lot of fauna to hunt, the only thing available to eat is you. \na=Walk around the creature, b=Stand still, c=Walk towards the creature",
                "You walk backwards slowly, then walk around it in a diameter of 10 meters. When you're halfway there, the creature bolts towards you and promptly eats you alive.",
                "You stand still, embracing the creature. For a solid 6 minutes, it stands there and occasionally sniffing you.\nThen, it leaves you alone, you continue on your way to the settlement",
                "You walk towards the alien, as if you want to pet it. But as you do this, it bends over and eats you alive."
        };

        static string[] PartTwelve =
{
            "The beacon, vibrating, looks dangerous, but it's your last hope.\na=Throw it in the air, b=Press a button on the back",
            "You throw the beacon in the air, it levitates for a while, then summons a spaceship seemingly out of nowhere.\nYou get in the vehicle and fly into space.",
            "The beacon starts beeping and proclaims: \"Self destruct in *one* seconds.\", then it blows up in your face."
        };

        static string CharacterName = "Adventurer";
        static string DeathCause = "Nothing";
        static int Score = 0;
        static List<string> Inventory = new List<string>();
        
        public static void StartGame() 
        {
            GameTitle();
            NameCharacter();
            Choice();
            EndGame();

            static void GameTitle()
            {
                Console.WindowHeight = Console.LargestWindowHeight - 5;
                Console.WindowWidth = Console.LargestWindowWidth - 20;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.Title = "Desecrate Void Text Game";
                string title = @"________                                                         __                ____   ____        .__      .___ 
\______ \     ____     ______   ____    ____  _______  _____   _/  |_    ____      \   \ /   / ____   |__|   __| _/ 
 | |__|  \  _/ __ \   /  ___/ _/ __ \ _/ ___\ \_  __ \ \__  \  \   __\ _/ __ \      \   Y   / /  _ \  |  |  / __ |  
 |    `   \ \  ___/   \___ \  \  ___/ \  \___  |  | \/  / __ \_ |  |   \  ___/       \     / (  <_> ) |  | / /_/ |  
/_______  /  \___  > /____  >  \___  > \___  > |__|    (____  / |__|    \___  >       \___/   \____/  |__| \____ |  
        \/       \/       \/       \/      \/               \/              \/                                  \/  ";
                Console.WriteLine(title);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();


            }
            static void EndGame()
                //The end of the game (nope)
            {
            }

        //Ask player for a name
        static void NameCharacter()
        {
            Console.WriteLine("Welcome to Desecrate Void");
            Console.WriteLine("What is your character's name? Choose wisely as you cannot change this later.");
            CharacterName = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("From now on, your name is \"" + CharacterName + "\"");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press any key to continue...");
            Console.ResetColor(); 
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }

        //The actual start of the game, first choices
        static void Choice()
        {
            for (int section = 1; section <= 13; section++)
            {
                string input = "";

                switch (section)
                {
                    case 1:
                        //Part One

                        Console.WriteLine(PartOne[0]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            Inventory.Add("Scrap");
                            Score = Score + 1;
                            goto case 2;
                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartOne[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            Score = Score + 1;
                            goto case 3;
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 1;
                        }
                                                        //END OF 1


                    case 2:
                        //Chose: Scrap

                        Console.WriteLine(PartTwo[0]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score + 1;
                            goto case 4;

                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartTwo[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Inventory.Add("Hyper Beacon");
                            Score = Score + 1;
                            goto case 6;
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 2;
                        }


                    case 3:
                        //Chose: Signal

                        Console.WriteLine(PartThree[0]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score + 2;
                            goto case 7;

                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartThree[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score - 1;
                            goto case 11;
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 3;
                        }
                                                    //END OF 2


                            case 4:
                        //Chose: Scrap,Repair

                        Console.WriteLine(PartFour[0]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartFour[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Inventory.Add("Hyper Beacon");
                            Score = Score + 2;
                            goto case 6;

                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartFour[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            DeathCause = ("Giving up (???)");
                            Score = Score - 1;
                            goto case 666;
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 4;
                        }

                            case 5:
                        //Chose: Scrap,Repair,Beacon

                        Console.WriteLine(PartFive[0]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartFive[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Inventory.Add("Used Medical Supplies");
                            Score = Score + 2;
                            goto case 8; 

                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartFive[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score - 1;
                            goto case 9; 
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 5;
                        }


                            case 6:
                        //Chose: Signal

                        Console.WriteLine(PartSix[0]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        goto case 12; //na


                            case 7:
                        //Chose: Signal, hill

                        Console.WriteLine(PartSeven[0]);
                        Console.WriteLine("\nAs soon as you approach, she asks: \"Wait, aren't you " + CharacterName + "? From the freigter!\"\na= Ask: \"Does that spaceship work?\", b= Ask \"Are you hurt?\", c= Ask: \"How do you know me?\"");

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartSeven[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score + 1;
                            goto case 5; 

                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartSeven[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score + 2;
                            goto case 5; 
                        }
                        else if (input == "c")
                        {
                            Console.WriteLine(PartSeven[3]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score + 1;
                            goto case 5; 
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 7;
                        }

                    case 8:
                        //Chose: Scrap,Repair,Beacon

                        Console.WriteLine(PartEight[0]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        goto case 420; //na

                    case 9:
                        //Chose: Scrap,Repair,Beacon

                        Console.WriteLine(PartNine[0]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        goto case 420; //na

                    case 13:
                        //Chose: Scrap,Repair,Beacon

                        Console.WriteLine(PartThirteen[0]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        goto case 420; //na

                    case 10:
                        //Chose: Scrap

                        Console.WriteLine(PartTen[0]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartTen[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score + 1;
                            goto case 9;

                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartTen[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            DeathCause = ("Brain eaten by some sort of slug");
                            Inventory.Add("Medical Supplies");
                            Inventory.Add("Money");
                            Inventory.Add("Tools");
                            Inventory.Add("Food");
                            Score = Score - 1;
                            goto case 666;
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 10;
                        }

                    case 11:
                        //Chose: Signal, hill

                        Console.WriteLine(PartEleven[0]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartEleven[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            DeathCause = ("Eaten alive by an alien lifeform");
                            Score = Score - 1;
                            goto case 666;

                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartEleven[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score + 1;
                            goto case 10;
                        }
                        else if (input == "c")
                        {
                            Console.WriteLine(PartEleven[3]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            DeathCause = ("Trying to pet a cute alien");
                            Score = Score - 1;
                            goto case 666;
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 11;
                        }

                    case 12:
                        //Chose: Scrap

                        Console.WriteLine(PartTwelve[0]);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartTwelve[1]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Score = Score + 1;
                            goto case 13;

                        }
                        else if (input == "b")
                        {
                            Console.WriteLine(PartTwelve[2]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            DeathCause = ("Beacon exploded in your face");
                            Score = Score - 1;
                            goto case 666;
                        }

                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"a\" or \"b\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 12;
                        }

                    case 666:
                        //Game Over

                        Console.WriteLine("You died!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Items you found:");
                        foreach (string item in Inventory)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\nScore: " + Score, "");
                        Console.WriteLine("Cause of death: " + DeathCause + "");
                        Console.ResetColor();
                        Console.WriteLine("Type \"retry\" to start over, ");
                        Console.WriteLine("Type \"exit\" to exit");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "exit")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Environment.Exit(0);
                            Console.Clear();
                            break;
                        }
                        else if (input == "retry")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                                Inventory.Remove("Food");
                                Inventory.Remove("Scrap");
                                Inventory.Remove("Medical Supplies");
                                Inventory.Remove("Tools");
                                Inventory.Remove("Hyper Beacon");
                                Inventory.Remove("Food");
                                Inventory.Remove("Used Medical Supplies");
                                Inventory.Remove("Money");
                                Score = 0;
                            goto case 1;
                        }
                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"exit\" or \"retry\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 666;
                        }

                    case 420:
                        //Victory

                        Console.WriteLine("You win!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Items you found:");
                        foreach (string item in Inventory)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\nScore: " + Score, "");
                        Console.ResetColor();
                        Console.WriteLine("Type \"retry\" to start over, ");
                        Console.WriteLine("Type \"exit\" to exit");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        if (input == "exit")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Environment.Exit(0);
                            Console.Clear();
                            break;
                        }
                        else if (input == "retry")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ResetColor(); Console.ReadKey();
                            Console.Clear();
                            Inventory.Remove("Food");
                                Inventory.Remove("Scrap");
                                Inventory.Remove("Medical Supplies");
                                Inventory.Remove("Tools");
                                Inventory.Remove("Hyper Beacon");
                                Inventory.Remove("Food");
                                Inventory.Remove("Used Medical Supplies");
                                Inventory.Remove("Money");
                            Score = 0;
                            goto case 1;
                        }
                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Please input either \"exit\" or \"retry\"");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            goto case 666;
                        }
                }
            }
        }
    }
}
class Item { }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();

        }
    }
}