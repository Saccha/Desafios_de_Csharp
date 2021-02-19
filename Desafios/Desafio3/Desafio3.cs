using System;
using static System.Math;


 class Desafio 
 {
     static void Main() 
     {
        string[] km = Console.ReadLine().Split(" ");
        int tempo = Int32.Parse(km[0]);
        int velocidade = Int32.Parse(km[1]); 

        double kilo = 12;
        double total = (tempo * velocidade); 

        Console.WriteLine(Round(total/kilo, 3));
      }
 }
