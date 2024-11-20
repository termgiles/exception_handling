using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Exercise1
    {
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static void DivideUserInputs()
        {
            bool success = false;
            while (!success)
            {
                try
                {
                    int[] inputs = GetUserInputs();
                    int answer = Divide(inputs[0], inputs[1]);
                    Console.WriteLine("Result: " + answer);
                    success = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid inputs, please try some more");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("invalid inputs, can't divide by zero, please try some more");
                }
            }
        }
        private static int[] GetUserInputs()
        {
            int[] output = new int[2];
            Console.WriteLine("write a first input (divisor)");
            output[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("write a second input (dividend)");
            output[1] = int.Parse(Console.ReadLine());
            return output;
        }
    }
}
