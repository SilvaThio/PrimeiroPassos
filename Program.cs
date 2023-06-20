using System;
using System.Globalization;
    class UriMaior{
        static void Main(){
            int a, b, c, maior;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

           if(a > b)
           {
                maior = a; 
           }
           else 
           {
                maior = b; 
           }
           if (c > maior){
              Console.WriteLine(c+" eh o maior");
           }
           else{
            Console.WriteLine(maior + " eh o maior");
           }
           
        }
    }