/*

Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others in evenness. Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.

! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

Examples:
IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even

IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd

*/

using System;
using System.Linq;

public class IQ
    {
        public static int Test(string numbers)
        { 
            
            string[] input = (numbers.Split(" "));
            int countE = 0;
            int countO = 0;
            int posE=0, posO=0;
            
            for (int i = 0; i< input.Length; i++){
              if (Int32.Parse(input[i]) % 2 == 0){
                countE++;
                posE = i;
              }
              else{
                countO++;
                posO = i;
              }
            }
            if (countO > countE){
              return posE+1;
            }
            else{return posO+1;}
            
            
            //Your code is here...
        }
    }