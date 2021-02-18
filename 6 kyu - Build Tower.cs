/*

Build Tower
Build Tower by the following given argument:
number of floors (integer and always greater than 0).

Tower block is represented as *

Python: return a list;
JavaScript: returns an Array;
C#: returns a string[];
PHP: returns an array;
C++: returns a vector<string>;
Haskell: returns a [String];
Ruby: returns an Array;
Lua: returns a Table;
Have fun!

for example, a tower of 3 floors looks like below

[
  '  *  ', 
  ' *** ', 
  '*****'
]
and a tower of 6 floors looks like below

[
  '     *     ', 
  '    ***    ', 
  '   *****   ', 
  '  *******  ', 
  ' ********* ', 
  '***********'
]
Go challenge Build Tower Advanced once you have finished this :)

*/

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string[] output = new string[nFloors];
    
    for (int i=0; i<nFloors; i++){
     
     output[i] = new string(' ', nFloors-i-1) + new string('*',i*2+1) + new string(' ', nFloors-i-1);
    }
      
    
    return output;
  }
}