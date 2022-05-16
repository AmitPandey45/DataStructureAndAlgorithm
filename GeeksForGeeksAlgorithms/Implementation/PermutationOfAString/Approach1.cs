using CommonAlgorithms.Interface;
using System;

namespace GeeksForGeeksAlgorithms.Implementation.PermutationOfAString
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
            string answer = string.Empty;
            string input = this.inputReader.InputString();

            Console.WriteLine("All possible strings are : ");
            this.Permute(input, answer);
        }

        private void Permute(string input, string answer)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(answer);
            }

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                string leftInput = input.Substring(0, i);
                string rightInput = input.Substring(i + 1);
                string modifiedInput = leftInput + rightInput;
                this.Permute(modifiedInput, answer + c);
            }
        }
    }
}
