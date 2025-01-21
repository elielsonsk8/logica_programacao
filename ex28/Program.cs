// Ex 28 criar e imprimir um Array

int[] numeros = { 10, 20, 30, 40, 50 };

for (int a = 0; a < numeros.Length; a++)
{
    Console.WriteLine($"Na posiçâo {a} o número é: {numeros[a]}");
}

string[] nome = { "ana", "pedro", "joana", "Paulo " };

for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine($"O nome na posição {i} é: {nome[i]}");
}