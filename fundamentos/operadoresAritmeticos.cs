namespace Fundamentos01;

public class OperadoresAritmeticos
{
   public void Executar(){

    Console.WriteLine("Operador Aritmeticos");

    int a = 10;
    int b = 3;

Console.WriteLine($"variavel a = {a}, variavel b = {b}");
Console.WriteLine($"Soma (a+b) = {a + b}");
Console.WriteLine($"Subtracçao (a-b) = {a - b}");
Console.WriteLine($"multiplicaçao (axb) = {a * b}");
Console.WriteLine($"Divisao (a/b) = {a / b}");
Console.WriteLine($"Modulo (a%b) = {a % b}(Quando precisarmos saber se o numero e par ou impar)");

   } 

}//end class