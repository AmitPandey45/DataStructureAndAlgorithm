using CommonAlgorithms.Interface;
using System;
using System.Linq;

namespace GeeksForGeeksAlgorithms.Implementation.SortArrayStringsAccordingToLength
{
    public class Approach1 : IProgram
    {
        private readonly IInputReader inputReader;

        public Approach1(IInputReader inputReader)
        {
            this.inputReader = inputReader;
        }

        public void Execute()
        {
            string[] input = this.inputReader.ArrayStringReader();

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
