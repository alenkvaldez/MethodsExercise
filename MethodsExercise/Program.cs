namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer =  num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num 2, int num 3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {

            var amountOfAlbums = Sum(2,6);
            var amountOfRecords = Multiply(3, 4, 6);

            // EXERCISE 1
            Name: Q

            Favorite Color: Blue

            Favorite Animal: Walrus

            Favorite Artist: Tupac
            
            Console.WriteLine("Hello, what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine("Hello, what is your first name?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color}, is dope, what is your fave animal");
            var animal = Console.ReadLine();

            Console.WriteLine($"nice, who is your fave artist?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("----")

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine("$Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Artist: {artist}");

            // EXERCISE 2
        }
    }
}