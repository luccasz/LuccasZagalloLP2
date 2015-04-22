using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatorial(); 
            Fatorial2(); 
            Funcionario(); 
            PingPong(); 
            Viagem(); 
            ConcursoBeleza(); 
            Natacao();
            Soma1aN(); 
        }
        static void Fatorial()
        {
            int num = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 0; i < num; i++)
            {
                fatorial = fatorial * (num - i); 
            }
            Console.WriteLine(num + "!" + " = " + fatorial);
        }
        static void Fatorial2()
        {
            int num = int.Parse(Console.ReadLine());
            int denominador = 1;

            for (int fatorial = 1; fatorial <= num; fatorial++)
            {
                if (fatorial % 2 == 0)
                {
                    Console.Write("-{0}/{1} ", fatorial + "!", denominador);
                }
                else
                {
                    Console.Write("+{0}/{1} ", fatorial + "!", denominador);
                }
                denominador = (denominador * 2) + 1;
            }
        }
        static void Funcionario() 
        {
            int numero = int.Parse(Console.ReadLine());
            double percent_aumento = 0, novo_salario = 0;

            while (numero > 0)
            {
                double salario_atual = double.Parse(Console.ReadLine());
                string nome = Console.ReadLine();

                if (salario_atual >= 0 && salario_atual < 3000)
                {
                    percent_aumento = salario_atual * 0.25;
                    novo_salario = salario_atual + percent_aumento;
                    Console.WriteLine("O funcionário {0} ganhava R$ {1}, teve um aumento de R$ {2}, e agora seu salário é: R${3}", nome, salario_atual, percent_aumento, novo_salario);
                }
                if (salario_atual >= 3000 && salario_atual < 4000)
                {
                    percent_aumento = salario_atual * 0.20;
                    novo_salario = salario_atual + percent_aumento;
                    Console.WriteLine("O funcionário {0} ganhava R$ {1}, teve um aumento de R$ {2}, e agora seu salário é: R${3}", nome, salario_atual, percent_aumento, novo_salario);
                }
                if (salario_atual >= 4000 && salario_atual < 5000)
                {
                    percent_aumento = salario_atual * 0.15;
                    novo_salario = salario_atual + percent_aumento;
                    Console.WriteLine("O funcionário {0} ganhava R$ {1}, teve um aumento de R$ {2}, e agora seu salário é: R${3}", nome, salario_atual, percent_aumento, novo_salario);
                }
                if (salario_atual >= 5000)
                {
                    percent_aumento = salario_atual * 0.10;
                    novo_salario = salario_atual + percent_aumento;
                    Console.WriteLine("O funcionário {0} ganhava R$ {1}, teve um aumento de R$ {2}, e agora seu salário é: R${3}", nome, salario_atual, percent_aumento, novo_salario);
                }
                numero--;
            }
        }
        static void PingPong()
        {
           int ponto1 = 0, ponto2 = 0, pontuacao = 0;
           bool partida = true;
            
            Console.WriteLine("Digite 1 p/ dar um ponto ao jogador1 ou 2 p/ dar um ponto ao jogador2");
            while (partida == true)
            {
                pontuacao = int.Parse(Console.ReadLine());

                if (pontuacao == 1)
                    ponto1++;
  
                if (pontuacao == 2)
                    ponto2++;

                if (ponto1 >= 21 || ponto2 >= 21)
                {
                    if (ponto1 - ponto2 >= 2)
                    {
                        Console.WriteLine("Jogador 1 é o Vencedor!");
                        break;
                    }
                    if (ponto2 - ponto1 >= 2)
                    {
                        Console.WriteLine("Jogador 2 é o Vencedor!");
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Jogador1: {0} \nJogador2: {1}", ponto1, ponto2);
            }
        }
        static void Viagem()
        {
            double distancia = 0, litros = 0, desempenho = 0;
            bool medidor = true;

            while (medidor == true)
            {
                distancia += int.Parse(Console.ReadLine());
                litros += int.Parse(Console.ReadLine());

                if (litros > 50)
                {
                    Console.WriteLine("O carro parou antes de chegar por falta de combustível");
                    break;
                }
                if (distancia >= 600)
                {
                    Console.WriteLine("O carro chegou ao seu destino.");
                    break;
                }
            }
            desempenho = distancia / litros;
            Console.WriteLine("Desempenho médio carro: " + distancia + "Km" + "/" + litros + "L");
        }
        static void ConcursoBeleza()
        {
            Console.WriteLine("Digite o numero de mulheres no concurso");
            int num = int.Parse(Console.ReadLine());
            string mulheres = " ";
            double[] alturas = new double[num];
            double max = 0, max2 = 0, mAltura = 0;

            Console.WriteLine("Digite FIM na caixa de nomes p/ parar a leitura dos nomes");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Mulher:");
                mulheres = Console.ReadLine();

                if (mulheres == "FIM")
                    break;

                else
                {
                    Console.WriteLine("Altura:");
                    alturas[i] = double.Parse(Console.ReadLine());

                    if (alturas[i] > max)
                    {
                        max = alturas[i];
                        mAltura++;

                    }
                    if (alturas[i] > max2)
                    {
                        max2 = alturas[i];
                        mAltura++;
                    }
                }
            }
            Console.WriteLine("As duas maiores alturas são: {0} e {1}", (max2 - 1), (max));
            Console.WriteLine("As mulheres são: {0}", mAltura);
        }
        static void Natacao()
        {
            int prova = 0, qtdNadador = 0, lugar = 0, pontos = 0, pClubeA = 0, pClubeB = 0;
            string nadador, clube;
            double tempo = 0;

            while (prova != 9999)
            {
                prova = int.Parse(Console.ReadLine());
                qtdNadador = int.Parse(Console.ReadLine());

                while (qtdNadador > 0)
                {
                    for (int i = 0; i < qtdNadador; i++)
                    {
                        nadador = Console.ReadLine();
                        lugar = int.Parse(Console.ReadLine());
                        tempo = double.Parse(Console.ReadLine());
                        clube = Console.ReadLine();

                        if (lugar == 1)
                            pontos = 9;

                        if (lugar == 2)
                            pontos = 6;

                        if (lugar == 3)
                            pontos = 4;

                        if (lugar == 4)
                            pontos = 3;

                        if (clube == "A")
                        {
                            pClubeA += pontos;
                        }

                        if (clube == "B")
                        {
                            pClubeB += pontos;
                        }
                    }
                    Console.WriteLine("Número da Prova: " + prova + "\nClube A: " + pClubeA + " pontos");
                    Console.WriteLine("Número da Prova: " + prova + "\nClube B: " + pClubeB + " pontos");
                }
                if (pClubeA > pClubeB)
                    Console.WriteLine("Clube A é vencedor!");
                if (pClubeB > pClubeA)
                    Console.WriteLine("Clube B é vencedor!");
                if (pClubeA == pClubeB)
                    Console.WriteLine("Empate");
            } 
        }
        static void Soma1aN()
        {
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i <= n; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine(soma);
        }
    }
}
