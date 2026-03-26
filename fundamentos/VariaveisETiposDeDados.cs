using System.Diagnostics;

namespace Fundamentos01;


public class VariaveisETiposDeDados
{
    string sobrenome = "sara";
    
public void Executar(){

Console.WriteLine("Variaveis E tipos de dados");
Console.WriteLine("Variaveis E tipos de dados");
Console.WriteLine();


int idade =25;
double altura = 1.75;
//float media = 1950;
char letra = 'A';
string nome = "Tony";
string nomeComposto = nome + "filho"; //concatenaçao
bool estudante = true;

Console.WriteLine($"int->idade:{idade} (numeros inteiros)");
Console.WriteLine($"double->altura:{altura} (numeros decimais)");
Console.WriteLine($"char->letra:{letra} (um unico caracter)");
Console.WriteLine($"string->nome:{nomeComposto} (texto)");
Console.WriteLine($"variavel global->sobrenome:{this.sobrenome} (booleano ou seja verdadeiro ou falso)");
Console.WriteLine($"bool->estudante:{estudante} (booleano ou seja verdadeiro ou falso)");


}

   
}