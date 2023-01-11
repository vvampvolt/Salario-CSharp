using System;
class HelloWorld {
  static void Main(string[] args)
  {
      double salario, acrescimo, salarioFuturo;
      
      Console.WriteLine("Entre com o salario");
      salario = double.Parse(Console.ReadLine());
      
      Console.WriteLine("Entre com o acrescimo:");
      acrescimo = double.Parse(Console.ReadLine());
    
      acrescimo = acrescimo / 100 * salario;
      salarioFuturo = salario + acrescimo;
      
     
      Console.WriteLine("Valores entrados: {0} e {1} e {2} ", salario, salarioFuturo, acrescimo);

      
     Console.ReadKey();
 
  }
}
