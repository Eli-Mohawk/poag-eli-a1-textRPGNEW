// displays the title (it looks wierd rn but it works)
Console.WriteLine(" ____            _                        _ _             ");
Console.WriteLine("|  _ \\ ___  __ _| |_ __ _____      ____ _| | | _____ _ __ ");
Console.WriteLine("| |_) / _ \\/ _` | | '_ ` _ \\ \\ /\\ / / _` | | |/ / _ \\ '__|");
Console.WriteLine("|  _ <  __/ (_| | | | | | | \\ V  V / (_| | |   <  __/ |   ");
Console.WriteLine("|_| \\_\\___|\\__,_|_|_| |_| |_|\\_/\\_/ \\__,_|_|_|\\_\\___|_|   ");
Console.WriteLine("");
Console.WriteLine("----------------------------------");

// asks for the players name for a later ending
Console.WriteLine("Before we begin, please type your name below.");
String userName = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"Thank you {userName}, the game will begin shortly.");

// displays the intro lore after a breif pause
Console.WriteLine("");
Thread.Sleep(1000);
Console.WriteLine("3");
Thread.Sleep(1000);
Console.WriteLine("2");
Thread.Sleep(1000);
Console.WriteLine("1");
Thread.Sleep(1000);
Console.WriteLine("");
Console.WriteLine("You wake up to find yourself in a massive empty field.");
Console.WriteLine("You wonder how you got here, but realise it's not important right now.");
Console.WriteLine("Far into the distance you can just barely see what looks to be a town.");
Console.WriteLine("Do you walk towards the distant town?");
Console.WriteLine("Type [yes] or [no]:");

