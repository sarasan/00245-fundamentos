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

Console.WriteLine("Introduza o valor da compra : \n");

double originalValue = Convert.ToDouble(Console.ReadLine());

double discount = (originalValue * 10 /100);
  

string desconto = (originalValue > 100) ? ($"Desconto:{discount}"): "Sem desconto";

Console.WriteLine($"{desconto}\n");

    
Console.WriteLine("=================================================\n");

Console.WriteLine ("EXERCÍCIO 4: Classificaçao de idade");

Console.WriteLine("===================================================\n");

Console.WriteLine("Introduza a idade: \n");

int idade = Convert.ToInt32(Console.ReadLine());

if(idade < 12)
        {
            Console.WriteLine("Criança");
        }
        else if (idade >=12 && idade < 18)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Adulto");
        }
        
        
Console.WriteLine("=================================================\n");

Console.WriteLine ("EXERCÍCIO 5: Menu com  Switch");

Console.WriteLine("===================================================\n");

Console.WriteLine("Escolha uma opçao:\n1: Novo jogo\n 2: Carregar jogo \n 3: Sair\n");

int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
         case 1:  Console.WriteLine ("Novo jogo") ; 

         break;

        case 2:  Console.WriteLine ("Carregar jogo") ; 

         break;
        
        //case 3:  Console.WriteLine ("Sair") ; 

        //break;

        default:

        Console.WriteLine ("Sair") ; 

        break;

        }

    Console.WriteLine("=================================================\n");

    Console.WriteLine ("EXERCÍCIO 6: Validaçao e acesso");

    Console.WriteLine("===================================================\n");

    int age;

    bool access;

    string invite;

    Console.WriteLine ("Idique a idade");

    age =Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Tem convite?(Sim ou Nao)");

    invite = Convert.ToString(Console.ReadLine());

    if(age >=18 && invite == "Sim")
        {
          access= true; 

          Console.WriteLine($"Pode entrar?{access}") ;
        }
        else
        {
            access= false; 

          Console.WriteLine($"Pode entrar?{access}") ; 
        }



        }
    

    }

