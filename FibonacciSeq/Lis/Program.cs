using System;
using System.Collections.Generic;
using System.Linq;

namespace Lis
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string[] arr = new string[] { "5", "2", "7", "4", "3", "8"};
            List<int> res = new List<int>();
            int arrLen = arr.Length;
            int i = 0;
            for (i = 0; i < arrLen; i++)
            {
                if (i < arrLen)
                {
                    if (res.Count != 0)
                    {
                        if (Convert.ToInt32(arr[i]) > res[res.Count - 1])
                        {
                            res.Add(Convert.ToInt32(arr[i]));
                        }
                    }
                    else
                    {
                        res.Add(Convert.ToInt32(arr[i]));
                    }
                }
            }

            int len = res.Count;
            Console.Write(len);
            Console.ReadKey();
        }
    }
}
