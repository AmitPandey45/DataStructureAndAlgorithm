using CommonAlgorithms.Impementation;
using CommonAlgorithms.Interface;
using System;
using PermutationOfAString = GeeksForGeeksAlgorithms.Implementation.PermutationOfAString;
using SortArrayStringsAccordingToLength = GeeksForGeeksAlgorithms.Implementation.SortArrayStringsAccordingToLength;
using SortArrayStringsByDictionaryOrder = GeeksForGeeksAlgorithms.Implementation.SortArrayStringsByDictionaryOrder;
using SortStringOfChars = GeeksForGeeksAlgorithms.Implementation.SortStringOfChars;
using AlternateUpperLowerStringSort = GeeksForGeeksAlgorithms.Implementation.AlternateUpperLowerStringSort;
using SparseSearch = GeeksForGeeksAlgorithms.Implementation.SparseSearch;

namespace GeeksForGeeksClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputReader inputReader = new InputReader();
            //IProgram program = new PermutationOfAString.Approach1(inputReader);
            //IProgram program = new SortArrayStringsAccordingToLength.Approach1(inputReader);
            //IProgram program = new SortArrayStringsByDictionaryOrder.Approach1(inputReader);
            //IProgram program = new SortStringOfChars.Approach1(inputReader);
            //IProgram program = new SparseSearch.Approach1(inputReader);

            //program.Execute();

            //int[] values = inputReader.ArrayIntegerReader();
            //SortInteger(values);

            string input = inputReader.SpaceSeparatedString();
            SortWord(input.Split(' '));
            
            Console.Read();
        }


        static void SortInteger(int[] values)
        {
            int temp;

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] > values[j])
                    {
                        temp = values[j];
                        values[j] = values[i];
                        values[i] = temp;
                    }
                }
            }

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        static void SortWord(string[] words)
        {
            string temp;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].CompareTo(words[j]) > 0)
                    {
                        temp = words[j];
                        words[j] = words[i];
                        words[i] = temp;
                    }
                }
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
