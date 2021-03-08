/*

The purpose of this kata is to write a program that can do some algebra. Write a function expand that takes in an expresion with a single, one character variable, and expands it. The expresion is in the form (ax+b)^n where a and b are integers which may be positive or negative, x is any one character long variable, and n is a natural number. If a = 1, no coeficient will be placed in front of the variable. If a = -1, a "-" will be placed in front of the variable.

The expanded form should be returned as a string in the form ax^b+cx^d+ex^f... where a, c, and e are the coefficients of the term, x is the original one character variable that was passed in the original expression and b, d, and f, are the powers that x is being raised to in each term and are in decreasing order. If the coeficient of a term is zero, the term should not be included. If the coeficient of a term is one, the coeficient should not be included. If the coeficient of a term is -1, only the "-" should be included. If the power of the term is 0, only the coeficient should be included. If the power of the term is 1, the carrot and power should be excluded.

Examples:
KataSolution.Expand("(x+1)^2");      // returns "x^2+2x+1"
KataSolution.Expand("(p-1)^3");      // returns "p^3-3p^2+3p-1"
KataSolution.Expand("(2f+4)^6");     // returns "64f^6+768f^5+3840f^4+10240f^3+15360f^2+12288f+4096"
KataSolution.Expand("(-2a-4)^0");    // returns "1"
KataSolution.Expand("(-12t+43)^2");  // returns "144t^2-1032t+1849"
KataSolution.Expand("(r+0)^203");    // returns "r^203"
KataSolution.Expand("(-x-1)^2");     // returns "x^2+2x+1"

*/

using System;
using System.Text;

public class KataSolution
{
  

public static string Expand(string expr)
    {
        
        bool signFirst = false;
        bool signSecond = false;
        long firstCoef, secondCoef;
        int exponent;
        char x = new char();
        long temp;
        
        if (expr[0] != '(') return null;

        int i = 1;

        if (expr[i] == '-')
        {
            signFirst = true;
            i++;
        }
        if (Char.IsLetter(expr[i]))
        {
            x = expr[i];
            firstCoef = signFirst ? -1 : 1;
            i++;
        }
        else
        {
            temp = 0;
            while (Char.IsDigit(expr[i]))
            {
                temp = temp * 10 + (int)Char.GetNumericValue(expr[i]);
                i++;
            }
            if (signFirst)
            {
                firstCoef = -temp;
            }
            else
            {
                firstCoef = temp;
            }
            x = expr[i];
            i++;
            //kraj prvog koeficijenta.
        }

        if (expr[i] == ('-'))
        {
            signSecond = true;
        }
        i++;

        temp = 0;
        while (Char.IsDigit(expr[i]))
        {
            temp = temp * 10 + (int)Char.GetNumericValue(expr[i]);
            i++;
        }

        if (signSecond)
        {
            secondCoef = -temp;
        }
        else
        {
            secondCoef = temp;
        }
        // kraj drugog koeficijenta


        if (expr[i] != ')')
        {
            return null;
        }
        else
        {
            i++;
        }
        if (expr[i] != '^')
        {
            return null;
        }
        else
        {
            i++;
        }
        temp = 0;
        while ((i < expr.Length) && (Char.IsDigit(expr[i])))
        {
            temp = temp * 10 + (int)Char.GetNumericValue(expr[i]);
            i++;
        }
        exponent = (int)temp;


        StringBuilder res = new StringBuilder();

        if (exponent == 0) return "1";
        else if (exponent == 1)
        {
            
            if (firstCoef != 1)
            {
                res.Append(firstCoef);
            }
            res.Append(x);
            if (!(signSecond))
            {
                res.Append("+");
            }
            res.Append(secondCoef);
            
        }
        else // koeficijent 2 ili veci
        {
            long[] coef = new long[exponent + 1];
            long[] t1 = new long[exponent + 1];
            long[] t2 = new long[exponent + 1];
            coef[1] = firstCoef;
            coef[0] = secondCoef;
            for (i = 1; i < exponent; i++)
            {
                for(int j = 0; j <= exponent; j++)
                {
                    t1[j] = coef[j] * secondCoef;
                }
                for(int j = exponent - 1; j >= 0; j--)
                {
                    t2[j + 1] = coef[j] * firstCoef;
                }
                for (int k = 0; k <= exponent; k++)
                {
                    coef[k] = t1[k] + t2[k];
                    t1[k] = 0;
                    t2[k] = 0;
                }
            }

            if (Math.Abs(coef[i]) != 1)
            {
                res.Append(coef[i]);
            }
            else if (coef[i] == -1) res.Append('-');
          
            res.Append(x + "^");
            res.Append(i);

            for (i = exponent-1 ; i >= 0; i--)
            {
                if (coef[i] != 0)
                {
                    if ((coef[i] != 1) || (i == 0))
                    {
                        if (coef[i] < 0)
                            res.Append(coef[i]);
                        else
                            res.Append("+" + coef[i]);
                    }
                    if (i > 0)
                        res.Append(x);
                    if (i > 1)
                        res.Append("^" + i);
                }
            }
            
                

        }


        return res.ToString() ;
    }
}