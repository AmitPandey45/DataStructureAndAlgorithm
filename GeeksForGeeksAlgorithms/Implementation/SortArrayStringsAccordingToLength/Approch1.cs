using CommonAlgorithms.Interface;
using System;
using System.Linq;

namespace GeeksForGeeksAlgorithms.Implementation.SortArrayStringsAccordingToLength
{
    public class Approch1 : IProgram
    {
        public void Execute()
        {
            Console.Write("Number Of strings: ");
            int numberOfInput = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[numberOfInput];

            Console.WriteLine("Input strings: ");

            for (int i = 0; i < numberOfInput; i++)
            {
                input[i] = Console.ReadLine();
            }

            this.DisplayStringsAccordingToLength(input);
        }

        private void DisplayStringsAccordingToLength(string[] input)
        {
            string[] orderOutput = input
                .OrderBy(s => s.Length)
                .Select(s => s).ToArray();

            Console.WriteLine(string.Join(" ", orderOutput));
        }
    }
}
