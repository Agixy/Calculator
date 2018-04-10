using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    // public delegate int Operation(int x, int y);


    class Add : IOperation
    {
        public string Name => "Dodaj";

        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public Add(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public int Calculate(int number1, int number2)      // operacje to mają być delegaty
        {
            return number1 + number2;
        }
        

        //int Miltiply(int number1, int number2)
        //{
        //    return number1 * number2;
        //}

        //double Divide(int number1, int number2)
        //{
        //    return (double)number1 / number2;
        //}

        //int Power(int number1, int number2)
        //{
        //    return (int)Math.Pow(number1, number2);     // czy lepiej zwrócić double?
        //}

    }
}
