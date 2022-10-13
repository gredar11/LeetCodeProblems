using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class BackspaceStringCompare
    {
        // source: https://leetcode.com/problems/backspace-string-compare/
        public bool BackspaceCompare(string s, string t)
        {
            StringBuilder sbuilder = new StringBuilder();
            StringBuilder tbuilder = new StringBuilder();
            int sCounter = 0;
            int tCounter = 0;
            while (sCounter < s.Length || tCounter < t.Length)
            {
                if (sCounter < s.Length)
                {
                    if (s[sCounter] == '#')
                    {

                        if (sbuilder.Length > 0)
                        {
                            sbuilder.Length--;
                        }
                    }
                    else
                    {
                        sbuilder.Append(s[sCounter]);
                    }
                    sCounter++;
                }
                if (tCounter < t.Length)
                {
                    if (t[tCounter] == '#')
                    {
                        if (tbuilder.Length > 0)
                        {
                            tbuilder.Length--;
                        }
                    }
                    else
                    {
                        tbuilder.Append(t[tCounter]);
                    }
                    tCounter++;
                }
            }
            return sbuilder.ToString() == tbuilder.ToString();
        }
    }
}
