using Baseline;
using ImTools;
using System.Reflection.Metadata;

namespace TesteGupy
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Exercicio exercicio = new Exercicio();

            int saida = 0;
            while (saida == 0) {


                Console.WriteLine("Digite qual exercicio você deseja analisar sabendo que:" +
                                  " \n 1 representa o primeiro" +
                                  "\n 2 represnta o segundo " +
                                  "\n 3a representa a parte a do terceiro" +
                                  " \n 3a representa a parte b do terceiro " +
                                  "\n 3c representa a parte c do terceiro  " +
                                  "\n 3c representa a parte c do terceiro  " +
                                  "\n 3e representa a parte e do terceiro " +
                                  "\n 3f representa a parte f do terceiro " +
                                  "\n 4 representa o quarto" +
                                  "\n 5 representa o quinto" +
                                  " \n 6 saida  ");


                String resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    exercicio.primeiroExercicio();
                }
                else if (resposta == "2")
                {
                    exercicio.segundoExercicio();
                }
                else if (resposta == "3a")
                {
                    exercicio.terceiroExercicioA();
                }
                else if (resposta == "3b")
                {
                    exercicio.terceiroExercicioB();
                }
                else if (resposta == "3c")
                {
                    exercicio.terceiroExercicioC();
                }
                else if (resposta == "3d")
                {
                    exercicio.terceiroExercicioD();
                }
                else if (resposta == "3e")
                {
                    exercicio.terceiroExercicioE();
                }
                else if (resposta == "3f")
                {
                    exercicio.terceiroExercicioF();
                }
                else if (resposta == "4")
                {
                    exercicio.quartoExercicio();
                }
                else if (resposta == "5")
                {
                    exercicio.quintoExercicio();
                }
                else if (resposta == "6")
                {
                    saida = 8;
                    Console.WriteLine("TCHAUUUUUUUUUU");
                }
                else
                {
                    Console.WriteLine("O valor digitado esta incorreto");
                }
            };
        }
    }
}
