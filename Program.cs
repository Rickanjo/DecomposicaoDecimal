// Receba um número inteiro informado pelo usuário. Realize a decomposição decimal em unidades, dezenas e centenas.

int numero;
int unidades;
int dezenas;
int centenas;



Console.WriteLine("---Decomposição Decimal---\n");

Console.Write("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine()!);

unidades = numero % 10;
dezenas = (numero / 10) % 10;
centenas = numero / 100;

Console.WriteLine($"O número digitado foi {numero}\n");
Console.WriteLine($"Centenas: {centenas}\n");
Console.WriteLine($"Dezenas: {dezenas}\n");
Console.WriteLine($"Unidades: {unidades}\n");
Console.ReadLine();

