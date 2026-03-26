
 namespace Fundamentos01;

public class ExerciciosVariaveisETiposDeDados{

    string surname = "Trovalds";

    public void Executar()
        {
            Console.WriteLine("\n 1. EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS");
            Console.WriteLine("=============================================\n");

            Console.WriteLine("=============================================\n");

            Console.WriteLine("EXERCÍCIO 1: Declaração de variáveis básicas");

            Console.WriteLine("=============================================\n");
            

            int number = 10;

            float avg =  1.2f;

            double height = 1.4;

            char chrt = 'S';

            string name = "Sara";

            string compoundName = name + " Sntos";

            bool student = true; 

            Console.WriteLine($" int -> number:{number}");

            Console.WriteLine($"float-> avg:{avg}");

            Console.WriteLine($"double -> height:{height}");

            Console.WriteLine($"char -> chrt: {chrt}");

            Console.WriteLine($"String -> name: {name}");

            Console.WriteLine($"String -> compoundName: {compoundName}");

            Console.WriteLine($"boolean -> student: {student}");

            Console.WriteLine();

            Console.WriteLine("EXERCÍCIO 2: Reatribuição de valores");

            Console.WriteLine("=============================================\n");


             number = 20;

             avg =  1.3f;

             height = 3.4;

             chrt = 'A';

             name = "Sean";

             compoundName = name + " Williams";

             student = false; 


 Console.WriteLine($" number:{number}");

            Console.WriteLine($"avg:{avg}");

            Console.WriteLine($"height:{height}");

            Console.WriteLine($"chrt: {chrt}");

            Console.WriteLine($"name: {name}");

            Console.WriteLine($"compoundName: {compoundName}");

            Console.WriteLine($"student: {student}");

            Console.WriteLine();

//Exercicio 3
            Console.WriteLine($"variavel global->sobrenome:{this.surname}");

}
}

