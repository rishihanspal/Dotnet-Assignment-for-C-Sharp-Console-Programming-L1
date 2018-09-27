/*
// Sample code to perform I/O:

name = Console.ReadLine();                  // Reading input from STDIN
Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT

// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/

// Write your code here
using System;

namespace abc
{
    class Program
    {
        public static void Main()
        {
            int i;
           int N=Convert.ToInt32(Console.ReadLine());
           string a = Console.ReadLine();
           string b = Console.ReadLine();
           string[] StringA = a.Split(' ');
           
           int [] A = new int[a.Length];
           for(i=0;i<N;i++)
                A[i] = int.Parse(StringA[i]);
           
           int [] B = new int[b.Length];
           string[] StringB = b.Split(' ');
           for(i=0;i<N;i++)
                B[i] = int.Parse(StringB[i]);
           
           
           int [] C = new int[N];
                
           for(i=0;i<N;i++)
                C[i]=A[i]+B[i];
                
           for(i=0;i<N;i++)
                Console.Write(C[i]+" ");
            Console.ReadKey();
        }
    }
}