using System; 

class DIO {

    static void Main(string[] args) { 
      int entrada = int.Parse(Console.ReadLine());
      for (int i = 1; i <= entrada; i++){
        if (i % 2 == 0){
          Console.WriteLine($"{i}^2 = {Math.Pow((double)i, 2.0)}");
        }
      }
    }
}
