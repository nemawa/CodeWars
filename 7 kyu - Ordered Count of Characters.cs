/*

Count the number of occurrences of each character and return it as a list of tuples in order of appearance. For empty output return an empty list.

Example:

Kata.OrderedCount("abracadabra") == new List<Tuple<char, int>> () {
  new Tuple<char, int>('a', 5),
  new Tuple<char, int>('b', 2),
  new Tuple<char, int>('r', 2), 
  new Tuple<char, int>('c', 1),
  new Tuple<char, int>('d', 1)
}
FUNDAMENTALS

*/

namespace Solution {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    public class Kata {
        public static List<Tuple<char, int>> OrderedCount(string input) {
 
            Dictionary<Char, int> res = new Dictionary<Char, int>();
            

            foreach (Char c in input)
            {

                if (!res.ContainsKey(c)) 
                {
                    res.Add(c, 1);
                }
                else
                {
                    res[c]++;
                }
            }

            List<Tuple<char, int>> res1 = new List<Tuple<char, int>>();

            foreach (var t in res)
            {
                res1.Add(new Tuple<char, int>(t.Key, t.Value));
            }

            return res1;
            // Implement me!
        }
    }
}

