namespace Fundamentos01;

public class AlunoExercicioRevisao
{
    
public void ExecutarExercicioRevisao()
    {
    Console.WriteLine(" EXERCÍCIOS GERAIS DE REVISÃO");

    Console.WriteLine("=================================================\n");

    Console.WriteLine ("EXERCÍCIO 1: Verificar número positivo");

    Console.WriteLine("===================================================\n");
    
    Console.WriteLine("Por favor introduza um numero: \n");

    double num = Convert.ToDouble(Console.ReadLine());

    if(num > 0)
        {
            Console.WriteLine($"Positivo: {num}");

        }
        else if (num <0)
        {
            Console.WriteLine($"Negativo: {num}");
        }else
        {
            Console.WriteLine($"Zero: {num}");
        }

    Console.WriteLine("=================================================\n");

    Console.WriteLine ("EXERCÍCIO 2: Maior de dois números");

    Console.WriteLine("===================================================\n");

    Console.WriteLine("Por favor introduza o primeiro numero: \n");

    double n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Por favor introduza o segundo numero: \n");

    double n2 = Convert.ToDouble(Console.ReadLine());

    if (n1 > n2)
        {
            Console.WriteLine($"Numero 1 e maior: {n1}");

        }
        else if (n2 > n1)
    
        {
           Console.WriteLine($"Numero 2 e maior: {n2}"); 
        }
        else
        {
           Console.WriteLine($"Numero 1 e 2 sao iguais: \n {n2}\n {n2}");  
        }

    Console.WriteLine("=================================================\n");

    Console.WriteLine ("EXERCÍCIO 3: Sistema de desconto (operador ternário)");

    Console.WriteLine("===================================================\n");

    }

}