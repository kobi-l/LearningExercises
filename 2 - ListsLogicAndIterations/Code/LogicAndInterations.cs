using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Code
{
	public static class LogicAndInterations
	{
		public static int For_SumTwoListsAndAllValueThatAreNotFour(int[] numberArray, List<int> numberList)
		{
            int sumArr = 0;
            for (int i = 0; i < numberArray.Length; i++)
			{
                if (numberArray[i] != 4)
                    sumArr += numberArray[i];
			}

            int sumList = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] != 4)
                    sumList += numberList[i];
            }

            return sumArr + sumList;
		}

		public static int ForEach_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList)
		{
            int sumList = 0;
            foreach (var num in numberList)
                if (num != 4)
                    sumList += num;
            return sumList;
        }

		public static int DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int counter = 0;
            int sumList = 0;
            bool shouldContinue = true;
            do
            {
                sumList += numberList[counter];
                if (numberList[counter] == 4 || (counter + 1) >= numberList.Count)
                    shouldContinue = false;
                counter++;
            }
            while (shouldContinue);

            return sumList;
		}

		public static int While_SumValuesWhileCurrentValueIsNot4_ThenStop(List<int> numberList)
		{
            int counter = 0;
            int sumList = 0;
            bool shouldContinue = true;

            while (shouldContinue)
            {
                sumList += numberList[counter];
                if (numberList[counter] == 4 || (counter + 1) >= numberList.Count)
                    shouldContinue = false;
                counter++;
            }
            return sumList;
        }

		/*
		 * If you have not learned about System.Linq and Lambda expressions, google `C# LINQ Tutorial`...trust me, you will thank me if you learn this early.
		 */
		public static int Linq_SumTwoListsAndAllValueThatAreNotFour(List<int> numberList) =>
            numberList.Where(n => n != 4).Sum();
    }
}
 
 
 
 