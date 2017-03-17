using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Your Option");
            Console.WriteLine("1.*  2./  3. -  4.+");
            string input = Console.ReadLine();
            int result;
            int loop = 0;
            while (loop == 0)
            {
                if (int.TryParse(input, out result))
                {
                    switch (result)
                    {

                        case 1:
                            Console.WriteLine("Enter one: ");
                            string input1 = Console.ReadLine();
                            Console.WriteLine("enter two: ");
                            string input2 = Console.ReadLine();
                            int total = Convert.ToInt32(input1) * Convert.ToInt32(input2);
                            Console.WriteLine("Your total is : {0} ", total);
                            break;
                        case 9:
                            Console.WriteLine("Bye");

                            loop = 1;
                            break;
                        default:
                            Console.WriteLine("Sorry");
                            break;
                    }

                }
                else {
                    Console.WriteLine("Nope");
                    loop = 0;

                }
                Console.Read();
            }
        }
    }
}
