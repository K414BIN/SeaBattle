using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Lesson3
{     
      class Program {
       
        static void Main()
        {    
            string[,] addrBook = new string[5,2];  
            Console.WriteLine("Добро пожаловать в *Телефонный справочник*!");
            Console.WriteLine("Введите имена и телефоны( или E-mail) своих пятерых знакомых.");
            for (int i=0;i<addrBook.GetLength(0);i++) {
                               Console.WriteLine("Добавим  запись");
                               for (int j=0;j<addrBook.GetLength(1);j++) {
                               addrBook[i,j]=System.Console.ReadLine();
                                                                          }
                                                       }
        }
//+++++++++++++++++++++
                    }
}