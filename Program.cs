using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "";
            while (menu != "q")
            {
                Menu.PrintMenu();
                Console.WriteLine("Menu Choice: ");
                menu = Console.ReadLine();
                if (menu == "1")
                {
                    Menu.Name();
                }
                if (menu == "2")
                {
                    Menu.Gas();
                }
                if (menu == "3")
                {
                    Menu.Alice();
                }
            }

        }
    }

    class Menu 
    {
        public static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. input/output");
            Console.WriteLine("2. Numeric Types");
            Console.WriteLine("3. Strings");
            Console.WriteLine("Type q to quit");
        }
        public static void Name()
        {
            Console.WriteLine("Please enter your name: ");
            string Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + Name + ", welcome to the program!");
        }

        public static void Gas()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the number of miles you've driven: ");
            int miles = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the amount of gas you used (gallons): ");
            int gas = Convert.ToInt16(Console.ReadLine());
            int mpg = miles/gas;
            Console.WriteLine();
            Console.WriteLine("You get " + Convert.ToString(mpg) + " miles-per-gallon");

        }
        
        public static void Alice()
        {
            string story = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine();
            Console.WriteLine(story);
            Console.WriteLine();
            Console.WriteLine("Please enter what you wish to seach for");
            string search = Console.ReadLine();
            bool result = story.Contains(search, System.StringComparison.CurrentCultureIgnoreCase);
            if (result == true)
            {
                Console.WriteLine();
                Console.WriteLine("The story contains " + search);
            }
            if (result == false)
            {
                Console.WriteLine();
                Console.WriteLine("The story does not contain " + search);
            }
        }
    }
}