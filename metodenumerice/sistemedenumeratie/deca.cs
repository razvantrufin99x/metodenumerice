using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodenumerice.sistemedenumeratie
{
    public class deca : numar
    {
        public List<int> convertDeca2BinaryInt(ref int decanumber)
        {
            List<int> nrbinarRez = new List<int>();
            int d = decanumber;
            int r = 0;
            while (d > 0)
            {
                r = d % 2;
                nrbinarRez.Add(r);
                d = d / 2;
            }

            return nrbinarRez;
        }

        //hext A is 10, B is 11, C is 12 , D is 13, E is 14, F is 15 will be number not chars in list
        //replace int to char code if you want to print the hexa number

        public List<int> convertDeca2HexInt(ref int decanumber)
        {
            List<int> nrHexRez = new List<int>();
            int d = decanumber;
            int r = 0;
            while (d > 0)
            {
                r = d % 16;
                nrHexRez.Add(r); 

                d = d / 16;
            }

            return nrHexRez;
        }

        public List<int> convertDeca2OctInt(ref int decanumber)
        {
            List<int> nrOctRez = new List<int>();
            int d = decanumber;
            int r = 0;
            while (d > 0)
            {
                r = d % 8;
                nrOctRez.Add(r);
                d = d / 8;
            }

            return nrOctRez;
        }

        public List<int> convertDeca2QuadInt(ref int decanumber)
        {
            List<int> nrQuadRez = new List<int>();
            int d = decanumber;
            int r = 0;
            while (d > 0)
            {
                r = d % 4;
                nrQuadRez.Add(r);
                d = d / 4;
            }

            return nrQuadRez;
        }

    }
}
