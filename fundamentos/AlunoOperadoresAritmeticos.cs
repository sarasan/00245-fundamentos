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

    Console.WriteLine("=========================================\n");

    Console.WriteLine("EXERCÍCIO 3: Operador de modulo(%)"); 
    
    Console.WriteLine("=========================================\n");


  Console.WriteLine("Por favor insira o num1 \n");

    double numb1= Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Por favor insira o num2 \n");

    double numb2 = Convert.ToDouble(Console.ReadLine());

//int resto = ConvertToDouble(numb1 % numb2);

    Console.WriteLine($"O resto da divisao e: {numb1} % {numb2 } = {numb1 % numb2}\n");

   


    }

}