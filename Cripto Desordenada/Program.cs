using System;
using Cripto;

namespace Cripto_Desordenada
{
  class Program
  {
    static void Main(string[] args)
    {
      var codigo = Desordenamento.ToCode("othon", TecnicasDesordenamento.QuebradoAoMeio);
      var decr = Desordenamento.ToUnCode(codigo, TecnicasDesordenamento.QuebradoAoMeio);

      Console.WriteLine(codigo);
      Console.WriteLine(decr);
    }
  }
}
