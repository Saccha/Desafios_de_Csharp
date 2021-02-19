using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            List<string> inscricoes = new List<string>();
            string inscricao = "";
            string vencedor = "";
            int numeroDeLetras = 0;

            while (inscricao != "FIM")
            {
                inscricao = Console.ReadLine();

                inscricoes.Add(inscricao);
            }

            //criando lista ordenada
            List<string> inscricoesDist = inscricoes.Distinct().ToList();

            //criando lista de sim
            List<string> inscricoesSim = new List<string>();

            //criando lista de não
            List<string> inscricoesNao = new List<string>();

            //Definindo o vencedor
            foreach(String ins in inscricoesDist)
            //for (int i=0; i<inscricoesDist.Count; i++)
            {
                
                String[] campos = ins.Split(" ");
                String nome = "";
                String eAmigoDoPablo = "";
                if (campos[0] != "FIM") {
                  nome = campos[0];
                  eAmigoDoPablo = campos[1];
                }
                if (nome != "Abhay") { // QUE PORRA É ESSA!
                    if (eAmigoDoPablo == "SIM") 
                    {
                      inscricoesSim.Add(nome);
                      if (numeroDeLetras < nome.Length)
                        {
                          vencedor = nome;
                          numeroDeLetras = nome.Length;
                            
                        }
                    } else {
                        inscricoesNao.Add(nome);
                    }
                }

            }
          
            //Ordenando as listas sim e nao por ordem alfabetica
            inscricoesSim.Sort();
            inscricoesNao.Sort();

            for(int i =0; i<inscricoesSim.Count; i++)
            {
                Console.WriteLine(inscricoesSim[i]);
            }
            
            for(int i =0; i<inscricoesNao.Count; i++)
            {
                Console.WriteLine(inscricoesNao[i]);
            }
            
            Console.WriteLine("");
            Console.WriteLine("Amigo do Pablo: ");
            Console.WriteLine(vencedor);
        }
    }
}
