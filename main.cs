using System;

class MainClass {
  public static int Fatorial(int num){
    if (num <= 1)
      return 1;

      return num*Fatorial(num-1);
    
  }
  
  public static void Main (string[] args) {
    int n = 0;

    Console.WriteLine("Digite o valor pra calcular fatorial");
    n = int.Parse(Console.ReadLine());

    Console.WriteLine("Fatorial de {0} é {1}", n,Fatorial(n));

    Console.ReadKey();
  }
}