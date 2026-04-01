namespace Fundamentos01;

public class AlunosCondicionais
{
    

public void Executar()
    {
         
        Console.WriteLine ("1. EXERCICIOS DE ESTRURURAS CONDICIONAIS\n");

        Console.WriteLine("======================================");

        Console.WriteLine("Exercicio1. Classificaçao de numeros\n");

         Console.WriteLine("======================================");

        Console.WriteLine("Insira um numero:\n");

        double num = Convert.ToInt32(Console.ReadLine());

        if(num > 0)
        {
            Console.WriteLine("POSITIVO");
        }
        else if(num <  0)
        {
           Console.WriteLine("NEGATIVO"); 
        }
        else if(num == 0)
        {
          Console.WriteLine("ZER0"); 
        } 
/////////////////////////////////////////////////////////////
        Console.WriteLine("======================================");

        Console.WriteLine("Exercicio2. Par ou Impar\n");

        Console.WriteLine("======================================");

        Console.WriteLine("Insira um numero:\n");

        double n1 = Convert.ToInt32(Console.ReadLine());

        string output = (n1 % 2 == 0) ? "Par": "Impar";

    Console.WriteLine($"numero : {n1} -> {output }");

    ///////////////////////////////////////////////
    Console.WriteLine("======================================");

    Console.WriteLine("Exercicio3. Dias da semana(switch case)\n");

    Console.WriteLine("======================================");

    Console.WriteLine("Insira um numero de 1 a 7:\n");

    int dia = Convert.ToInt32(Console.ReadLine());

    switch(dia)
        {
            case 1: 

             Console.WriteLine("Dia: 2F") ;

             break;

             case 2: 

             Console.WriteLine("Dia: 3F") ;

             break;

            case 3: 

             Console.WriteLine("Dia: 4F") ;

             break;

            case 4: 

             Console.WriteLine("Dia: 5F") ;

             break;

             case 5: 

             Console.WriteLine("Dia: 6F") ;

             break;

            case 6: 

             Console.WriteLine("Dia: Sabado") ;

             break;

            default: 

             Console.WriteLine("Dia: Domingo") ;

             break;
             
             }

 ///////////////////////////////////////////////
    Console.WriteLine("======================================");

    Console.WriteLine("Exercicio4. Sistema de autenticaçao\n");

    Console.WriteLine("======================================");

    string USER = "admin";

    string PWD = "1234";

    Console.WriteLine("Insira username\n ");

    string username = Console.ReadLine();

    Console.WriteLine("Insira password\n");

    String  pwdss  = Console.ReadLine();  



    if(USER == username && PWD == pwdss )
        {
          Console.WriteLine ($"Username: {username }\n");

          Console.WriteLine("Password:");

          Console.WriteLine(new string('*', pwdss.Length));

          Console.WriteLine("Acesso permitido");  
        }
        else
        {
           Console.WriteLine("Acesso negado");   
        }

    }
    }
