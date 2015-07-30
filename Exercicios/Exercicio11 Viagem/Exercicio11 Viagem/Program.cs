using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11_Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> listaCarro = new List<Carro>();
            Carro car;

            string status = "";
            int idCarro = 0;
            int numCarros = 0;

            bool continua = true;
            bool carroExiste = true; 

            string modelo = "";
            string marca = "";
            string placa = "";
            int capacidade = 0;
            
            int totalPessoas = 0;

            numCarros = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCarros; i++)
            {
                idCarro = i + 1;
                modelo = Console.ReadLine();
                marca = Console.ReadLine();
                placa = Console.ReadLine();
                capacidade = int.Parse(Console.ReadLine());

                listaCarro.Add(new Carro(idCarro, modelo, marca, placa, capacidade));
            }
            Console.WriteLine("");
            Console.WriteLine("Carros cadastrados: ");

            listaCarro.ForEach(delegate(Carro p_carro)
            {
                Console.WriteLine(p_carro.ID + " - " + p_carro.modelo +  "," + p_carro.marca + "," + p_carro.placa + "," + p_carro.capacidade + "," + p_carro.ocupacao);
            });
            Console.WriteLine("");

            continua = true;

            while (continua == true)
            {
                idCarro = int.Parse(Console.ReadLine());

                if (idCarro < 0)
                {
                    continua = false;
                }
                else
                {
                    carroExiste = listaCarro.Exists(x => x.ID == idCarro);

                    if (carroExiste == true)
                    {
                        car = listaCarro.Find(delegate(Carro p1) { return p1.ID == idCarro; });

                        status = car.AlocaPassageiro();

                        Console.WriteLine(status);
                    }
                    else
                    {
                        Console.WriteLine("Carro Inválido!!!");
                    }
                }
            }
            Console.WriteLine(status);

            Console.WriteLine("Relatório Final:");
            totalPessoas = 0;
            listaCarro.ForEach(delegate(Carro p_carro)
            {
                Console.WriteLine("");
                Console.WriteLine("Carro " + p_carro.ID + ": " + p_carro.modelo + " - " + p_carro.marca + "(" + p_carro.placa + ")");
                Console.WriteLine("Passageiros: " + p_carro.capacidade);
                Console.WriteLine("Vagas restantes: " + p_carro.ocupacao);

                totalPessoas = totalPessoas + p_carro.capacidade - p_carro.ocupacao;
            });
            Console.WriteLine("");
            Console.WriteLine("Total de Pessoas na Viagem : " + totalPessoas);

            Console.ReadKey();
        }
    }
}

