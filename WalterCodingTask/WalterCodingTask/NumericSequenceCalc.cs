using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WalterCodingTask
{
    public class NumericSequenceCalc
    {
        public string AllNumbers(int n)
        {
            int iFirst = 1;
            bool boolNumberislower = true;

            string sOutput = "";
            while (boolNumberislower)
            {
                sOutput += iFirst;

                iFirst = iFirst + 1;
                if (iFirst >= n)
                {
                    boolNumberislower = false;
                    sOutput += n;

                }
            }
            return sOutput;
        }

        public string AllOddNumbers(int n)
        {

            string sOutput = "";
            for (int i = 1; i <= n; i++)
            {
                //Compute for Odd numbers, if a number is divided by 2 and 
                //it has a remainder, the number is Odd
                if (i % 2 != 0)
                {
                    if (i != n) sOutput += i;
                }
            }
            sOutput += n;
            return sOutput;
        }

        public string AllEvenNumbers(int n)
        {
            string sOutput = "";
            for (int i = 1; i <= n; i++)
            {
                //Compute for Even numbers, if a number is divided by 2 and 
                //it does not have a remainder, the number is Even
                if (i % 2 == 0)
                {
                    if (i != n) sOutput += i;
                }
            }
            sOutput += n;
            return sOutput;
        }

        public string MultOfThree(int n)
        {
            string sOutput = "";
            for (int i = 1; i <= n; i++)
            {
                //Compute if the number is exactly divisible by 3
                if (i % 3 == 0)
                {
                    sOutput += "C";
                }
                else
                {
                    if (i != n) sOutput += i;
                }
            }
            sOutput += n;
            return sOutput;
        }

        public string MultOfFive(int n)
        {
            string sOutput = "";
            for (int i = 1; i <= n; i++)
            {
                //Compute if the number is exactly divisible by 5
                if (i % 5 == 0)
                {
                    sOutput += "E";
                }
                else
                {
                    if (i != n) sOutput += i;
                }
            }
            sOutput += n;
            return sOutput;
        }

        public string MultOfThreeFive(int n)
        {
            string sOutput = "";
            for (int i = 1; i <= n; i++)
            {
                //Compute if the number is exactly divisible by 3 and 5
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    sOutput += "Z";
                }
                else
                {
                    if (i != n) sOutput += i;
                }
            }
            sOutput += n;
            return sOutput;
        }

        public string Fibonacci(int n)
        {
            int iFirst = 1, iSecond = 0, iTemp = 0;
            bool boolNumberislower = true;

            string sOutput = "";
            while (boolNumberislower)
            {
                //Compute the sum of 2 numbers repeatedly until the given number "n" is reached
                sOutput += iFirst;
                iSecond = iTemp;
                iTemp = iFirst;
                iFirst = iSecond + iTemp;
                if (iFirst >= n)
                {
                    boolNumberislower = false;
                    sOutput += n;
                    
                }
            }
            return sOutput;

        }

    }
}