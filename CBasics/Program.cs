namespace CBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double pi = 3.14;
            bool learningC = true;
            string firstName = "Nicholas";

            string favouriteFilm = "The Factory Girl";

            favouriteFilm = "High School Musical";

            printGreeting(firstName);

        }

        private static void printGreeting (string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }
}
