using System;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {


            operation date = new operation();
            string verificador;

            string iniciador = "start";

            while (iniciador == "start")
            {

                Console.Write("Insira o primeiro numero:");
                date.NumberA = double.Parse(Console.ReadLine().Trim());

                Console.Write("Insira a operação(+;-;*;/):");
                date.Symbol = Console.ReadLine().Trim();

                Console.Write("Insira o segundo numero:");
                date.NumberB = double.Parse(Console.ReadLine().Trim());

                date.Operations(date.Symbol);

                Console.WriteLine("Resultado: "+date.Result);


                string iniciador2 = "start";

                while (iniciador2 == "start")
                {

                    Console.WriteLine("Deseja continuar calculando com o resultado(y/n)?");
                    verificador = Console.ReadLine().Trim();
                    if (verificador == "y")
                    {
                        Console.Write("Insira a operação(+;-;*;/):");
                        date.Symbol = Console.ReadLine().Trim();

                        Console.Write("Insira o segundo numero:");
                        date.NumberB = double.Parse(Console.ReadLine().Trim());

                        date.Operations(date.Symbol);

                        Console.WriteLine("Resultado: "+ date.Result);

                    }

                    else if (verificador == "n")
                    {
                        iniciador2 = null;
                    }
                }

                Console.WriteLine("Deseja reiniciar ou desligar (r/d): ");
                verificador = Console.ReadLine().Trim();


                if (verificador == "r")
                {
                    date.NumberA = 0;
                    date.NumberB = 0;
                    date.Symbol = null;
                    date.Result = 0;
                }

                else if (verificador == "d")
                {
                    iniciador = null;
                }

            }

            Console.WriteLine("Fim do cálculo.");
            Console.ReadLine();


        }
        /*


        double numberSum;
        string operation;
        string recebeNumero;
        int totalNumbers;





        // int a = 0;
        string b;


        for (int i = 1; i <= totalNumbers; i++)
        {
            Console.Write($"Entre com o {i}º numero: ");

            while (true)
            {
                string receberNumero = Console.ReadLine();

                if (double.TryParse(receberNumero.Trim(), out double a))
                {

                    numberSum.Add(a);
                    break;
                }
                else
                {
                    Console.WriteLine("Entre com um numero válido: o numerno deve ter até 9 digitos, não insira letras ou espaço.");

                }


            }


            if (i < totalNumbers)
            {

                while (true)
                {
                    Console.Write($"Insira o simbolo da operação que deseja realizar: +, -, /, *: ");
                    b = Console.ReadLine();
                    if (b.Trim() == "+" || b.Trim() == "-" || b.Trim() == "/" || b.Trim() == "*")
                    {

                        operation.Add(b);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entre com um simbolo válido.");
                    }
                }
            }

        }

        int k = 0;

        double sum = 0.0;

        for (int i = 0; i < totalNumbers; i++)
        {

            if (i == 0)
            {
                sum += numberSum[i];
            }

            else if (operation[k] == "+")
            {
                sum += numberSum[i];
                k++;
            }
            else if (operation[k] == "-")
            {
                sum -= numberSum[i];
                k++;

            }

            else if (operation[k] == "*")
            {
                sum *= numberSum[i];
                k++;

            }


            else if (operation[k] == "/")
            {
                sum /= numberSum[i];

            }



        }

        Console.WriteLine($"O valor calculado é: {sum}");
        Console.ReadLine();

  */
    }
}

