using System; 

class Teste 
{

    static void Main(string[] args) 
    { 

      int x=int.Parse(Console.ReadLine());
                for (int i = 0; i < x; i++){
                string str = Console.ReadLine();
                double t = str.Length;
                Console.WriteLine((t / 100.0).ToString("F2"));                
                  
        }
    }
}
