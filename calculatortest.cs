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
            Console.WriteLine("Select a function");
            Console.WriteLine("1.* 2./ 3. - 4.+");
            string input = Console.ReadLine();
            int result;
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

                        case 2:
                            Console.WriteLine("First number");
                            string input1 = Console.ReadLine();
                            Console.WriteLine("Second number");
                            string input2 = Console.ReadLine();
                            int total = Convert.ToInt32(input1) / Convert.ToInt32(input2);
                            Console.WriteLine("Your total is : {0} ", total);

                        case 3:
                            Console.WriteLine("First Number");
                            string input1 = Console.ReadLine();
                            Console.WriteLine("Second Number");
                            string input2 = Console.ReadLine();
                            int total = Convert.ToInt32(input1) - Convert.ToInt32(input2);
                            Console.WriteLine("Your total is : {0} ", total);

                        case 4:
                            Console.WriteLine("First Number");
                            string input1 = Console.ReadLine();
                            Console.WriteLine("Second Number");
                            string input2 = Console.ReadLine();
                            int total = Convert.ToInt32(input1) + Convert.ToInt32(input2);
                            Console.WriteLine("Your total is : {0} ", total);

                        case 5:
                            Console.WriteLine("Bye!");
              
                            loop = 1;
                            break;
                        default:
                            Console.WriteLine("Sorry try again");
                            break;
                    }

                }           

                }
                Console.Read();
            }
        }
    }

