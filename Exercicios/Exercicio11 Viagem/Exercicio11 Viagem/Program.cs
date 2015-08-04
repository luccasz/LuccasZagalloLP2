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

            listaCarro.ForEach(delegate(Carro carro)
            {
                Console.WriteLine(carro.Id + " - " + carro.Modelo +  "," + carro.Marca + "," + carro.Placa + "," + carro.Capacidade + "," + carro.Ocupacao);
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
                    carroExiste = listaCarro.Exists(x => x.Id == idCarro);

                    if (carroExiste == true)
                    {
                        car = listaCarro.Find(delegate(Carro p1) { return p1.Id == idCarro; });

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

            Console.WriteLine("");
            Console.WriteLine("Relatório Final:");
            totalPessoas = 0;
            listaCarro.ForEach(delegate(Carro carro)
            {
                Console.WriteLine("");
                Console.WriteLine("Carro " + carro.Id + ": " + carro.Modelo + " - " + carro.Marca + "(" + carro.Placa + ")");
                Console.WriteLine("Passageiros: " + carro.Capacidade);
                Console.WriteLine("Vagas restantes: " + carro.Ocupacao);

                totalPessoas = totalPessoas + carro.Capacidade - carro.Ocupacao;
            });
            Console.WriteLine("");
            Console.WriteLine("Total de Pessoas na Viagem : " + totalPessoas);

            Console.ReadKey();
        }
    }
}

