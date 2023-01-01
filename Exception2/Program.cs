using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception2
{
     class Program
    {
        static void Main(string[] args)
        {

            try {
                int o;
                int s;

                Console.WriteLine("Enter number1");
                bool isNumber = Int32.TryParse(Console.ReadLine(), out o);

                if (isNumber)
                {
                    Console.WriteLine("Enter number2");
                    bool isNumberr = Int32.TryParse(Console.ReadLine(), out s);

                    if (isNumberr && s != 0)
                    {
                        int result = o / s;
                        Console.WriteLine("result:" + result);
                        Console.ReadLine();
                    }
                    else
                    {

                        if (s == 0)
                        {
                            Console.WriteLine("number2 must not 0");
                            Console.ReadLine();
                        }
                        Console.WriteLine("run again");
                        Console.ReadLine();
                    }
                }
                Console.WriteLine("number1 must be int");
                Console.ReadLine();
            }

            catch (Exception ex) // other Exceptions 
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();

            }

            
            /*Exception Handling abuse
            Handling the Exception in worst case, bad way 
            The Exception occours then we handling, we must prevent the exception to happen in first way 
          

            try
            {
                Console.WriteLine("Enter number1");
                int oo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number2");
                int ss = Convert.ToInt32(Console.ReadLine());

                int result = oo /ss;
                Console.WriteLine("result:" + result);
                Console.ReadLine();
            }
            catch (FormatException ex) // Entering a char while we aspect a number
            {
                Console.WriteLine("plz enter a number");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();

            }
            catch (OverflowException ex) // Out of rang Exception
            {
                Console.WriteLine("enter small number in the rang of ## and ##");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();

            }
            catch (DivideByZeroException ex) // Divid by a zero Exceptions 
            {
                Console.WriteLine("can't divide by a zero");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();

            }

            catch (Exception ex) // other Exceptions 
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();

            }
              */
        }
    }
}
