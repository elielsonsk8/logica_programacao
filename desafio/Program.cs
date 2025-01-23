/*
 * Escreva um programa que solicite o primeiro nome do usuario em seguida solicite o sobrenome do usuario. O programa deve apresentar uma messagem de boas vindas e o nome do usuario
 */
Console.WriteLine("Informe o seu primeiro nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe o seu sobrenome");
string sobreNome = Console.ReadLine();

Console.WriteLine($"Olá! seja bem-vindo: {nome} {sobreNome}");