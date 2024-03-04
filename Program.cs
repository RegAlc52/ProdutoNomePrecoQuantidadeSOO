using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do produto:");
        string nomeProduto = Console.ReadLine();

        Console.WriteLine("Digite o preço unitário do produto:");
        double precoUnitario;
        while (!double.TryParse(Console.ReadLine(), out precoUnitario) || precoUnitario <= 0)
        {
            Console.WriteLine("Preço inválido. Digite novamente:");
        }

        Console.WriteLine("Digite a quantidade desejada:");
        int quantidade;
        while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
        {
            Console.WriteLine("Quantidade inválida. Digite novamente:");
        }

        double desconto = quantidade > 50 ? 0.25 : quantidade > 20 ? 0.20 : quantidade > 10 ? 0.10 : 0;
        double valorTotal = precoUnitario * quantidade * (1 - desconto);
        double valorDesc = precoUnitario * quantidade * desconto;

        Console.WriteLine($"Nome do produto: {nomeProduto}");
        Console.WriteLine($"Preço unitário do produto: R${precoUnitario:F2}");
        Console.WriteLine($"Quantidade desejada: {quantidade}");
        Console.WriteLine($"Valor total do produto: R${valorTotal:F2}");
        Console.WriteLine($"Valor total do desconto: R${valorDesc:F2}");
    }
}



//Faça um programa que solicite em tela para o usuario
//o nome do produto = int
//o preço unitário do produto = double
//a quantidade desejada do produto = int
//valor total do produto
//valor do desconto recebido na compra
// aplique descontos se
//quantidade maior que  50 desconto de 0.25% = double
//quantidade maior  20 desconto de 0.20 = double
//quantidade maior 10 desconto 0.10 = double
