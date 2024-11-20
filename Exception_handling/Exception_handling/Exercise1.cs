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
                InputResult userInputData = GetUserInputs();

                if (!userInputData.Sucess)
                {
                    Console.WriteLine(userInputData.Message);
                }
                if (userInputData.Sucess)
                {
                    success = true;
                    int answer = Divide(userInputData.Result[0], userInputData.Result[1]);
                    Console.WriteLine("Result: " + answer);
                }

                //try
                //{
                //    int[] inputs = GetUserInputs();
                //    int answer = Divide(inputs[0], inputs[1]);
                //    Console.WriteLine("Result: " + answer);
                //    success = true;

                //}
                //catch (FormatException)
                //{
                //    Console.WriteLine("invalid inputs, please try some more");
                //}
                //catch (DivideByZeroException)
                //{
                //    Console.WriteLine("invalid inputs, can't divide by zero, please try some more");
                //}
                //catch (NegativeIntegerInputException ex ) 
                //{
                //    Console.WriteLine(ex.Message);
                //}
            }
        }
        private static InputResult GetUserInputs()
        {
            
            int[] inputArray = new int[2];
            InputResult output = new InputResult();

            Console.WriteLine("write a first input (divisor)");
            string numberOne = Console.ReadLine();
            if (!int.TryParse(numberOne, out inputArray[0]))
            {
                output.Message = "Attempted to assign an invalid number";
                output.Sucess = false;;
            }
            else
            {
                output.Sucess = true;
                output.Result[0] = int.Parse(numberOne);
            }


            Console.WriteLine("write a second input (dividend)");
            string numberTwo = Console.ReadLine();
            if (!int.TryParse(numberTwo, out inputArray[1]))
            {
                output.Message = "Attempted to assign an invalid number";
                output.Sucess = false;
            }
            else
            {
                output.Sucess = true;
                output.Result[1] = int.Parse(numberTwo);
            }

            if (output.Result[0] < 0 || output.Result[1] < 0)
            {
                output.Message += " Entered negative inuts";
                output.Sucess = false;
            };
            if (output.Result[1] == 0)
            {
                output.Message += " Attempted to divide by zero";
                output.Sucess = false;
            };

            if (output.Message.Length > 1) output.Result = null;

            return output;
        }
    }
}
