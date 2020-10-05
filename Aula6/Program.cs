using System;
using System.IO.Pipes;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorInvestido = 100.00;
            //int Mes = 1;
            string MesNome = "";
            double Rendimento = 1.0036;
            int MesInicio = 9;
            //int MesFinal;
            int AnoInicio = 2020;
            int AnoFinal = 2022;


            Console.WriteLine("VAMOS CALCULAR O RENDIMENTO DO SEU DINHEIRO" + "\n----------------------------------------");
            Console.Write("Digite o Valor investido:");
            ValorInvestido = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite até que ano pretende deixar o dinheiro parado:");
            AnoFinal = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite até que mês de " + AnoFinal + " pretende deixar o dinheiro parado:");
            //MesFinal = Console.Read();

            //int TotalAnos = AnoFinal - AnoInicio;
            //int TotalMeses = (MesFinal - MesInicio) - (TotalAnos * 12);
            while (AnoInicio <= AnoFinal)
            {
                Console.WriteLine("");
                while (MesInicio <= 12)
                {
                    switch (MesInicio)
                    {
                        case 1:
                            MesNome = "Janeiro";
                            break;
                        case 2:
                            MesNome = "Fevereiro";
                            break;
                        case 3:
                            MesNome = "Março";
                            break;
                        case 4:
                            MesNome = "Abril";
                            break;
                        case 5:
                            MesNome = "Maio";
                            break;
                        case 6:
                            MesNome = "Junho";
                            break;
                        case 7:
                            MesNome = "Julho";
                            break;
                        case 8:
                            MesNome = "Agosto";
                            break;
                        case 9:
                            MesNome = "Setembro";
                            break;
                        case 10:
                            MesNome = "Outubro";
                            break;
                        case 11:
                            MesNome = "Novembro";
                            break;
                        case 12:
                            MesNome = "Dezembro";
                            break;
                    }
                    ValorInvestido = Math.Round(ValorInvestido * Rendimento, 2);
                    Console.WriteLine("Em " + MesNome + " de " + AnoInicio + " o valor será de R$ " + ValorInvestido);
                    MesInicio++;
                }
                MesInicio = 1;
                AnoInicio++;
            }
            Console.WriteLine("FIM DA EXECUÇÃO!");
        }
    }
}
