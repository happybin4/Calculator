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
        private string op;

        public string Op
        {
            get { return op; }
            set { op = value; }
        }

        public int Fnum { get; set; }
        public bool Operation (int result,int fnum,int snum)
        {
            if (op == "+")
            {
                if (result == fnum + snum)
                    return true;
                else
                    return false;
            }
            else if (op == "-")
            {
                if (result == fnum - snum)
                    return true;
                else
                    return false;
            }
            else if (op == "*")
            {
                if (result == fnum * snum)
                    return true;
                else
                    return false;
            }
            else if (op == "/")
            {
                if (result == fnum / snum)
                    return true;
                else
                    return false;
            }
            else
                return false;

        }
        
       
    }
}
