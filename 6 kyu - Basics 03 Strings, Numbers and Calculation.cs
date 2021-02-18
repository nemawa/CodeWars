/*

Here you have to do some mathematical operations on a "dirty string". This kata checks some basics, it's not too difficult.

So what to do?

Input: String which consists of two positive numbers (doubles) and exactly one operator like +, -, * or / always between these numbers. The string is dirty, which means that there are different characters inside too, not only numbers and the operator. You have to combine all digits left and right, perhaps with "." inside (doubles), and to calculate the result which has to be rounded to an integer and converted to a string at the end.

Easy example:
Input: "gdfgdf234dg54gf*23oP42"
Output: "54929268" (because 23454*2342=54929268)
First there are some static tests, later on random tests too...

Hope you have fun! :-)

*/


using System.Text;
using System;

namespace smile67Kata
{


    public class Kata
    {
       public  string calculateString(string calcIt)
        {
            StringBuilder temp = new StringBuilder(string.Empty);
            for (int j = 0; j < calcIt.Length; j++)
            {
                if (((calcIt[j] >= '0') & (calcIt[j] <= '9')) | (calcIt[j] == '+') | (calcIt[j] == '-') | (calcIt[j] == '*') | (calcIt[j] == '/') | (calcIt[j] == '.'))
                {
                    temp.Append(calcIt[j]);
                }
            }
            int i = 0;
        
            while ((temp[i] != '+') & (temp[i] != '-') & (temp[i] != '*') & (temp[i] != '/'))
            {
                i++;
            }
            char func = temp[i];
            string text = temp.ToString();

            string[] numbers = text.Split(func);
            double first = Double.Parse(numbers[0]);
            double second = Double.Parse(numbers[1]);
            double res = 0;

        
            switch (func)
            {
                case '+': res = first + second; break;
                case '-': res = first - second; break;
                case '*': res = first * second; break;
                case '/': res = first / second; break;

            }
            string result = Math.Round(res).ToString();

            return result;
        }
    }
}