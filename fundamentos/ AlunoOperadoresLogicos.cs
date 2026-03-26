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

  Console.WriteLine("====================================\n");

    Console.WriteLine("EXERCÍCIO 4: Combinaçao de operadores");
    
     Console.WriteLine("====================================\n");

     bool entrance = true ;

     bool invitation = false;

     bool VIP = true;


      Console.WriteLine($"Has entrance ? {entrance}\n");

   Console.WriteLine($"Has invitation? {invitation}\n");

    Console.WriteLine($"Is VIP ? {VIP}");

  Console.WriteLine();

 Console.WriteLine($"Allowed entrance?{(true || false) && true }");

   Console.WriteLine("====================================\n");

    Console.WriteLine("EXERCÍCIO 4: Logic table(practice)");
    
     Console.WriteLine("=============AND=======================\n");


    Console.WriteLine($"true && true: {true && true}");

    Console.WriteLine($"true && false: {true && false}");
   
   Console.WriteLine($"false && true: {false && true}");
   
   Console.WriteLine($"false && false: {false && false }\n");
   
     Console.WriteLine("=============OR=======================\n");

 Console.WriteLine($"true || true: {true || true}");

    Console.WriteLine($"true || false: {true || false}");
   
   Console.WriteLine($"false || true: {false || true}");
   
   Console.WriteLine($"false || false: {false || false }\n");

   }

    }
