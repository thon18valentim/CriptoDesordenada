using System;
using System.Collections.Generic;
using System.Text;

namespace Cripto
{
  public static class Desordenamento
  {
    static readonly Dictionary<char, char> QuebradoAoMeio = new Dictionary<char, char>()
        {
            {'A','N'},
            {'B','O'},
            {'C','P'},
            {'D','Q'},
            {'E','R'},
            {'F','S'},
            {'G','T'},
            {'H','U'},
            {'I','V'},
            {'J','W'},
            {'K','X'},
            {'L','Y'},
            {'M','Z'},
            {'N','A'},
            {'O','B'},
            {'P','C'},
            {'Q','D'},
            {'R','E'},
            {'S','F'},
            {'T','G'},
            {'U','H'},
            {'V','I'},
            {'W','J'},
            {'X','K'},
            {'Y','L'},
            {'Z','M'}
        };

    static readonly Dictionary<char, char> DoisVizinhos = new Dictionary<char, char>()
        {
            {'A','B'},
            {'B','A'},
            {'C','D'},
            {'D','C'},
            {'E','F'},
            {'F','E'},
            {'G','H'},
            {'H','G'},
            {'I','J'},
            {'J','I'},
            {'K','L'},
            {'L','K'},
            {'M','N'},
            {'N','M'},
            {'O','P'},
            {'P','O'},
            {'Q','R'},
            {'R','Q'},
            {'S','T'},
            {'T','S'},
            {'U','V'},
            {'V','U'},
            {'W','X'},
            {'X','W'},
            {'Y','Z'},
            {'Z','Y'}
        };

    static readonly Dictionary<char, char> SeqTeclado = new Dictionary<char, char>()
        {
            {'A','Q'},
            {'B','W'},
            {'C','E'},
            {'D','R'},
            {'E','T'},
            {'F','Y'},
            {'G','U'},
            {'H','I'},
            {'I','O'},
            {'J','P'},
            {'K','A'},
            {'L','S'},
            {'M','D'},
            {'N','F'},
            {'O','G'},
            {'P','H'},
            {'Q','J'},
            {'R','K'},
            {'S','L'},
            {'T','Z'},
            {'U','X'},
            {'V','C'},
            {'W','V'},
            {'X','B'},
            {'Y','N'},
            {'Z','M'}
        };

    private static char? SearchLetter(char code, int tecEnum)
    {
      switch (tecEnum)
      {
        case 1:
          foreach (KeyValuePair<char, char> item in QuebradoAoMeio)
          {
            if (item.Value == code)
            {
              return item.Key;
            }
          }
          break;
        case 2:
          foreach (KeyValuePair<char, char> item in DoisVizinhos)
          {
            if (item.Value == code)
            {
              return item.Key;
            }
          }
          break;
        case 3:
          foreach (KeyValuePair<char, char> item in SeqTeclado)
          {
            if (item.Value == code)
            {
              return item.Key;
            }
          }
          break;
      }

      return null;
    }

    private static char? SearchCode(char letter, int tecEnum)
    {
      switch (tecEnum)
      {
        case 1:
          foreach (KeyValuePair<char, char> item in QuebradoAoMeio)
          {
            if (item.Key == letter)
            {
              return item.Value;
            }
          }
          break;
        case 2:
          foreach (KeyValuePair<char, char> item in DoisVizinhos)
          {
            if (item.Key == letter)
            {
              return item.Value;
            }
          }
          break;
        case 3:
          foreach (KeyValuePair<char, char> item in SeqTeclado)
          {
            if (item.Key == letter)
            {
              return item.Value;
            }
          }
          break;
      }

      return null;
    }

    public static string ToCode(string message, int tecEnum)
    {
      var newCode = "";

      foreach (char letter in message.Replace(" ", "").ToUpper())
      {
        newCode += SearchCode(letter, tecEnum);
      }

      return newCode;
    }

    public static string ToUnCode(string code, int tecEnum)
    {
      var newCode = "";
      foreach (char cd in code.Replace(" ", "").ToUpper())
      {
        newCode += SearchLetter(cd, tecEnum);
      }

      return newCode;
    }
  }

  public enum TecnicasDesordenamento
  {
    QuebradoAoMeio,
    DoisVizinhos,
    SeqTeclado
  }
}
