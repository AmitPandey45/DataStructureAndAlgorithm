using CommonAlgorithms.Interface;
using System;

namespace GeeksForGeeksAlgorithms.Implementation.SparseSearch
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
            string input = this.inputReader.CommaSeparatedString();
            string[] inputArray = input.Split(",");

            string searchString = this.inputReader.InputString("Enter the search string");

            this.DisplaySearchIndexOfAString(inputArray, searchString);
        }

        private void DisplaySearchIndexOfAString(string[] inputArr, string searchString)
        {
            int index = this.Search(inputArr, 0, inputArr.Length - 1, searchString);

            if (index != -1)
            {
                Console.WriteLine($"{searchString} found at index = {index}");
            }
            else
            {
                Console.WriteLine($"{searchString} can not found");
            }
        }

        private int Search(string[] inputArr, int firstIndex, int lastIndex, string searchString)
        {
            if (firstIndex > lastIndex)
            {
                return -1;
            }

            int mid = (firstIndex + lastIndex) / 2;

            if (string.IsNullOrEmpty(inputArr[mid]))
            {
                int left = mid - 1;
                int right = mid + 1;

                while (true)
                {
                    if (left < firstIndex && right > lastIndex)
                    {
                        return -1;
                    }

                    if (left >= firstIndex && !string.IsNullOrEmpty(inputArr[left]))
                    {
                        mid = left;
                        break;
                    }

                    if (right <= lastIndex && !string.IsNullOrEmpty(inputArr[right]))
                    {
                        mid = right;
                        break;
                    }

                    left--;
                    right++;
                }
            }

            if (inputArr[mid].Equals(searchString))
            {
                return mid;
            }
            else if (searchString.CompareTo(inputArr[mid]) < 0)
            {
                mid = this.Search(inputArr, firstIndex, mid - 1, searchString);
            }
            else if (searchString.CompareTo(inputArr[mid]) > 0)
            {
                mid = this.Search(inputArr, mid + 1, lastIndex, searchString);
            }

            return mid;
        }
    }
}
