using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Data;

namespace Hashtable
{


    public class HashFrequency<Gtype>
    { 

        linkedlist<Gtype>[] key_array = new linkedlist<Gtype>[7];

        public HashFrequency()
        {
            for (int i = 0; i < 6; i++)
            {
                linkedlist<Gtype> list = new linkedlist<Gtype>();
                key_array[i] = list;

            }

        }
        
        public void Insert(Gtype val)
        {
            long index = val.GetHashCode() % 7;
            linkedlist<Gtype> temp1 = key_array[Math.Abs(index)];
            temp1.Add(val);
        }

        public static int FindFrequency(string word, string freq)
        {
            int count = 0;
            int i = 0;
            while ((i = word.IndexOf(freq, i)) != -1)
            {
                i += freq.Length;
                count++;
            }
            return count;
        }
    }
}

