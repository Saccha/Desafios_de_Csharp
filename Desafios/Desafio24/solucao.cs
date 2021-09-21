//Programa para validação de notas

/*
O calendário escolar está passando bem rápido, devido a isso, as professoras de uma escola estão com dificuldade para calcular as notas dos alunos. 
Visando em resolver a situação, a diretora da escola contratou você para desenvolver um programa que leia as notas da primeira e da segunda avaliação de um aluno. 
E calcule e imprima a média semestral.
O programa só aceitará notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). 
Cada nota deve ser validada separadamente.
No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando as professoras que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). 
Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.
ENTRADA
O arquivo de entrada contém vários valores reais, positivos ou negativos. 
Quando forem lidas duas notas válidas, deve ser lido um valor inteiro X. 
O programa deve parar quando o valor lido para este X for igual a 2.
SAIDA
Se uma nota inválida for lida, deve ser impressa a mensagem “nota invalida”. 
Quando duas notas válidas forem lidas, deve ser impressa a mensagem “media = ” seguido do valor do cálculo.
*/

using System;

class Desafio {
  static void Main() {
    int notasLidas = 0;
    bool opcao;
    double x = 0;
      
    while (notasLidas < 2) {
      opcao = true;
      double nota = double.Parse(Console.ReadLine());

      if (nota < 0 || nota > 10) {
        Console.WriteLine("nota invalida");
      } else if (notasLidas == 0) {
        x = nota;
        notasLidas++;
      } else if (notasLidas == 1) {
        double media = (x + nota) / 2;

        Console.Write("media = ");
        Console.WriteLine(media.ToString("N2"));
        
        while (opcao == true){
          Console.WriteLine("novo calculo (1-sim 2-nao)");
          double res = double.Parse(Console.ReadLine());

          if (res ==  1) {
            opcao = false;
            notasLidas = 0;
          } else if (res == 2) {
            opcao = false;
            notasLidas++;
          }
        }
      } 
    }
  }
}
