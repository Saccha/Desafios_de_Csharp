using System; 

class DIO {

    static void Main(string[] args) { 

     double s = 0;
     double a = 0;
     for (int i = 1; i <= 100; i++){
        a = (double)i;
        s += 1 / a;
      }
      Console.WriteLine(Math.Round(s,2));
    }
}
