namespace Fundamentos01;

public class EstruturasControloBasicas
{
    

    public void ExecutarIfElse()
    {
      Console.WriteLine("Estruturas de controlo basicas");  
      Console.WriteLine();

      //ESTRUTURA IF-ELSE

      int nota = 14;

      Console.WriteLine($"Nota do aluno: {nota}");

      if(nota > 14)
        {
            Console.WriteLine("Situaçao: APROVADO(IF)");
        }
        else
        {
            Console.WriteLine($"REPROVADO(ELSE)");
        }

    }


    //Estrutura switch case
    //compara um avaraiavel com multiplos valores

    public void ExecutarSwitchCase()

    {
    int diaDaSemana = 3;

    Console.WriteLine($"Numero do dia da Semana{diaDaSemana}") ;

    switch(diaDaSemana)
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
        
    }

//ternario e 1 forma compacta der IF E ELSE(? VERDADEIRO : FALSO)
public void ExecutarTernario()
    {
    int idade = 18;

    string status = (idade >= 18) ? "Maior 18": "Menor 18";

    Console.WriteLine($"idade : {idade} -> {status}");

    }

    }