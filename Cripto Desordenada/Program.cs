using System;
using Cripto;

namespace Cripto_Desordenada
{
  class Program
  {
    static void Main(string[] args)
    {
      var codigo = Desordenamento.ToCode("othon", 1);
      var decr = Desordenamento.ToUnCode(codigo, 1);

      Console.WriteLine(codigo);
      Console.WriteLine(decr);
    }
  }
}
