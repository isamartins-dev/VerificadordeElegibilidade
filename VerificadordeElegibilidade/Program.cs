using System;
class Program
{
    static void Main()
    {  
        Console.WriteLine("Digite sua idade");
        int idade = int.Parse(Console.ReadLine());


        Console.WriteLine("Qual a sua renda mensal?");
        double renda = double.Parse(Console.ReadLine());

        Console.WriteLine("Você está empregado? (s/n)");
        string empregada = Console.ReadLine().ToLower();

        bool maiorDeIdade = idade >= 18;
        bool rendaPermitida= renda <= 3000;
        bool estaEmpregada = empregada == "s" || empregada == "sim";

        if (maiorDeIdade && rendaPermitida && estaEmpregada)
        {
            Console.WriteLine("✅ Você está elegível.");
        }
        else
        {
            Console.WriteLine("❌ Você não está elegível.");
        }
    }
}

