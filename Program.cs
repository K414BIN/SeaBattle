using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
             int[,] arr = new int [10,10];
			 // Использование случайных чисел
			 var rand = new Random();
			 for (int i=0;i<arr.GetLength(0);i++)
			 {
			 for (int j=0;j<arr.GetLength(1);j++) 
			      {
					
					arr[i,j]=rand.Next(101);; // возмем числа от 0 до 100 
				    if (arr[i,j] % 2 ==0) System.Console.Write(" X");
					else System.Console.Write(" O");
			      }
				  System.Console.WriteLine();
			 }
            Console.ReadLine();


        }
    }
}
