using CommonAlgorithms.Interface;
using System;
using PermutationOfAString = GeeksForGeeksAlgorithms.Implementation.PermutationOfAString;
using SortArrayStringsAccordingToLength = GeeksForGeeksAlgorithms.Implementation.SortArrayStringsAccordingToLength;

namespace GeeksForGeeksClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //IProgram program = new PermutationOfAString.Approach1();
            IProgram program = new SortArrayStringsAccordingToLength.Approch1();

            program.Execute();

            Console.Read();
        }
    }
}
