using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calc
    {
        int fnum;
        int snum;
        public int Fnum { get; set; }
        public bool sum(int result)
        {
            return true;
        }
        public int sub(int fnum,int snum)
        {
            return fnum - snum;
        }
        public int mul(int fnum,int snum)
        {
            return fnum * snum;
        }
        public double div(int fnum,int snum)
        {
            return fnum / snum;
        }
       
    }
}
