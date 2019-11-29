using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main()
        {
            List<int> inputNum = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();
            bool isChanged = false;

            while (commands != "end")
            {
                string[] token = commands.Split(" ");
                if (token[0] == "Add" || token[0] == "Remove" || token[0] == "RemoveAt" || token[0] == "Insert")
                {
                    isChanged = true;
                }
                if (token[0] == "Contains")
                {
                    IsContains(inputNum, token);
                }
                if (token[0] == "PrintEven")
                {
                    
                    PrintEven(inputNum);
                }
                if (token[0] == "PrintOdd")
                {
                    PrintOdd(inputNum);
                }
                if (token[0] == "GetSum")
                {
                    GetSumOfNumbersInput(inputNum);
                }
                if (token[0] == "Filter" && token[1] == "<")
                {
                    PrintSmallNumbers(inputNum, token);
                }
                if (token[0] == "Filter" && token[1] == ">")
                {
                    PrintBiggestNumbers(inputNum, token);
                }
                if (token[0] == "Filter" && token[1] == ">=")
                {
                    PrintBiggestOrEqualNumbers(inputNum, token);
                }
                if (token[0] == "Filter" && token[1] == "<=")
                {
                    PrintSmallOrEqualNumbers(inputNum, token);
                }
                if (token[0] == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    inputNum.Add(numberToAdd);
                }
                if (token[0] == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    inputNum.Remove(numberToRemove);
                }
                if (token[0] == "RemoveAt")
                {
                    int numberToRemoveAtIndex = int.Parse(token[1]);
                    inputNum.RemoveAt(numberToRemoveAtIndex);
                }
                if (token[0] == "Insert")
                {
                    int numberToAddInIndex = int.Parse(token[1]);
                    int indexToAdd = int.Parse(token[2]);
                    inputNum.Insert(indexToAdd, numberToAddInIndex);
                }
                commands = Console.ReadLine();
            }
            if (isChanged)
            {
                foreach (var num in inputNum)
                {
                    Console.Write(num + " ");
                }

            }
        }
        private static void PrintSmallOrEqualNumbers(List<int> inputNum, string[] token)
        {
            int numberForFiltered = int.Parse(token[2]);
            for (int i = 0; i < inputNum.Count; i++)
            {
                if (inputNum[i] <= numberForFiltered)
                {
                    Console.Write(inputNum[i] + " ");
                }
            }
            Console.WriteLine();
        }
        private static void PrintBiggestOrEqualNumbers(List<int> inputNum, string[] token)
        {
            int numberForFiltered = int.Parse(token[2]);
            for (int i = 0; i < inputNum.Count; i++)
            {
                if (inputNum[i] >= numberForFiltered)
                {
                    Console.Write(inputNum[i] + " ");
                }
            }
            Console.WriteLine();
        }
        private static void PrintBiggestNumbers(List<int> inputNum, string[] token)
        {
            int numberForFiltered = int.Parse(token[2]);
            for (int i = 0; i < inputNum.Count; i++)
            {
                if (inputNum[i] > numberForFiltered)
                {
                    Console.Write(inputNum[i] + " ");
                }
            }
            Console.WriteLine();
        }
        private static void PrintSmallNumbers(List<int> inputNum, string[] token)
        {
            int numberForFiltered = int.Parse(token[2]);
            for (int i = 0; i < inputNum.Count; i++)
            {
                if (inputNum[i] < numberForFiltered)
                {
                    Console.Write(inputNum[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void GetSumOfNumbersInput(List<int> inputNum)
        {
            int sum = 0;
            for (int i = 0; i < inputNum.Count; i++)
            {
                sum += inputNum[i];
            }
            Console.WriteLine(sum);
        }

        private static void PrintOdd(List<int> inputNum)
        {
            for (int i = 0; i < inputNum.Count; i++)
            {
                if (inputNum[i] % 2 != 0)
                {
                    Console.Write(inputNum[i] + " ");
                }
            }
            Console.WriteLine();
        }
        private static void PrintEven(List<int> inputNum)
        {
            for (int i = 0; i < inputNum.Count; i++)
            {
                if (inputNum[i] % 2 == 0)
                {
                    Console.Write(inputNum[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void IsContains(List<int> inputNum, string[] token)
        {
            int num = int.Parse(token[1]);
            bool isContained = inputNum.Contains(num);
            if (isContained)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}


