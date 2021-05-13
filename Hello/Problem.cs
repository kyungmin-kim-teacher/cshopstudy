using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCoding
{
    public class Problem
    {
        public int findMax(int v1, int v2, int v3)
        {
            int max;

            if (v1 > v2)
            {
                max = v1;
            } 
            else
            {
                max = v2;
            }

            if (max > v3)
            {
                return max;
            } 
            else
            {
                return v3;
            }
        }

        public bool isVowel(char v)
        {
            if (v == 'a' || v == 'i' || v == 'u'||
                v == 'e' || v == 'o')
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        public string ordinalNum(int v)
        {
            if (v == 1)
            {
                return "1st";
            }
            if (v == 2)
            {
                return "2nd";
            }
            if (v == 3)
            {
                return "3rd";
            }
            return v + "th";
        }

        public int sum(int v)
        {
            int rv = 0;
            for (int i = 1; i <= v; i++)
            {
                rv += i;
            }

            return rv;
        }

        public int evenSum(int v)
        {
            int rv = 0;
            for (int i = 1; i <= v; i++)
            {
                if (i % 2 == 0)
                    rv += i;
            }

            return rv;
        }
    }
}
