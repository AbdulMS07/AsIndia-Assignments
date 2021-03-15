using System;
using System.Collections.Generic;
namespace Missingnumber
{
    class Program
	{	
		static int getMissingNo(int[] a, int n)
		{
        int total = (n + 1) * (n + 2) / 2;
 
        for (int i = 0; i < n; i++)
            total -= a[i];
 
        return total;
		}
		
        public static void Main(string[] args)
        {
			int conv_n;
            string n = Console.ReadLine();
			conv_n = Convert.ToInt32(n);
			
			string line=Console.ReadLine();
			string[] inputString=line.Split(' ');
			
			int[] intArray = new int[inputString.Length];
			for(int i=0;i<inputString.Length;i++)
			{
				intArray[i]=int.Parse(inputString[i]);
			}
			int miss=getMissingNo(intArray,intArray.Length);
			Console.Write(miss);
		}
	}
}