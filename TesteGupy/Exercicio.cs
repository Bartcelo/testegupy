using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using ImTools;

namespace TesteGupy
{
    internal class Exercicio
    {
        public void primeiroExercicio()
        {

            int indice = 13;
            int k = 0;
            int soma = 0;

            for (k = 0; k < indice; k++)
            {
                soma = soma + k;
            }

           Console.WriteLine(soma);

        }

        public void segundoExercicio()
        {

            Console.Write("Digite um número para verificação de Fibonacci: ");
            int verificanumber = int.Parse(Console.ReadLine());

            static bool fibo(int n)
            {
                int a = 0;
                int b = 1;

                while (b < n)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }

                return b == n;
            }

            if (fibo(verificanumber))
            {
                Console.WriteLine( $"O número {verificanumber} está na sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {verificanumber} não está na sequência de Fibonacci.");
            }
        }
        public void terceiroExercicioA()
        {

            List<int> list = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int impar = i;

                if (impar % 2 != 0)
                {
                    list.Add(impar);
                    Console.WriteLine(impar);
                }
            }
        }

        public void terceiroExercicioB()
        {
            List<int> list = new List<int>();

            int i = 2;
            int total = 256;


            while (i < total)
            {
                i = i * 2;
                Console.WriteLine(i);
            }



        }

       public void terceiroExercicioC()
        {
            List<int> list = new List<int>();
            int i;
            for (i = 0; i < 65; i++)
            {
                double value = Math.Pow(i, 2);

                if (value < 65)
                {
                    Console.WriteLine(value);

                }

            }
        }

        public void terceiroExercicioD()
        {
            List<int> list = new List<int>();

            int i = 0;
            int total = 13;


            while (i < total)
            {
                int j = i;




                if (i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(i, 2));

                }
                i++;
            }
        }

        public void terceiroExercicioE()
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i <10; i++)
            {
            Console.WriteLine(b);

                int temp = a;
                a = b;
                b = temp + b;
            }
        }
        public void terceiroExercicioF() {

            Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, __200__");
        
        }

        public void quartoExercicio() {
            Console.WriteLine("Primeiro apertava no interruptor A e deixo ele ligado por um periodo,desligo o interruptor A e ligo o interruptor B e vou imediatamente para a sala onde tem as lampadas, o interruptor A estara com a lampada quente porem apagada o Interruptor B esta com a Lampada acesa e o interruptor C estara com a Lampada apagada e fria. ");
        
        }

        public void quintoExercicio()
        {

            Console.WriteLine("Digite uma palavra com mais de dois caracteres ou uma frase para ser invertida");

            String palavra = Console.ReadLine();

            if (palavra == null || palavra == "")
            {
                Console.WriteLine("A palavra deve conter pelo menos dois caracteres.");
            }

            if (palavra.Length > 1)
            {

                String invertida = "";
                for (int i = palavra.Length; i > 0; i--)
                {

                    invertida += palavra[i - 1];

                }
                Console.WriteLine(invertida);
            }
        }
    }
}



    



