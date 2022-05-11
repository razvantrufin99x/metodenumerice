using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodenumerice.sistemedenumeratie
{
    public class numar
    {

        public List<int> _numar = new List<int>();

        public int numberofdigits(  int y)
        {
            int k = y;
            int i = 0;
            while (k>0)
            {
                k = k / 10;
                i++;
            };
            return i;
        }
        public void numeric2List(int x, ref List<int> lx) {
            int z = x;
            int c = numberofdigits(z);
            for (int i = 0; i < c; i++)
            {
                lx.Add(z % 10);
                z = z / 10;
            }
        }
        //for hexa will return the int A-F will be replaced by 10-15
        public string printListHexa(ref List<int> numarul)
        {
            string nr = "";
            for (int i  = numarul.Count-1; i>=0 ; i--)
            {
                if (numarul[i] == 10) {
                    nr += "A";
                }
                else if (numarul[i] == 11)
                {
                    nr += "B";
                }
                else if (numarul[i] == 12)
                {
                    nr += "C";
                }
                else if (numarul[i] == 13)
                {
                    nr += "D";
                }
                else if (numarul[i] == 14)
                {
                    nr += "E";
                }
                else if (numarul[i] == 15)
                {
                    nr += "F";
                }
                else 
                { 
                    nr += numarul[i].ToString();
                }
            }
            return nr;

        }
        //for hexa will return the int A-F will be replaced by 10-15
        public string printList(ref List<int> numarul)
        {
            string nr = "";
            for (int i = numarul.Count - 1; i >= 0; i--)
            {
                nr += numarul[i].ToString();
            }
            return nr;

        }
    }
}
