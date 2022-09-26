using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    //https://leetcode.com/problems/generate-parentheses/
    public class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            return null;
        }
        public string[] PairsOfParentheses(int countOfSinglePairs, int n)
        {
            /// логика в количестве закрывающих и открывающих скобок
            /// 0 скобок:
            /// [] [] [] []
            /// [] [] [[]]
            /// [] [[]] []
            /// [[]] [] []
            /// [[[]]] []
            /// [] [[[]]]
            /// [[]] [[]]
            /// 1 скобка:
            /// [ [] [] [] ]
            /// [ [[]] [] ]
            /// [ [] [[]] ]
            /// 2 скобки:
            /// [[[] []]]
            /// 3 скобка:
            /// [[[ [] ]]]
            return null;
        }
    }
}
