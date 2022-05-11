using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodenumerice.sistemedenumeratie
{
    public class binar:numar
    {
      

        public int convertBinary2DecaInt(ref List<int> lxbinarnumber)
        {
            int r = 0;
            int c = 0;
            for (int i = lxbinarnumber.Count - 1; i >= 0; i--)
            {
                c++;
                if (lxbinarnumber[i] == 1)
                {
                   
                    r += (int)Math.Pow(2, c);
                    
                }
            }
            return r;
        }

    }
}
