using CommonAlgorithms.Interface;
using System;
using System.Linq;

namespace GeeksForGeeksAlgorithms.Implementation.SortArrayStringsByDictionaryOrder
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
            string input = this.inputReader.SpaceSeparatedString();

            this.DisplayStringsByDictionaryOrder(input.Split(" "));
        }

        private void DisplayStringsByDictionaryOrder(string[] input)
        {
            string[] orderedOutput = input
                .OrderBy(s => s)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(" ", orderedOutput));
        }
    }
}
