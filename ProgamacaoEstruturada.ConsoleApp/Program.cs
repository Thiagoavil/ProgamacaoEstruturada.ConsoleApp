﻿using System;

namespace ProgamacaoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosrecebidos = new int[10];


            Console.WriteLine("Digite 10 valores Inteiros: ");



            AdquirirValores(ref numerosrecebidos);

            /*Console.WriteLine("Esses são os numeros digitados: ");
            MostrarValores(ref numerosrecebidos);
            
            int MenorNumero;
            MenorNumeroMet( numerosrecebidos, out MenorNumero);
            Console.WriteLine("O menor numero é: " + MenorNumero);

            int maiornumero = 0;
            MaiorNumeroMet(ref numerosrecebidos, ref maiornumero);
            Console.WriteLine("O maior numero é: " + maiornumero);
            
                          
            Console.WriteLine("A média é : " + MediaDeValores(ref numerosrecebidos));


            int[] x = TresValoresMaiores(ref numerosrecebidos);
            Console.Write("Esses são seus 3 maiores numeros: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }

            
            Console.WriteLine("Digite o numero que quer retirar: ");
            int numeroselecionado = Convert.ToInt32(Console.ReadLine());
            int [] novoarray = RemoverItemDaSequencia(ref numerosrecebidos, ref numeroselecionado);
            Array.Sort(novoarray);
            for(int i = 0; i < novoarray.Length; i++)
            {
                Console.WriteLine(novoarray[i]);
            }*/



            static int[] AdquirirValores(ref int[] numerosrecebidos)
            {

                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    numerosrecebidos[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(numerosrecebidos);

                return numerosrecebidos;
            }
            static void MenorNumeroMet(int[] numerosrecebidos, out int MenorNumero)
            {

                MenorNumero = numerosrecebidos[0];

            }
            static void MaiorNumeroMet(ref int[] numerosrecebidos, ref int maiornumero)
            {
                maiornumero = numerosrecebidos[numerosrecebidos.Length - 1];


            }
            static decimal MediaDeValores(ref int[] numerosrecebidos)
            {
                decimal media = 0;

                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    media = numerosrecebidos[i] + media;

                }
                media = media / numerosrecebidos.Length;


                return media;
            }
            static int[] TresValoresMaiores(ref int[] numerosrecebidos)
            {
                int[] valores = new int[3];
                valores[0] = numerosrecebidos[numerosrecebidos.Length - 1];
                valores[1] = numerosrecebidos[numerosrecebidos.Length - 2];
                valores[2] = numerosrecebidos[numerosrecebidos.Length - 3];
                Array.Sort(valores);
                return valores;

            }
            static void ValoresNegativos(ref int[] numerosrecebidos)
            {

            }
            static void MostrarValores(ref int[] numerosrecebidos)
            {
                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    Console.WriteLine(numerosrecebidos[i]);
                }
            }
            static int [] RemoverItemDaSequencia(ref int [] numerosrecebidos, ref int numeroselecionado)
            {
                   
                int reduzir = 0;
                
                for (int i = 0;i < numerosrecebidos.Length;i++)
                {
                    if(numerosrecebidos[i] != numeroselecionado)
                    {
                    
                    }
                    else
                    {
                        reduzir++;
                    }
                }
                int[] novoarray = new int [numerosrecebidos.Length-reduzir];
                int j = 0;
                for (int i = 0; i < numerosrecebidos.Length; i++)
                {
                    if (numerosrecebidos[i] != numeroselecionado)
                    {
                        novoarray[j]=numerosrecebidos[i];
                        j++;
                    }
                    else
                    {

                    }
                }
                return novoarray;
            }

        }
    }
}

