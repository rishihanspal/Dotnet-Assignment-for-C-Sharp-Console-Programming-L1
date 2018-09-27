using System;
 
namespace abc
{
    class Program
    {
        public static void Main()
        {
            int i, j, N, K, min=0;
            int T=Convert.ToInt32(Console.ReadLine());
            int [] Out = new int[T];  
            for(i=0; i<T; i++)
            {
                min=99999999;
                int [] input = Array.ConvertAll(Console.ReadLine().Split(' '), e => Convert.ToInt32(e));
                N=input[0];
                K=input[1];
                int [] A = Array.ConvertAll(Console.ReadLine().Split(' '),e => Convert.ToInt32(e));
                for(j=0;j<A.Length;j++)
                {
                    if(min>A[j])
                    {
                        min=A[j];
                    }
                }
                if(min<K)
                Out[i] = K-min;
                else 
                Out[i]=0;
            }
            for(i=0;i<Out.Length;i++)
                Console.WriteLine(Out[i]);
            Console.ReadKey();
        }
    }
}