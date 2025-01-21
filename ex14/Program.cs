/*
Ex14. Soma de Números
   Escreva um programa que permita ao usuário inserir números inteiros. O programa deve continuar solicitando números até que o usuário digite 0. Ao final, quando 0 for digitado, o programa deve calcular e exibir a soma de todos os números inseridos (exceto o 0). Utilize um laço while para realizar essa tarefa.
*/

int numero = 0;
int soma = 0;

while (true)
{
    Console.WriteLine("Dígite um número (ou 0 para sair): ");
    numero = int.Parse(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }
    soma += numero;
    Console.WriteLine("A soma dos números digitados é: " + soma);
}