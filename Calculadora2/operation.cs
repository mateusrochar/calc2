using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora2
{
    class operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public double Result { get; set; }
        public string Symbol { get; set; }
        public double Sum { get; set; }



        public void Operation(string a)
        {

            if (a == "+")
            {
                Addition(NumberA, NumberB);
            }
            else if (a == "-")
            {
                Subtraction(NumberA, NumberB);
            }
            else if (a == "*")
            {
                Multiplication(NumberA, NumberB);
            }
            else if (a == "/")
            {
                Division(NumberA, NumberB);
            }
     


        }




        public void Addition (double numberA, double numberB)
        {
            Result = numberA + numberB;
        }

        public void Subtraction (double numberA, double numberB)
        {
            Result = numberA - numberB;
        }

        public void Multiplication (double numberA, double numberB)
        {
            Result = numberA * numberB;
        }

        public void Division (double numberA, double numberB)
        {
            Result = numberA / numberB;
        }


    }
}
