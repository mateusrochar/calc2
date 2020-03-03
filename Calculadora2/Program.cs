using System;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {


            operation date = new operation();
            string verificador;
            bool verificadorError = true;

            string iniciador = "start";

            while (iniciador == "start")
            {
                Console.WriteLine();


                while (verificadorError) {
                    try
                    {
                        Console.Write("Insira o primeiro numero: ");

                        date.NumberA = double.Parse(Console.ReadLine().Trim());
                        Console.WriteLine();

                        verificadorError = false;
                    }
                    catch (Exception e)
                    {
                        Console.Write("Insira um numero valido, até 9 unidades.");
                        Console.WriteLine();
                        Console.WriteLine();
                        verificadorError = true;


                    }
                }


                verificadorError = true;
                while (verificadorError)
                {
                    try
                    {
                        Console.Write("Insira a operação(+;-;*;/): ");
                        date.Symbol = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine();
                       

                        verificadorError = false;
                    }
                    catch (Exception e)
                    {
                        Console.Write("Insira um simbolo válido.");
                        Console.WriteLine();
                        Console.WriteLine();
                        verificadorError = true;


                    }
                }

                verificadorError = true;
                while (verificadorError)
                {
                    try
                    {
                        Console.Write("Insira o segundo numero: ");
                        date.NumberB = double.Parse(Console.ReadLine().Trim());
                        Console.WriteLine();


                        verificadorError = false;
                    }
                    catch (Exception e)
                    {
                        Console.Write("Insira um numero valido, até 9 unidades.");
                        Console.WriteLine();
                        Console.WriteLine();
                        verificadorError = true;


                    }
                }


                date.Operation(date.Symbol);


                date.Sum = date.Result;

                Console.WriteLine("Resultado: "+date.Sum);
                Console.WriteLine();



                string iniciador2 = "start";

                while (iniciador2 == "start")
                {

                    Console.Write("Deseja continuar calculando(yes/no)? ");
                    verificador = Console.ReadLine().Trim().ToLower();
                    if (verificador == "yes")
                    {
                        date.NumberA = date.Sum;
                        Console.WriteLine();
                        Console.Write("Insira a operação(+;-;*;/): ");
                        date.Symbol = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine();




                        Console.Write("Insira o próximo numero: ");
                        try
                        {
                            date.NumberB = double.Parse(Console.ReadLine().Trim());
                        }
                        catch (Exception e)
                        {
                            Console.Write("Insira um numero valido, até 9 unidades."+ e.Message);

                        }




                        Console.WriteLine();


                        date.Operation(date.Symbol);

                        date.Sum = date.Result;
                        Console.WriteLine("Resultado: "+ date.Sum);
                        Console.WriteLine();


                    }

                    else if (verificador == "no")
                    {
                        iniciador2 = null;
                    }
                }

                Console.WriteLine();
                Console.Write("Deseja reiniciar ou desligar (restart/disconnect): ");
                verificador = Console.ReadLine().Trim().ToLower();


                if (verificador == "restart")
                {
                    date.NumberA = 0;
                    date.NumberB = 0;
                    date.Symbol = null;
                    date.Result = 0;
                    date.Sum = 0;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Calculadora Reiniciada.");

                }

                else if (verificador == "disconnect")
                {
                    iniciador = null;
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Calculator was turn off.");
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

