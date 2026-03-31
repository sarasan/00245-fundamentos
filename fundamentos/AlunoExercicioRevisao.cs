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
            Console.WriteLine($" {n1} maior que {n2}\n");

        }
        else if (n2 > n1)
    
        {
           Console.WriteLine($" {n2} maior que {n1}\n"); 
        }
        else
        {
           Console.WriteLine($"  {n1} e {n2} sao iguais\n");  
        }

Console.WriteLine("=================================================\n");

Console.WriteLine ("EXERCÍCIO 3: Sistema de desconto (operador ternário)");

Console.WriteLine("===================================================\n");

Console.WriteLine("Por favor introduza o valor da compra : \n");

double originalValue = Convert.ToDouble(Console.ReadLine());

double discount = (originalValue * 10 /100);
  

string desconto = (originalValue > 100) ? ($"Desconto:{discount}"): "Sem desconto";

Console.WriteLine($"{desconto}\n");

    
Console.WriteLine("=================================================\n");

Console.WriteLine ("EXERCÍCIO 4: Classificaçao de idade");

Console.WriteLine("===================================================\n");

Console.WriteLine("Por favor introduza a idade: \n");

int idade = Convert.ToInt32(Console.ReadLine());

if(idade < 12)
        {
            Console.WriteLine("Criança");
        }

        }
    

    }

