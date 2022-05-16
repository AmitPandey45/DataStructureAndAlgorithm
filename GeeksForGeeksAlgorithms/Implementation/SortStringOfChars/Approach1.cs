using CommonAlgorithms.Interface;
using System;
using System.Linq;

namespace GeeksForGeeksAlgorithms.Implementation.SortStringOfChars
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
            string input = this.inputReader.InputString();

            this.DisplaySortStringOfCharacters(input.ToCharArray());
        }

        private void DisplaySortStringOfCharacters(char[] input)
        {
            char[] orderedOutput = input
                .OrderBy(c => c)
                .Select(s => s)
                .ToArray();

            Console.WriteLine(new string(orderedOutput));
        }
    }
}
