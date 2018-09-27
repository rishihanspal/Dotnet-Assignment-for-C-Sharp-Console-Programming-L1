/*
// Sample code to perform I/O:

name = Console.ReadLine();                  // Reading input from STDIN
Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT

// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/

// Write your code here
using System;


namespace ABC
{
    class program
    {
        public static void Main()
        {
           int N, Q, X, i, j, count;
           N = int.Parse(Console.ReadLine());
           int [] A = Array.ConvertAll(Console.ReadLine().Split(' '), e => Convert.ToInt32(e));
           Q = int.Parse(Console.ReadLine());
           int [] R = new int[Q];
           for(i=0 ; i<Q ; i++)
               R[i] = int.Parse(Console.ReadLine());
           
           int [] S = new int[100000];
           
           for(i=0 ; i<N ; i++)
               S[A[i]]++;
           
           for(i=0 ; i<Q ; i++)
           {
               if(S[R[i]]>0)
                    Console.WriteLine(S[R[i]]);
               else
                    Console.WriteLine("NOT PRESENT");
           }
        }
    }
}