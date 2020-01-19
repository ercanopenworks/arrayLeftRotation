using System;

namespace arraysLeftRotation
{
    class Program
    {

        static int[] rotLeft(int[] pArr, int numberOfShift )
        {
            int[] newArray=new int[pArr.Length];
            int shiftInd;
            for (int i = 0; i < pArr.Length; i++)
            {
                shiftInd = (i + numberOfShift) % pArr.Length;
                newArray[i] = pArr[shiftInd];
            }

            return newArray;

            //solution at below is not efficient because takes a long time
            //int tempFirstElement;

            //tempFirstElement = pArr[0];

            //for (int i = 0; i < numberOfShif; i++)
            //{
            //    tempFirstElement = pArr[0];
            //    for (int j = 0; j <= pArr.Length - 1; j++)
            //    {
            //        if (j == pArr.Length - 1)
            //        {
            //            pArr[pArr.Length - 1] = tempFirstElement;

            //        }
            //        else pArr[j] = pArr[j + 1];

            //    }
            //}

            //return pArr;

        }
        static void Main(string[] args)
        {

            //string[] nd = Console.ReadLine().Split(' ');
            string[] nd = "5 2".Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);
            if ((d<n) && (d>0))
            {

            }

            
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] a = Array.ConvertAll("1 2 3 4 5".Split(' '), aTemp => Convert.ToInt32(aTemp)); 

            int[] result = rotLeft(a, d);


            Console.WriteLine(string.Join(' ', result));
            Console.ReadKey();
        }
    }
}
