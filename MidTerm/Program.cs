using System;

class Program
{
    static void Main()
    {
        // Başlangıç: Uyanış
        Console.WriteLine("A bright light blinds your eyes. You slowly regain consciousness and realize you are in a hospital room.");
        Console.Write("A doctor and a nurse are by your side. Doctor: Do you remember your name?: ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"\nDoctor: \"Great, {playerName}. You've been in a coma for a while, but you're doing well now. You just need to rest.\"");

        AskMemoryQuestion();
        AskCorridorQuestion();
        AskRoomQuestion();
        AskEscapeQuestion();
        AskFinalChoice();

        Console.WriteLine("\nYour story ends here. Thank you for playing!");
    }

    static void AskMemoryQuestion()
    {
        Console.WriteLine("\nHowever, your head begins to ache, and blurry images flash before your eyes...");
        Console.WriteLine("1) A broken car and screams.");
        Console.WriteLine("2) A dark shadow.");
        Console.WriteLine("3) A clock (3:15).");
        Console.Write("Which scene feels more familiar to you? (1, 2, 3): ");

        char memoryChoice = ' ';
        while (memoryChoice != '1' && memoryChoice != '2' && memoryChoice != '3')
        {
            memoryChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (memoryChoice == '1')
            {
                Console.WriteLine("\nA car crash flashes in your mind. Metal clashing, screams... This must be your accident.");
            }
            else if (memoryChoice == '2')
            {
                Console.WriteLine("\nA shadow looms over you. It feels terrifying yet oddly familiar.");
            }
            else if (memoryChoice == '3')
            {
                Console.WriteLine("\nA clock appears. 3:15. You can't figure out why this time sticks in your memory.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            }
        }
    }

    static void AskCorridorQuestion()
    {
        Console.WriteLine("\nThe doctor leaves the room. As you wander the corridor, you hear a phone ringing.");
        Console.WriteLine("You find the phone and see a message on the screen:");
        Console.WriteLine("\"If you want to learn the truth, go to the 3rd floor. They're lying to you.\"");

        Console.Write("\nWhat will you do?: ");
        Console.WriteLine();
        Console.WriteLine("1) Follow the message and go to the 3rd floor.");
        Console.WriteLine("2) Go back to the doctor and show them the message.");

        char corridorChoice = ' ';
        while (corridorChoice != '1' && corridorChoice != '2')
        {
            corridorChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (corridorChoice == '1')
            {
                Console.WriteLine("\nYou head to the 3rd floor. There, you find a dark corridor and a locked room. You hear faint noises behind the door.");
                Console.WriteLine("You manage to open the door and find old files and documents inside.");
            }
            else if (corridorChoice == '2')
            {
                Console.WriteLine("\nYou show the message to the doctor. The doctor looks surprised and says, \"This must be a joke.\"");
                Console.WriteLine("However, you feel uneasy. You decide to go to the 3rd floor to investigate further.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }
    }

    static void AskRoomQuestion()
    {
        Console.WriteLine("\nInside the room, you find dusty files and old recording devices. As you examine the documents, one name stands out:");
        Console.WriteLine("\"Altair Medical Systems.\"");
        Console.WriteLine("\nThe documents suggest your accident was sabotage, and you were the target. But why? You must find out more.");
    }

    static void AskEscapeQuestion()
    {
        Console.WriteLine("\nYou decide to confront the doctor. However, their behavior makes you even more suspicious.");
        Console.WriteLine("The doctor signals the nurse, and they start chasing you!");

        Console.Write("\nWhat will you do?: ");
        Console.WriteLine();
        Console.WriteLine("1) Run and try to escape the hospital.");
        Console.WriteLine("2) Confront them and try to uncover the truth.");

        char escapeChoice = ' ';
        while (escapeChoice != '1' && escapeChoice != '2')
        {
            escapeChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (escapeChoice == '1')
            {
                Console.WriteLine("\nYou dash through the corridors, desperately searching for an exit. Everything feels like a maze.");
                Console.WriteLine("Finally, you find a way out and escape the hospital.");
            }
            else if (escapeChoice == '2')
            {
                Console.WriteLine("\nYou confront the doctor. \"Tell me the truth!\" you shout. The doctor pauses for a moment before saying, \"We must silence you.\"");
                Console.WriteLine("Security guards arrive, and the situation escalates.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }
    }

    static void AskFinalChoice()
    {
        Console.Write("\nNow you must decide: ");
        Console.WriteLine();
        Console.WriteLine("1) Pursue the truth and confront your past.");
        Console.WriteLine("2) Leave the hospital and start a new life.");

        char finalChoice = ' ';
        while (finalChoice != '1' && finalChoice != '2')
        {
            finalChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (finalChoice == '1')
            {
                Console.WriteLine("\nYou are determined to uncover the truth. You begin investigating the secrets of Altair Medical Systems.");
                Console.WriteLine("This is just the beginning of a larger conspiracy...");
            }
            else if (finalChoice == '2')
            {
                Console.WriteLine("\nYou choose to leave your past behind. You step into a new life, but a sense of unease never leaves you.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }
    }
}
