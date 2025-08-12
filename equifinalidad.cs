using System;

class Program
{       

    //metodo recursivo
    static long Factorial_Recursivo(int n)
    {
       if (n <= 1)
       {
           return 1;
       }
       else
       {
           return n * Factorial_Recursivo(n - 1);
       }
    }

    // metodo iterativo
    static void Main()
    {
        Console.WriteLine("Ingrese el número para calcular su factorial:");
        int n = int.Parse(Console.ReadLine());

        
        long factorial_iterativo = 1 ;
        for (int iterativo = 1; iterativo <= n; iterativo++)
        {
            factorial_iterativo *= iterativo;
        }

        //mostrar los resultados si son iguales
        Console.WriteLine($"\n usando metodo iterativo: {factorial_iterativo}");
        Console.WriteLine($"\n usando metodo recursivo: {Factorial_Recursivo(n)}");

        //verificamos

        if (factorial_iterativo == Factorial_Recursivo(n))
        {
            Console.WriteLine("\nLos resultados son iguales");
        }
        else
        {
            Console.WriteLine("\nLos resultados son diferentes");
        }
    }
}
