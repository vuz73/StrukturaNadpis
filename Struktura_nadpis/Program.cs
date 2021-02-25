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
    enum Color 
    { 
        Красный, Желтый, Зеленый, Синий, Голубой
    }
    class Program
    {
        struct Title
        {
            Color Tsvet;
            string Text;            
        }


        static void Main(string[] args)
        {

        }
    }
}
