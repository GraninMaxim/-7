using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Triad
    {
        public Triad(uint number1, uint number2, uint number3)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
        }


        public uint Number1 { get; set; }
        public uint Number2 { get; set; }
        public uint Number3 { get; set; }

        public uint Amount()
        {
            uint amount = Number1 + Number2 + Number3;
            return amount;
        }
    }
}
