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

            int additionRes = addNumbers(1, 8);
            Console.WriteLine("The result for the addition is: " +  additionRes);

            Book b = new Book("The Hobbit", 310);
            Console.WriteLine("This week's book is " + b.title + " and the number of pages is " + b.pages);

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

        private static int addNumbers(int num1, int num2) {

            int result;
            result = num1 + num2;
            return result;
                
                }
    }
}
