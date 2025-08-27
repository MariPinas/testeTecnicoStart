using testeTecnicoStart.Model;

// Nome: Mariana Pereira Lima dos Santos

// DESAFIO 1
Console.WriteLine();
ContaBancaria conta = new ContaBancaria(1, "Maria");
conta.Depositar(1000);
conta.Sacar(500);
conta.ExibirSaldo();

Console.WriteLine();
Console.WriteLine("-----");
Console.WriteLine();

//DESAFIO 2
Carro carro = new Carro("Ford", "Ka", 2020, 4);
Moto moto = new Moto("Yamaha", "MT-03", 2022, 321);

carro.ExibirInfo();
moto.ExibirInfo();

Console.WriteLine();

//DESAFIO 3
//PROMPT:
/**
Tenho uma classe Pessoa em C# a qual um de seus atributos é Idade.
Quero ordenar uma lista de Pessoas pela idade em ordem crescente e também em ordem decrescente. 
Poderia me mostrar exemplos de código em C#?
**/