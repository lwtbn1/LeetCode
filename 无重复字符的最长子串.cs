using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class 无重复字符的最长子串
    {
        public static void Test()
        {
            int len = LengthOfLongestSubstring("gpaazszqlcxvfoaaxzagwsemzszjukeczgfbzetkisiq");
            Console.WriteLine(len);
            Console.ReadKey();
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int maxLen = 0;
            int sLen = s.Length;
            HashSet<char> setTmp = new HashSet<char>();
            for (int checkLen = 1; checkLen <= sLen; checkLen++)
            {
                for(int checkStartIx = 0; checkStartIx <= sLen - checkLen; checkStartIx++)
                {
                    setTmp.Clear();
                    bool same = false;
                    for (int ix = checkStartIx; ix < checkStartIx + checkLen; ix++)
                    {
                        if (setTmp.Contains(s[ix]))
                            same = true;
                        setTmp.Add(s[ix]);
                        Console.Write(s[ix]);
                    }
                    Console.Write(" " + same);
                    Console.WriteLine("");
                    if (!same)
                    {
                        maxLen = checkLen;
                        break;
                    }
                }
                if (checkLen - 1 > maxLen)
                    return maxLen;
            }
            return maxLen;
        }
    }
}
