/*
    Создать структуру "надпись" с полями:
    - цвет (перечисление);
    - текст (string).
    
    Написать функцию, которая принимает такую структуру как параметр и выводит в консоль надпись соответствующим цветом.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktura_nadpis
{
    
    
    class Program
    {
        struct Nadpis
        {
            enum Tsvet : int
            {
                Red, Yellow, Green, Blue, Cyan
            }

            string Srt;

        }
        static void Main(string[] args)
        {
            
        
        
        }
    }
}
