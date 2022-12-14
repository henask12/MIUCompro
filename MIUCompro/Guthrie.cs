using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIUCompro
{
    public class Guthrie
    {
        int isGuthrie(int n)
        {
            int a = 0, b = 1, c = 0, j = 0;
            while (c < n)
            {
                c = a + b;
                a = j;
                b = c;
                j++;
            }
            if (c == n) return 1;
            return 0;
        }
    }
}
