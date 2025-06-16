namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to your story!");
            Console.WriteLine("What is your name?");
            
            string name = Console.ReadLine();
            Console.WriteLine("I like that name");
            
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("That is a very pretty color");
            
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Those animals are very interesting");
            
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("Their music is fantastic");

            Console.WriteLine("What is your favorite song by that band?");
            string song = Console.ReadLine();
            Console.WriteLine("Ooo I like that song");
            
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();

            Console.WriteLine("Awesome!, lets write your story!");

            Program.CreateStory(name, color, animal, band, song, food);

        }

        public static void CreateStory(string name, string color, string animal, string band, string song, string food)
        {
            Console.WriteLine(
                $"There once was a {animal} named {name}. They were a {color} {animal} who loved to listen to {band}.");
            
            Console.WriteLine($"{name} wanted to go see {band} play with their best friend.");
            
            Console.WriteLine($"What was the name of {name}'s best friend?");
            string bestFriendName = Console.ReadLine();
            
            Console.WriteLine($"{name} met up with their fellow {animal} {bestFriendName}. They asked {name}, 'Where should we see {band} play?'");

            Console.WriteLine($"What stadium would you like to buy tickets from to see {band}");
            string location = Console.ReadLine();

            Console.WriteLine(
                $"{name} and {bestFriendName} chekced ticket master and saw that {band} was playing at {location} and bought their tickets, they were very excited");
            
            Console.WriteLine($"At the concert, {name} and {bestFriendName} had so much fun. They laughed and sang and ate delicious {food}.");
            Console.WriteLine($"{band} even played {name}'s favorite song {song}! It was a terrific night.");
            Console.WriteLine("The End");
        }
    }
}
