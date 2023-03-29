Console.WriteLine($"Digite o nome do aluno:");
Console.ReadLine();

Console.WriteLine($"Digite a primeira nota:");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a segunda nota:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a terceira nota:");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quarta nota:");
int nota4 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a quinta nota:");
int nota5 = int.Parse(Console.ReadLine());

int soma = nota1 + nota2 + nota3 + nota4 + nota5;

float resultado = soma / 5;

Console.WriteLine($"A média do aluno é: {resultado}");

if (resultado > 5)

Console.WriteLine($"Aluno aprovado");

else

Console.WriteLine($"Aluno reprovado");






