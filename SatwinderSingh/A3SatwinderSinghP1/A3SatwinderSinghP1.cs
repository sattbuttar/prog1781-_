using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3SatwinderSinghP1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Press 1 to display a list of even numbers starting from 0 ");
                Console.WriteLine("Press 2 to display a sequence of perfect squares starting from 1 ");
                Console.WriteLine("Press 3 to exit ");
                double l = double.Parse(Console.ReadLine());

                if (l == 1)
                {
                    Console.WriteLine(" Type the number of even numbers you want as result ");
                    double m= double.Parse(Console.ReadLine());

                    for (int n = 2; n < 2 *m; n=n+2)
                    {
                        Console.WriteLine(n);
                    }

                }

                
                
                    if (l == 2)
                    {
                        Console.WriteLine("1");
                        do
                        {

                            Console.WriteLine(" Enter 1 to continue and 2 to stop ");
                            char a = char.Parse(Console.ReadLine());

                        } while (Console.ReadLine() != "1");
                        {
                            int d = 1;
                            int f = (d + 1) * (d + 1);
                            Console.WriteLine(f);

                        }
                    }

                    if(l==3)
                    {
                            
                        

                    }



            }
            catch(FormatException o)
            {
                Console.WriteLine("ENTER VALID VALUE");

            }

            finally
            {

            }
               
           
        }
    }
}
