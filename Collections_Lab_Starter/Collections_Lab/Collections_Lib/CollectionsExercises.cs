using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string commaSeparated = "";
            if (queue.Count < num)
            {
                return commaSeparated;
            }
            for (int i = 0; i < num - 1; i++)
            {
                commaSeparated += queue.Dequeue() + ", ";
            }
            if (num == 0)
                return commaSeparated;
            else
            {
                commaSeparated += queue.Dequeue();
                return commaSeparated;
            }
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int[] reversed = new int[original.Length];
            Stack<int> stack = new Stack<int>();
            foreach (int n in original)
            {
                stack.Push(n);
            }
            for (int i = 0; i < original.Length; i++)
            {
                reversed[i] = stack.Pop();
            }
            return reversed;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> digitCounter = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (digitCounter.ContainsKey(c))
                {
                    digitCounter[c]++;
                }
                else if (c == '9' || c == '8' || c == '7' || c == '6' || c == '5' || c == '4' || c == '3' || c == '2' || c == '1' || c == '0')
                {
                    digitCounter.Add(c, 1);
                }

            }
            string digitCountList = "";
            foreach (KeyValuePair<char, int> keyValuePair in digitCounter)
            {
                digitCountList += keyValuePair;
            }

            return digitCountList;


        }
    }
}
