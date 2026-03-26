namespace Fundamentos01;

 public class AlunoOperadoresLogicos()
{
    
    public void Executar()
    {
        
    Console.WriteLine(" 2. EXERCÍCIOS DE OPERADORES LÓGICOS");

    Console.WriteLine("====================================\n");

     Console.WriteLine("====================================\n");

    Console.WriteLine("EXERCÍCIO 1: Operador AND (&&)\n");
    // 
     Console.WriteLine("====================================\n");

    bool hasAge = true;

    bool hasLicense = false;


Console.WriteLine($"Tem idade? {hasAge}");

Console.WriteLine($"Tem carta? {hasLicense}");

Console.WriteLine();

Console.WriteLine($"Pode conduzir? -> (tem idade e carta){hasAge && hasLicense}");


  Console.WriteLine("====================================\n");

    Console.WriteLine("EXERCÍCIO 2: Operador OR(||)\n");
    
     Console.WriteLine("====================================\n");

    bool admin = true;

    bool loggedIn = false;


    Console.WriteLine($"Logged in? {loggedIn}\n");

   Console.WriteLine($"Is admin? {admin}");

  Console.WriteLine();

 Console.WriteLine($"Allowed access?{admin ||loggedIn}");


   Console.WriteLine("====================================\n");

    Console.WriteLine("EXERCÍCIO 3: Operador NOT\n");
    
     Console.WriteLine("====================================\n");

     bool originalvalue = true;

     Console.WriteLine($"original value: {originalvalue}\n");

   Console.WriteLine($"reverted value : {!originalvalue}");

  Console.WriteLine();

   }

    }
