using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    internal class Algorithms
    {

        private string cuser(string plaintxt, int key)
        {

            string cipertxt = string.Empty;



            foreach (char ch in plaintxt)
            {
                if (char.IsLetter(ch))
                    cipertxt += Convert.ToChar((((Convert.ToUInt16(ch) - 65) + key) % 26) + 65);
                else
                    cipertxt += ch;

            }
            return cipertxt;



        }

        private string deCuser(string cypertxt, int key)
        {

            string plaintxt = string.Empty;


            foreach (char ch in cypertxt)
            {
                if (char.IsLetter(ch))
                    plaintxt += Convert.ToChar(((((Convert.ToUInt16(ch) - 65) - key) % 26) + 65));
                else
                    plaintxt += ch;

            }
            return plaintxt;



        }

    }
}
