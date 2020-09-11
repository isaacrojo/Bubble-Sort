using System;

namespace Sort_Algorithms
{
    class Bubble
    {
        static void Main(string[] args)
        {
                 //metodo de ordenamiento burbuja
       
       //primero declarar cuantos datos se van a ordenar y guardarlos en un array
       int n;
        System.Console.WriteLine("Cantidad de numeros a ordenar: ");
        n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            System.Console.Write("n {}", (i+1));
            array[i] = int.Parse(Console.ReadLine());
        }

        //algoritmo:

        for (int i = 0; i < n; i++)
        {
            for (int j = i+1; j < n; j++)       
            {
               int auxiliar;
               //comparar pares si i > j , then SWAP
               if(array[i] > array[j]) 
               {
                   //Swap
                   auxiliar = array[i];
                   array[i] = array[j];
                   array[j] = auxiliar;
               } 
            }
        }
        System.Console.WriteLine("Numeros ordenados:");
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine(array[i]);
        }
        Console.ReadKey();
        }
    }
}
