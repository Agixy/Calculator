using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class Add : IOperation
    {
        public string Name => "Dodaj";

        public double Calculate(int number1, int number2)      // operacje to mają być delegaty
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
