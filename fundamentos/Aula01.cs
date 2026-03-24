namespace Fundamentos01;

public class Aula01
{
    
private void ExibirCabecalho(){

Console.WriteLine("======================================");
Console.WriteLine();

}

private void ResumoAula()
    {
Console.WriteLine();      
Console.WriteLine("======================================");
Console.WriteLine("fim da aula-resumo");
Console.WriteLine("======================================");
Console.WriteLine("o k e algoritmia");
Console.WriteLine("variaveis e tipos de dados");
Console.WriteLine("o k e algoritmia");


        
    }

public void executarAula()
    {
        
    this.ExibirCabecalho();  

    VariaveisETiposDeDados variaveisETiposDeDados = new VariaveisETiposDeDados();

   variaveisETiposDeDados.Executar();

   Console.WriteLine();

   OperadoresAritmeticos  operadoresAritmeticos = new OperadoresAritmeticos();
   
   operadoresAritmeticos.Executar();

  Console.WriteLine();

   OperadoresComparacao operadoresComparacao= new OperadoresComparacao();
  
   operadoresAritmeticos.Executar();
     

    }



    
}//fim aula 01

