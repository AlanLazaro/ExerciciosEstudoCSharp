using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=- Lista de Exercicios -=-=-=-=-");
            Console.WriteLine("Exercicio 1 -> Calculo Dos Litros de Gasolina");
            Console.WriteLine("Exercicio 2 -> Numero de Figurinhas");
            Console.WriteLine("Exercicio 3 -> Amigo do Pablo");
            Console.Write("Escolha um Exercicio: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Write("Entre Com A quantidade de Horas rodadas e a velocidade Média:  ");
                    var input = Console.ReadLine().Split(" ");

                    var hours = double.Parse(input[0]);
                    var kmh = double.Parse(input[1]);
                    var litros = (hours * kmh) / 12;

                    Console.WriteLine($"Foram Usados {litros.ToString("N3")} Litros de Gasolina");

                    break;


                case 2:

                    Console.Write("Entre Com o Numero de Figurinhas no album: ");
                    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());

                    Console.Write("Entre Com o Numero de Figurinhas Compradas: ");
                    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());                   

                    var hash = new HashSet<int>(); //Lista que não aceita valores iguais

                    for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
                    {
                        Console.Write($"Entre com sua {i}º figurinha ");
                        hash.Add(int.Parse(Console.ReadLine()));

                    }

                    Console.WriteLine("Faltam " + (numeroDeFigurinhas - hash.Count) + " Figurinhas");

                    break;

                case 3:
                    var listaSim = new HashSet<string>();
                    var listaNao = new HashSet<string>();
                    var maior = 0;
                    string amigo = "";
                    while (true)
                    {
                        var input2 = Console.ReadLine();

                        if(input2.ToUpper() == "FIM")
                            break;

                        var respostas = input2.Split(" ");

                        if (respostas[1].ToUpper() == "SIM")
                        {
                            if (respostas[0].ToUpper() != "ABHAY")
                                listaSim.Add(respostas[0]);
                        }

                        else if (respostas[1].ToUpper() == "NAO")
                            listaNao.Add(respostas[0]);
                    }

                    foreach (var item in listaSim)
                    {
                        if (item.Length > maior)
                        {
                            amigo = item;
                            maior = item.Length;
                        }
                    }
                    var sim = listaSim.ToList();
                    var nao = listaNao.ToList();

                    sim.Sort();
                    nao.Sort();

                    sim.ForEach(x => Console.WriteLine(x));
                    nao.ForEach(x => Console.WriteLine(x));

                    Console.WriteLine();
                    Console.WriteLine("Amigo do Pablo:");
                    Console.WriteLine(amigo);


                            
                    break;


                default:
                    break;
            }
        }
    }
}