String journey1 = Console.ReadLine();
if (journey1 == "no")
{
    Console.WriteLine("");
    Console.WriteLine("You decide not to travel to the town due to its distance.");
    Console.WriteLine("How long do you want to stay at the place you woke up at?");
    Console.WriteLine("Type the number of hours you want to stay for.");

    // turns the number string into a real number for conversion into days if you choose 24 or more hours
    String hours = Console.ReadLine();
    float hoursNumber = float.Parse(hours);
    float daysNumber = hoursNumber / 24;

    if (hoursNumber < 24)
    {
        Console.WriteLine("");
        Console.WriteLine($"You decide to relax in the field for {hoursNumber} hour(s).");
        Console.WriteLine("");
        Console.WriteLine($"After the {hoursNumber} hour(s) passed, you fall asleep.");
        Console.WriteLine("You inhaled a toxic chemical produced by the flowers while sleeping.");
        Console.WriteLine("THE END [0.5/11]");
        Console.WriteLine("Your choice was an illusion.");
    }
    else if (hoursNumber >= 24)
    {
        Console.WriteLine("");
        Console.WriteLine($"You decide to relax in the field for {daysNumber} day(s).");
        Console.WriteLine("");
        Console.WriteLine($"During your {daysNumber} day(s) of waiting, you starve.");
        Console.WriteLine("THE END [1/11]");
        Console.WriteLine("Your choice was an illusion, and you still chose wrong.");
    }
    else
    {
        Console.WriteLine("So lazy you can't even type correctly... Shameful.");
    }
}
// after this the game splits into two paths depending on if you chose stay or continue.
else if (journey1 == "yes")
{
    Console.WriteLine("");
    Console.WriteLine("You decide to travel to the distant town. After several hours, you finally reach it.");
    Console.WriteLine("When you arive, you notice that there are no people to be found. After checking multiple homes, you realise that ");
    Console.WriteLine("the entire town has been abandoned.");
    Console.WriteLine("You begin wondering if you should continue to travel in hopes of finding somewhere else with people, ");
    Console.WriteLine("or stay in the town for a while to rest.");
    Console.WriteLine("Will you stay in the town or will you continue your journey?");
    Console.WriteLine("Type [stay] or [continue]:");

    String journey2 = Console.ReadLine();
    if (journey2 == "stay")
    {
        Console.WriteLine("");
        Console.WriteLine("You decide to stay in the town for a while.");
        Console.WriteLine("After a short rest and taking some food, you question if you should stay incase someone returns, ");
        Console.WriteLine("or if you should continue travelling.");
        Console.WriteLine("Type [stay] or [continue]:");

        String hermit1 = Console.ReadLine();
        if (hermit1 == "stay")
        {
            Console.WriteLine("");
            Console.WriteLine("You decide to wait a while longer. The town is running low on supplies, and still, no one has come.");
            Console.WriteLine("You are once again wondering if you should stay or continue on your original journey.");
            Console.WriteLine("Type [stay] or [continue]:");

            String hermit2 = Console.ReadLine();
            if (hermit2 == "stay")
            {
                Console.WriteLine("");
                Console.WriteLine("You decide that you will stay in the abandoned town for as long as you are able.");
                Console.WriteLine("After a few days, the towns supplies have run out. Will you Leave or Stay?");
                Console.WriteLine("Type [stay] or [continue]:");

                String hermit3 = Console.ReadLine();
                if (hermit3 == "stay")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You made your choice...");
                    Console.WriteLine("THE END [2/11]");
                    Console.WriteLine("You made your choice.");
                }
                else if (hermit3 == "continue")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You finally decide to continue your journey, but it's to late.");
                    Console.WriteLine("THE END [3/11]");
                    Console.WriteLine("You shouldn't have stayed so long.");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Learn how to type and try again");
                }
            }
            else if (hermit2 == "continue")
            {
                Console.WriteLine("");
                Console.WriteLine("You finally decide to leave the town.");
                Console.WriteLine("You continue travelling for a long time, but never find another town.");
                Console.WriteLine("Eventually, you starve.");
                Console.WriteLine("THE END [4/11]");
                Console.WriteLine("But is this truely the end?.");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Learn how to type and try again");
            }
        }
        else if (hermit1 == "continue")
        {
            Console.WriteLine("");
            Console.WriteLine("You feel that moving on is the best choice. Don't want to get to comfortable.");
            Console.WriteLine("Hours pass, but you still haven't seen anything other than grass. You are beginning to wonder if you should continue.");
            Console.WriteLine("Type [continue] or [return]:");

            String hermit2b = Console.ReadLine();
            if (hermit2b == "continue")
            {
                Console.WriteLine("");
                Console.WriteLine("You travel for a long time, but it feels like you have been going around in circles.");
                Console.WriteLine("Type [walk] or [look]");

                String hermit3b = Console.ReadLine();
                if (hermit3b == "walk")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You continue walking, and walking, and walking.");
                    Console.WriteLine("THE END [5/11]");
                    Console.WriteLine("Step, step, step, step, step, step, step, step, step, step. It never ends.");
                }
                else if (hermit3b == "look")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You look behind you. The town is only a few minutes of walking away.");
                    Console.WriteLine("You're in a loop.");
                    Console.WriteLine("THE END [6/11]");
                    Console.WriteLine("You should have left while it was deactivated.");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Learn how to type and try again");
                }
            }
            else if (hermit2b == "return")
            {
                Console.WriteLine("");
                Console.WriteLine("You decide to make your way back to the town. Maybe you can get more food.");
                Console.WriteLine("THE END [7/11]");
                Console.WriteLine("It would have been faster to stay there from the start.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Learn how to type and try again");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Learn how to type and try again");
        }
    }
    // after this question, the game splits into 4 paths that give different endings.
    else if (journey2 == "continue")
    {
        Console.WriteLine("");
        Console.WriteLine("You decide that you should take the chance and continue travelling.");
        Console.WriteLine("Your gamble paid off! You can see a hill slowly come into your field of view. ");
        Console.WriteLine("There seems to be a small hut sitting on the hill.");
        Console.WriteLine("After arriving at the hut, you find a map. The map has three X's on it.");
        Console.WriteLine("Type [left], [right], [bottom], or [stay]:");

        String journey3 = Console.ReadLine();
        // 
        if (journey3 == "left")
        {
            Console.WriteLine("");
            Console.WriteLine("After walking towards the X to the left, you start becoming very tired.");
            Console.WriteLine("You wake up to find yourself in a massive empty field.");
            Console.WriteLine("You wonder how you got here, but realise it's not important right now.");
            Console.WriteLine("Far into the distance you can just barely see what looks to be a town.");
            Console.WriteLine("Do you walk towards the distant town?");
            Console.WriteLine("THE END [8/11]");
            Console.WriteLine("'I feel like I've forgotten something important.'");
        }
        else if (journey3 == "right")
        {
            Console.WriteLine("");
            Console.WriteLine("You go towards the X on the right of the map.");
            Console.WriteLine("After walking for a long time, you look back to realise that you are still very close to the hut.");
            Console.WriteLine("You've been trapped in a loop.");
            Console.WriteLine("THE END [9/11]");
            Console.WriteLine("For some reason, it seems like the loop is being powered by something.");
        }
        else if (journey3 == "bottom")
        {
            Console.WriteLine("");
            Console.WriteLine("You follow the map towards the bottom X. When you reach the spot, you find a hatch in the ground.");
            Console.WriteLine("After opening the hatch, you discover a room with many books. You can count 213, but there is an empty space for one more.");
            Console.WriteLine("You skim through one of the books titled 'Matt Burton'. It seems to be full of information about this persons life.");
            Console.WriteLine("After checking several other books, you realise that they are all about different people's lives.");
            Console.WriteLine("Shortly after, you feel a sharp pain and start bleeding heavily as the world fades to black.");
            Console.WriteLine("THE END [10/11}");
            Console.WriteLine("If those people are real, it would be almost enough to fill a town.");
        }
        else if (journey3 == "stay")
        {
            Console.WriteLine("");
            Console.WriteLine("You stay in the hut and discover a list with 213 different names.");
            Console.WriteLine("The names somehow seem familier to you, like you used to know them.");
            Console.WriteLine("Shortly after, you feel a sharp pain and start bleeding heavily as the world fades to black.");
            Console.WriteLine("THE END [11/11]");
            Console.WriteLine($"'{userName} has been added to the list. That makes 214/214.'");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Learn how to type and try again");
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Learn how to type and try again");
    }
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Learn how to type and try again");
}