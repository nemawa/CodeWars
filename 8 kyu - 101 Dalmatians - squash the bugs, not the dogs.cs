/*

Your friend has been out shopping for puppies (what a time to be alive!)... He arrives back with multiple dogs, and you simply do not know how to respond!

By repairing the function provided, you will find out exactly how you should respond, depending on the number of dogs he has.

The number of dogs will always be a number and there will always be at least 1 dog.

*/

using System.Collections.Generic;

public static class Kata
    {
        public static string HowManyDalmatians(int number)
        {
            List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
            string respond;
            if( number <= 10)
            {
               respond = dogs[0];
            }
            else if (number <= 50)
            {
               respond =  dogs[1]; 
            }
            else if (number == 101)
            {
               respond = dogs[3]; 
            }
            else 
            {
                respond = dogs[2];
            }
            return respond;
        }
    }