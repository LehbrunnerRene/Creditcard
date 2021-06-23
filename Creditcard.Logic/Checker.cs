using System;
using System.Linq;

namespace Creditcard.Logic
{
    public class Checker
    {
        public static Boolean creditCardChecker(string ssn)
        {
            int odd = 0;
            int even = 0;
            int both = 0;
            if(ssn == null)
            {
                throw new ArgumentNullException();
            }
            if(ssn.Length != 16)
            {
                return false;
            }
            for (int i = 0; i < ssn.Length -1; i++)
            {
                if (!Char.IsDigit(ssn[i]))
                {
                    return false;
                }
                if (Convert.ToInt32(ssn[i]) % 2 == 0)
                {
                    int quer = Convert.ToInt32(ssn[i].ToString()) * 2;
                    if(quer >= 10)
                    {
                        quer = quer.ToString().Sum(c => c - '0');
                    }
                    even += quer;

                }
                else
                {
                    odd += Convert.ToInt32(ssn[i].ToString());
                }
                
            }
            both = even + odd;
            int j = both % 10;
            int prüfsumme = both - j + 10 -both;
            if (Convert.ToInt32(ssn[15].ToString()) == prüfsumme)
            {
                return true;
            }
            return false;
        }
    }
}
