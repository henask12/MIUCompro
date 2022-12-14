using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIUCompro
{
    public class LongestPalindrome
    {
        public string LongestPalind(string s)
        {
            int n = s.Length;
            string pal = "";

            int maxLength = 1, start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    int flag = 1;

                    for (int k = 0; k < (j - i + 1) / 2; k++)
                        if (s[i + k] != s[j - k])
                            flag = 0;

                    if (flag != 0 && (j - i + 1) > maxLength)
                    {
                        start = i;
                        maxLength = j - i + 1;
                    }
                }
            }

            for (int i = start; i <= start + maxLength - 1; ++i)
            {
                pal += s[i];
            }


            return pal;
        }
    }
}
