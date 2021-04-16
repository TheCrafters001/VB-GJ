using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJoltAPI;

namespace TestAPI_CS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Add Score");
            Console.WriteLine("2. Get Rank (Scores)");
            Console.WriteLine("3. Tables (Scores)");
            Console.WriteLine("4. Get Scores");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter your Game Jolt Username: ");
                string un = Console.ReadLine();
                Console.WriteLine("Enter your Game Jolt Token:    ");
                string token = Console.ReadLine();
                Console.WriteLine("Enter a number:                ");
                string number = Console.ReadLine();
                Score.Add("607194", "2f1222b54cb623b7ad8fb55eea58869c", number, 30, un, token);
            }
            Main();
        }
    }
}
