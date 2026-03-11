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
            SubtractNums(10, 3);
            Console.WriteLine(isStringLonger("test", 8));

        }

        private static void printGreeting (string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        private static void SubtractNums(int num1, int num2)
        {
            int result;
            result = num1 - num2;
               Console.WriteLine(result);
        }

        private static bool isStringLonger(string word, int number)
        {
            
            return word.Length > number;        }
    }
}
