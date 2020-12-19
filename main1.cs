using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Lesson3
{     
      class Program {
       
        static void Main(string[] args )
        {    
            int[,] arr = new int [10,10];
            // запускаем генератор случайных чисел
            var  rand = new Random();
            Console.WriteLine("Элементы главной диагонали матрицы");
            for (int i=0;i<arr.GetLength(0);i++) {
                         Console.WriteLine();
                     for (int j=0;j<arr.GetLength(1);j++) { 
                                      arr[i,j]=rand.Next(89)+10;//используем числа от 10 до 99 для красивой картинки
                                     if (i==j) Console.Write("  "+ arr[i,j]);
                                     else Console.Write("   ");
                                                          }
                                                 }
            Console.WriteLine();    
            Console.WriteLine("Исходная матрица 10Х10 элементов");
            for (int i=0;i<arr.GetLength(0);i++) {      
                                Console.WriteLine();
                     for (int j=0;j<arr.GetLength(1);j++) { 
                                 Console.Write(" "+ arr[i,j]);
                                                           }
                                                       }
            Console.WriteLine();       
          }
//+++++++++++++++++++++
                    }
}