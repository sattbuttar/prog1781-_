using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3SatwinderSinghP2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(" Enter the first number ");
            double one = double.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the second number ");
            double two = double.Parse(Console.ReadLine());


            try { 

            Console.WriteLine(" Enter 6 for addition, 7 for suctraction, 8 for multiplication and 9 for division ");
            int cal = int.Parse(Console.ReadLine());

              if (cal == 6)
              {
                
                double r = one + two;
                Console.WriteLine("result = " + r);

              }


              if (cal == 7)
              {

                double r = one - two;
                Console.WriteLine("result = " + r);

              }

              if (cal == 8)
              {

                double r = one * two;
                Console.WriteLine("result = " + r);

              }

              if (cal == 9)
              {

                double r = one / two;
                Console.WriteLine("result = " + r);

              }

            }
            catch(FormatException x)
            {
                Console.WriteLine("Enter valid value for the operation selection");
            }
            finally
            {

            }

        }
    }
}
