﻿//Ex24: Implemente um programa que permita ao usuário inserir números inteiros. O programa deve continuar solicitando números até que o usuário digite 0. 

// Ao final, quando 0 for digitado, o programa deve calcular e exibir a soma de todos os números inseridos (exceto o 0). */

int soma = 0;

for (int numero = -1; numero != 0;)
{
    Console.WriteLine("Digite um número (0 para sair): ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero != 0)
    {
        soma += numero;
    }
    Console.WriteLine("Soma total: " + soma);
}