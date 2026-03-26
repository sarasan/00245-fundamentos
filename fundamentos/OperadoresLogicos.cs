namespace Fundamentos01;

public class OperadoresLogicos{
   public void Executar(){

    Console.WriteLine("Operadores logicos");

  bool temIdade = true;
  bool temCarta = false;




Console.WriteLine($"Tem IDADE? {temIdade}");
Console.WriteLine($"Tem carta? {temCarta}");

Console.WriteLine();

Console.WriteLine($"Pode conduzir? -> (tem idade e carta){temIdade && temCarta} (AND)");

Console.WriteLine($"Pode tentar? -> (tem idade e carta){temIdade && temCarta} (AND)");


   } 

}//end class