using CommonAlgorithms.Interface;
using System;

namespace CommonAlgorithms.Impementation
{
    public class InputReader : IInputReader
    {
        public string CommaSeparatedString()
        {
            Console.Write("Comma Separated strings: ");
            string input = Console.ReadLine();
            return input;
        }

        public string SpaceSeparatedString()
        {
            Console.Write("Space Separated strings: ");
            string input = Console.ReadLine();
            return input;
        }

        public string InputString()
        {
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();
            return input;
        }

        public string InputString(string message)
        {
            Console.Write($"{message}: ");
            string input = Console.ReadLine();
            return input;
        }

        public int[] ArrayIntegerReader()
        {
            Console.Write("Number Of values: ");
            int numberOfInput = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[numberOfInput];

            Console.WriteLine("Input values: ");

            for (int i = 0; i < numberOfInput; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }

            return input;
        }

        public string[] ArrayStringReader()
        {
            Console.Write("Number Of strings: ");
            int numberOfInput = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[numberOfInput];

            Console.WriteLine("Input strings: ");

            for (int i = 0; i < numberOfInput; i++)
            {
                input[i] = Console.ReadLine();
            }

            return input;
        }
    }
}
