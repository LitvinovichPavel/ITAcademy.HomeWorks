using System;
using System.Collections.Generic;
using System.Text;

namespace hm_10
{
    public class Kata
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            int count = integerList.Length;
            for (int i = 0; i < integerList.Length; i++)
            {
                for (int j = 0; j < valuesList.Length; j++)
                {
                    if (integerList[i].Equals(valuesList[j]))
                    {
                        integerList[i] = 0;
                        count--;
                    }
                }
            }

            int[] answer = new int[count];

            count = 0;
            for (int i = 0; i < integerList.Length; i++)
            {
                if (integerList[i] != 0)
                {
                    answer[count] = integerList[i];
                    count++;
                }
            }

            return answer;
        }
    }
    public class ClassKata
    {
        public void MethodKata()
        {
            int[] integerList = new int[] { 1, 1, 2, 3, 1, 2, 3, 4 };
            int[] valuesList = new int[] { 1, 3 };
            Kata.Remove(integerList, valuesList);
        }
    }
}
