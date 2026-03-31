using System.Security.AccessControl;

namespace Fundamentos01;

public class AlunoOperadoresAritmeticos
{
    
public void Executar()
    {
    Console.WriteLine("\n 3. EXERCÍCIOS DE OPERADORES ARITMÉTICOS");

    Console.WriteLine("=========================================\n");

    Console.WriteLine("EXERCÍCIO 1: Soma e subtração"); 
    
    Console.WriteLine("=========================================\n");

    int num1 = 10;

    int num2 = 30;

    Console.WriteLine($"Soma: {num1} + {num2} = {num1 + num2}");

    Console.WriteLine($"Subtraçao: {num1} + {num2} = {num1 - num2}");

    ///////////////////////////////////////////////////

    Console.WriteLine("=========================================\n");

    Console.WriteLine("EXERCÍCIO 2: Cálculo de área do rectângulo"); 
    
    Console.WriteLine("=========================================\n");

    double largura = 5.0;

    double altura = 6.0;

    Console.WriteLine($"Area do triangulo e: {largura} x {altura} = {largura * altura}\n");

     //2.2 -> ask values to the user

    Console.WriteLine("Por favor insira a largura \n");

    double largura1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Por favor insira a altura \n");

    double altura1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Area do triangulo e: {largura1} x {altura1 } = {largura1 * altura1}\n");

////////////////////////////////////////////////////////////

    Console.WriteLine("=========================================\n");

    Console.WriteLine("EXERCÍCIO 3: Operador de modulo(%)"); 
    
    Console.WriteLine("=========================================\n");

    Console.WriteLine("Por favor insira o num1 \n");

    double numb1= Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Por favor insira o num2 \n");

    double numb2 = Convert.ToDouble(Console.ReadLine());

    int resto = (int)(numb1 % numb2);

    Console.WriteLine($"O resto da divisao e: {numb1} % {numb2 } = {resto }\n");

//////////////////////////////////////////////////////   

    Console.WriteLine("=========================================\n");

    Console.WriteLine("EXERCÍCIO 4: Multiplicaçao e divisao"); 
    
    Console.WriteLine("=========================================\n");

    double n1, n2;

    Console .WriteLine("Por favor insira o primeiro numero\n");

    n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Por favor insira o segundo numero\n");

    n2 = Convert.ToDouble(Console.ReadLine());

    double divide =(double)(n1/n2);

    int product = (int)(n1* n2);
//////////////////////exercicio5 incremento
/// 
    n1++;
    
    n2++;

    Console.WriteLine($"Numero 1 incrementado {n1}\n");

     Console.WriteLine($"Numero 2 incrementado {n2}\n");

    Console.WriteLine($"Divisao: {n1} / {n2} = {divide }\n");

    Console.WriteLine($"Multiplicaçao: {n1} x {n2} = {product }\n");





    }




}