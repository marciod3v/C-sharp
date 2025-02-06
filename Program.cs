using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso = 0;
            double altura = 0;
            double imc = 0;
            string resposta = "SIM";
            string sexo = "";

            string respostaFinal = resposta.ToLower();

            do
            {
                Console.WriteLine("Digite seu sexo (M) para masculino e (F) para feminino");
                sexo = Console.ReadLine();
                sexo.ToUpper();
                if (sexo == "M")
                {
                    Console.WriteLine("Digite seu peso:");
                    peso = double.Parse(Console.ReadLine());
                    if (peso < 0)
                    {
                        Console.WriteLine("Peso inválido");
                        return;
                    }
                    Console.WriteLine("Digite sua altura:");
                    altura = double.Parse(Console.ReadLine()) / 100;
                    if (altura < 0 || altura > 2.51)
                    {
                        Console.WriteLine("Altura inválida");
                        return;
                    }
                    imc = peso / (altura * altura);
                    Console.WriteLine($"Seu imc é: {imc.ToString("F2")}");
                    if (imc <= 19)
                    {
                        Console.WriteLine("Abaixo do peso ideal.");

                    }
                    else if (imc >= 20 && imc <= 24.9)
                    {
                        Console.WriteLine("Peso ideal.");

                    }
                    else if (imc >= 25 && imc <= 29.9)
                    {
                        Console.WriteLine("Obesidade leve.");

                    }
                    else if (imc >= 30 && imc <= 39.9)
                    {
                        Console.WriteLine("Obesidade moderada.");

                    }
                    else
                    {
                        Console.WriteLine("Obesidade Mórbida.");

                    }
                }
                else
                {

                    Console.WriteLine("Digite seu peso:");
                    peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite sua altura:");
                    altura = double.Parse(Console.ReadLine()) / 100;
                    imc = peso / (altura * altura);
                    Console.WriteLine($"Seu imc é: {imc.ToString("F2")}");
                    if (imc <= 18)
                    {
                        Console.WriteLine("Abaixo do peso ideal.");
                        Console.WriteLine("Deseja repetir a operação ?");
                        respostaFinal = Console.ReadLine();
                    }
                    else if (imc >= 20 && imc <= 23.9)
                    {
                        Console.WriteLine("Peso ideal.");

                    }
                    else if (imc >= 24 && imc <= 28.9)
                    {
                        Console.WriteLine("Obesidade leve.");

                    }
                    else if (imc >= 29 && imc <= 38.9)
                    {
                        Console.WriteLine("Obesidade moderada.");

                    }
                    else
                    {
                        Console.WriteLine("Obesidade Mórbida.");

                    }

                    Console.WriteLine("Deseja repetir a operação ? (sim/nao)");
                    resposta = Console.ReadLine();
                }

            } while (respostaFinal == "sim");
        }

    }
}