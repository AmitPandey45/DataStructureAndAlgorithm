using CommonAlgorithms.Interface;
using System;

namespace GeeksForGeeksAlgorithms.Implementation.AlternateUpperLowerStringSort
{
    public class Approach1
    {
        private readonly IInputReader inputReader;

        public Approach1(IInputReader inputReader)
        {
            this.inputReader = inputReader;
        }

        public void Execute()
        {
            string input = this.inputReader.InputString();

            this.DisplayAlternateUpperLowerStringSort(input);
        }

        private void DisplayAlternateUpperLowerStringSort(string input)
        {

        }
    }
}
