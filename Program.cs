using System;

namespace Calculator

{
   class Program
   {
      static void Main(string[] args)
      {
         Soma();
         Subtracao();
         Divisao();
         Multiplicacao();
      }
      static void Soma()
      {
         Console.Clear();
         Console.WriteLine("Primeiro valor: ");
         float v1 = float.Parse(Console.ReadLine());

         Console.WriteLine("Segundo valor: ");
         float v2 = float.Parse(Console.ReadLine());

         float resultado = v1 + v2;

         Console.WriteLine("");

         Console.WriteLine($"A soma dos valores é {resultado}");
         Console.ReadKey();
      }
      static void Subtracao()
      {
         Console.Clear();

         Console.WriteLine("Primeiro valor: ");
         float v1 = float.Parse(Console.ReadLine());

         Console.WriteLine("Segundo valor: ");
         float v2 = float.Parse(Console.ReadLine());

         Console.WriteLine("");

         float resultado = v1 - v2;
         Console.WriteLine($"A subtração dos valores é {resultado}");
         Console.ReadKey();
      }
      static void Divisao()
      {
         Console.Clear();

         Console.WriteLine("Primeiro valor");
         float v1 = float.Parse(Console.ReadLine());

         Console.WriteLine("Segundo valor");
         float v2 = float.Parse(Console.ReadLine());

         Console.WriteLine("");

         float resultado = v1 / v2;

         Console.WriteLine($"O resultado da Divisão é {resultado} ");

         Console.ReadKey();

      }
      static void Multiplicacao()
      {
         Console.Clear();

         Console.WriteLine("Primeiro valor");
         float v1 = float.Parse(Console.ReadLine());

         Console.WriteLine("Segundo valor");
         float v2 = float.Parse(Console.ReadLine());

         Console.WriteLine("");

         float resultado = v1 * v2;

         Console.WriteLine($"O resultado da multiplicação é {resultado}");

         Console.ReadKey();

      }

   }

}