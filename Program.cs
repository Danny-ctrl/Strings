using System;
using System.Text;

namespace DiversosString
{
  class Program
  {

    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";

      System.Console.WriteLine(texto.IndexOf("é"));/// conta a primeira string 
      System.Console.WriteLine(texto.LastIndexOf("s"));/// conta a ultima string 
      System.Console.WriteLine(texto.ToLower());///converter as strings em maiusculo
      System.Console.WriteLine(texto.ToUpper());///converter as string em minusculo
      System.Console.WriteLine(texto.Insert(11, "aqui"));///inserir 
      System.Console.WriteLine(texto.Remove(11, 5));///remover 
      System.Console.WriteLine(texto.Length);///mostra a quantidade de caracteres de uma string ou arrray
      System.Console.WriteLine(texto.Replace("Este", "Esse"));///substitui o caracter
      var divisao = texto.Split(" ");/// divide o array  em textos
      System.Console.WriteLine(divisao[0]);
      System.Console.WriteLine(divisao[1]);
      System.Console.WriteLine(divisao[2]);
      System.Console.WriteLine(divisao[3]);
      System.Console.WriteLine(divisao[4]);

      var resultado = texto.Substring(5, 5);///mostra a string selecionada de acordo com a posição
      System.Console.WriteLine(resultado);
      System.Console.WriteLine(texto.Trim());///remove os espaços do inicio e fim de um array


    }
  }
}
