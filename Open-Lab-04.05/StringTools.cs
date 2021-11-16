﻿using System;
using System.Linq;


namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            var result = string.Empty;
            for (var i = 0; i < orig.Length; i++)
                result += string.Concat(Enumerable.Repeat(orig[i], n));
            return result;
        }
    }
}
