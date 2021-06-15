using System;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                try
                {
                    Console.WriteLine("Please enter num1: ");
                    string num1str = Console.ReadLine();
                    int num1 = int.Parse(num1str);

                    Console.WriteLine("Please enter num2: ");
                    string num2str = Console.ReadLine();
                    int num2 = int.Parse(num2str);

                    Console.WriteLine("Num1 / Num2: {0}", num1 / num2);

                }
                catch(System.FormatException exc) //6.1
                {
                    Console.WriteLine("Not a number :/");

                }
                catch(System.OverflowException ex)
                {
                    Console.WriteLine("Number is too large or small. ");
                }
                catch (Exception e)
                {
                    //Console.WriteLine("Error!"); //3.1
                    Console.WriteLine("Error! " + e.Message + "\nException type: " + e.GetType()); //4.1
                }
                finally
                {
                    Console.WriteLine("This section always executes!"); //5.1

                }

                Console.WriteLine("Do another? y/n");
                doAnother = Console.ReadLine();

            } while (doAnother == "y");
        }
    }
}
