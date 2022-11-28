using CommonAlgorithms.Impementation;
using CommonAlgorithms.Interface;
using System;
using PermutationOfAString = GeeksForGeeksAlgorithms.Implementation.PermutationOfAString;
using SortArrayStringsAccordingToLength = GeeksForGeeksAlgorithms.Implementation.SortArrayStringsAccordingToLength;
using SortArrayStringsByDictionaryOrder = GeeksForGeeksAlgorithms.Implementation.SortArrayStringsByDictionaryOrder;
using SortStringOfChars = GeeksForGeeksAlgorithms.Implementation.SortStringOfChars;
using AlternateUpperLowerStringSort = GeeksForGeeksAlgorithms.Implementation.AlternateUpperLowerStringSort;
using SparseSearch = GeeksForGeeksAlgorithms.Implementation.SparseSearch;
using ReverseStringWord = GeeksForGeeksAlgorithms.Implementation.ReverseStringWord;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GeeksForGeeksClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //RemoveHtmlTags();
            //return;
            IInputReader inputReader = new InputReader();
            //IProgram program = new PermutationOfAString.Approach1(inputReader);
            //IProgram program = new SortArrayStringsAccordingToLength.Approach1(inputReader);
            //IProgram program = new SortArrayStringsByDictionaryOrder.Approach1(inputReader);
            //IProgram program = new SortStringOfChars.Approach1(inputReader);
            //IProgram program = new SparseSearch.Approach1(inputReader);
            IProgram program = new ReverseStringWord.Approach1(inputReader);

            program.Execute();

            //int[] values = inputReader.ArrayIntegerReader();
            //SortInteger(values);

            //string input = inputReader.SpaceSeparatedString();
            //SortWord(input.Split(' '));

            //ModifyTheListData();

            PrintTheFormat(4);

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

        static void ModifyTheListData()
        {
            var templateParameteres = new List<EmailTemplateParameters>();

            var parameter = new EmailTemplateParameters
            {
                MemberFirstName = "Fname",
                MemberLastName = "Lname",
                ClassificationTypeName = "User",
                ClassificationUpdatedDate = "20-05-2022",
                CommitteeDesignation = "A23"
            };

            templateParameteres.Add(parameter);

            TemplateParameterHelper.SetClassificationTypeNamePropertyToProducer(templateParameteres);

            //templateParameteres.Select(s => { s.ClassificationTypeName = "Producer"; return s; }).ToList();
        }

        static void PrintTheFormat(int input)
        {
            int counter = 1;

            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{counter} ");
                    counter++;
                }

                Console.WriteLine();
            }
        }

        static void RemoveHtmlTags()
        {
            string html = "subgroup average (<img src=\" / HTTP / IMAGES / E2587 - 16R21E01_8.gif\">), n";
            Regex HtmlRegex = new Regex("<.*?>", RegexOptions.Compiled);
            string value = HtmlRegex.Replace(html, string.Empty);
        }
    }

    public class EmailTemplateParameters
    {
        public string MemberFirstName { get; set; }

        public string MemberLastName { get; set; }

        public string ClassificationUpdatedDate { get; set; }

        public string CommitteeDesignation { get; set; }

        public string ClassificationTypeName { get; set; }
    }

    public static class TemplateParameterHelper
    {
        public static void SetClassificationTypeNamePropertyToProducer(List<EmailTemplateParameters> templateParameteres)
        {
            templateParameteres
                .Select(s => { s.ClassificationTypeName = "Producer"; return s; })
                .ToList();
        }
    }
}
