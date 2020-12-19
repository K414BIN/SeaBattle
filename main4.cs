using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
   namespace Lesson3
{      

     public class Program {
       
      public static void Main(string[] args )
        {    
            const int seaField =10;
            int z=0;
            char[,] arr = new char [seaField,seaField];
            int[] fibon = new int[] {1,2,3,5,8,13,21,34,55,89};
            Console.WriteLine("Поле для игры *Морской бой*");
            for (int i=0;i<arr.GetLength(0);i++) { 
                                          for (int j=0;j<arr.GetLength(1);j++) { 
                                          if (z==fibon[j])      {arr[i,j]='X'; }
                                          else                  {arr[i,j]='O'; }
                                                                               }
                                     z++;      }
            Console.WriteLine();    
        
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