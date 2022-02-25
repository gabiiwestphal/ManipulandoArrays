using System;

namespace ManipulandoArrays.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequenciaNumeros = new int[]
           {
                -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6
           };

            MostrarNaTela("A sequência é: " + string.Join("; ", sequenciaNumeros) + "\n");

            int maiorNumero = EncontrarMaiorNumero(sequenciaNumeros);

            int menorNumero = EncontrarMenorNumero(sequenciaNumeros);

            decimal valorMedio = CalcularMedia(sequenciaNumeros);

            int[] maioresNumeros = EncontrarMaioresNumeros(sequenciaNumeros);

            int[] numerosNegativos = EncontrarNumerosNegativos(sequenciaNumeros);

            MostrarNaTela("O maior número da sequência é: " + maiorNumero);

            MostrarNaTela("O menor número da sequência é: " + menorNumero);

            MostrarNaTela("O valor médio da sequência é: " + valorMedio);

            MostrarNaTela("Os três maiores números são: " + string.Join("; ", maioresNumeros));

            MostrarNaTela("Os números negativos são: " + string.Join("; ", numerosNegativos));

            Console.WriteLine("Digite o número que quer remover da lista: ");
            int numeroParaRemover = int.Parse(Console.ReadLine());
            RemoverNumeroNaSequencia(ref sequenciaNumeros, numeroParaRemover);

            Console.ReadLine();
        }

        static void RemoverNumeroNaSequencia(ref int[] numeros, int numeroParaRemover) 
        {
            int qtdParaRemover = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroParaRemover)
                    qtdParaRemover++;
            }

            int[] novaSequencia = new int[numeros.Length - qtdParaRemover];
            int j = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != numeroParaRemover)
                {
                    novaSequencia[j] = numeros[i];
                    j++;
                }
            }

            numeros = novaSequencia;
        }

        static int[] EncontrarNumerosNegativos(int[] numeros)
        {
            int qtdNumerosNegativos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                    qtdNumerosNegativos++;
            }

            int[] numerosNegativos = new int[qtdNumerosNegativos];
            int j = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    numerosNegativos[j] = numeros[i];
                    j++;
                }
            }

            return numerosNegativos;
        }

        static int[] EncontrarMaioresNumeros(int[] numeros)
        {         
            Array.Sort(numeros);

            Array.Reverse(numeros);

            int[] tresMaiores = new int[3];

            for (int i = 0; i < tresMaiores.Length; i++)
            {
                tresMaiores[i] = numeros[i];
            }

            return tresMaiores;
        }

        static decimal CalcularMedia(int[] numeros)
        {
            decimal valorTotal = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                valorTotal = valorTotal + numeros[i]; 
            }

            decimal valorMedio = valorTotal / numeros.Length;

            return valorMedio;
        }

        static int EncontrarMenorNumero(int[] numeros)
        {
            int menorNumero = int.MaxValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menorNumero)
                    menorNumero = numeros[i];
            }

            return menorNumero;
        }

        static int EncontrarMaiorNumero(int[] numeros)
        {
            int maiorNumero = int.MinValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                    maiorNumero = numeros[i];
            }

            return maiorNumero;
        }

        static void MostrarNaTela(string mensagem)
        {

            Console.WriteLine(mensagem);

        }
    }
    }

