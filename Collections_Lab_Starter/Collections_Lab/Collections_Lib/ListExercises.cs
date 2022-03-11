using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> list = new List<int>();
            for (int i = 1; i < max + 1; i++)
            {
                if (i % 5 == 0)
                    list.Add(i);
            }
            return list;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> aList = new List<string>();
            foreach (var item in sourceList)
            {
                if (item[0] == 'A' || item[0] == 'a')
                {
                    aList.Add(item);
                }
            };
            return aList;
        }
    }
}
