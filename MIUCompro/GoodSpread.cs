using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIUCompro
{
    public class GoodSpread
    {
        public int goodSpreadg(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j]) count++;
                }
                if (count > 3) return 0;
                count = 0;
            }
            return 1;
        }
    }
}
