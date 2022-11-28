using CommonAlgorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksAlgorithms.Implementation.ReverseStringWord
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

            string result = this.ReverseWord(input);

            Console.WriteLine($"Reverse word is : {result}");
        }

        private string ReverseWord(string input)
        {
            var result = new StringBuilder();
            var singleWord = new StringBuilder();
            char[] chars = input.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                singleWord.Append(chars[i]);
                if (chars[i] == ' ')
                {
                    result.Append(this.ReverseString(singleWord.ToString()));
                    singleWord.Clear();
                }
                else if (i == 0)
                {
                    result.Append($" {this.ReverseString(singleWord.ToString())}");
                    singleWord.Clear();
                }
            }

            return result.ToString();
        }

        private string ReverseString(string value)
        {
            char[] chars = value.ToCharArray();
            char temp;
            int start = 0;
            int end = chars.Length - 1;
            while (start <= end)
            {
                temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }

            return new string(chars);
        }
    }
}
