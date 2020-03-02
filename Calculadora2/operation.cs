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



        public void Operations(string a)
        {

            if(a == "+")
            {
                Sum(NumberA, NumberB);
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




        public double Sum (double numberA, double numberB)
        {
            return numberA + numberB;
        }

        public double Subtraction (double numberA, double numberB)
        {
            return numberA - numberB;
        }

        public double Multiplication (double numberA, double numberB)
        {
            return numberA * numberB;
        }

        public double Division (double numberA, double numberB)
        {
            return numberA / numberB;
        }


    }
}
