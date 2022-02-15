using System;

namespace P127_Array_String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array Methods
            //int[] arr = { 1, 5, 6,3, 7,-20,90, 8, 9, 10 };
            //int[] newArr = new int[20];

            //int[] newArr =  (int[])arr.Clone();
            //foreach (int num in newArr)
            //{
            //    Console.WriteLine(num);
            //}

            //arr.CopyTo(newArr,5);
            //foreach (int num in newArr)
            //{
            //    Console.WriteLine(num);
            //}

            //Array.Clear(arr, 4, arr.Length-4);
            //foreach (int num in arr)
            //{
            //    Console.WriteLine(num);
            //}

            int[] arr2 = Array.Empty<int>();
            //Console.WriteLine(arr2.Length);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Array.Resize(ref arr2, arr2.Length+1);
            //    arr2[i] = arr[i];
            //}
            //foreach (int num in arr2)
            //{
            //    Console.WriteLine(num);
            //}

            //string[] strArr = { "A", "b", "z", "w", "l", "h", "d" };

            //Array.Sort(strArr);
            //foreach (string letter in strArr)
            //{
            //    Console.WriteLine(letter);
            //}

            //Array.Sort(arr);
            //foreach (int num in arr)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion


            #region String Methods
            string str = "heLlo P127 how are you";
            string newStr = (string)str.Clone();
            //Console.WriteLine(newStr);

            string concat = String.Concat(str," ", newStr,  " ",  69);
            Console.WriteLine(concat);
            bool result = str.Contains("lo");
            Console.WriteLine(result);

            bool start = str.StartsWith("hello");
            Console.WriteLine(start);
            //Console.WriteLine(str.EndsWith("7"));
            //DateTime date = DateTime.UtcNow;
            //string format = String.Format("{0:c}",55.55);
            //string dateFormat = String.Format("{0:r}", date);
            //Console.WriteLine(dateFormat);

            //Console.WriteLine(str.IndexOfAny(new char[] { 'H','7' ,' '}));
            //Console.WriteLine(str.Insert(5, " okay"));
            //string space = " ";
            //if (string.IsNullOrEmpty(space))
            //{
            //    Console.WriteLine("null ve ya white spaceden ibaretdir");
            //}
            //else
            //{
            //    Console.WriteLine(space);
            //}
            //string[] test = { "hello", "p127", "how" };
            //string[] strArr = str.Split(' ');
            //foreach (string word in strArr)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine(String.Join("-", strArr));


            Console.WriteLine(str.Remove(5));

            string sub=str.Substring(0,13) + "...";
            Console.WriteLine(char.IsLower(' '));
            Console.WriteLine(sub.ToUpper());
            #endregion

        }
    }
}
