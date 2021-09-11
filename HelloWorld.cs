using System; 
namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! My Name is Fukokami which means 'Misfortune God'. I am a fantasy/horror writer who wants to learn game development.");

            Console.WriteLine("The name of the protagonist for my latest novel is Ichiro Fukokami, a boy who makes a deal with a demon to save his friends.");

            Console.WriteLine("I have a TikTok account with 90 followers however one day I want to have 100k");

            Console.WriteLine("My goal is to be a game developer and a known author/writer. I like fantasy (dark/light), horror, and romance stories");

            Console.WriteLine("I want to write hundreds of r/nosleep stories however only my best works will get popular.");

            Console.WriteLine("A program can hold a infinite amount of statements");

            //How to write a expression
            Console.WriteLine("Hi " + "User: " + "Fukokami");

            //How to create a variable
            string witch;
            witch = "Klaus Malebranche";

            Console.WriteLine("A powerful witch in my story who is the son of the Legendary Witch God of Japan is " + witch);

            //Consolas and Telim Bread Machine
            string breadreciever;
            Console.WriteLine("The Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            breadreciever = Console.ReadLine();

            Console.WriteLine("Noted: " + breadreciever + " has recieved the bread!");

            //Potion Maker
            String potion;
            Console.WriteLine("What kind of potion do you need?");
            potion = Console.ReadLine();
            Console.WriteLine("The " + potion + " potion is ready.");

            String Character;
            Console.WriteLine("Who is the " + potion +  " potion for?");
            Character = Console.ReadLine();

            Console.WriteLine("Noted: " + Character + " has recieved the " + potion + " potion!");

            //Comment Challenge

            Console.WriteLine("What kind of thing are we talking about?");
            //Write the Object you Are Talking About
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            /* This comment describes the condition of the item */
            string b = Console.ReadLine();
            string c = "Doom"; //Simple Word String 
            string d = "3000"; //int written as string
            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");


        }

    }
}
