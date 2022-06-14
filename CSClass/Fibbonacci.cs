﻿using System.Collections.Generic;

namespace CSClass
{
    public class Fibbonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();

        public Fibbonacci()
        {

        }

        public static long Get(int n)
        {
            if (n < 0) return 0;
            if (n == 1) return 1;

            if(memo.ContainsKey(n))
            {
                return memo[n];
            }
            else
            {
                long value = Get(n - 2) + Get(n - 1);
                memo[n] = value;
                return value;
            }
           
        }
    }
}