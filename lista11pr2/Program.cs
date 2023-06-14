using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int[] vet1;
            int num;

            vet1 = new int[1000];
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {

                vet1[i] = random.Next(1,1000);
            }
            Console.WriteLine("insira um valor");
            num= int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                if (num == vet1[i])
                {
                    Console.WriteLine("o valor está no vetor");
                    break;
                }
            }

        }
        public static void Exercicio2()
        {
            int[] vet1;
            int num, cont=0;

            vet1 = new int[20000];
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {

                vet1[i] = random.Next(1, 20000);
            }
            Console.WriteLine("insira um valor");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                if (num == vet1[i])
                {
                    
                    cont++;
                }
            }
            for (int i = 0; i < 1000; i++)
            {

                
                Console.WriteLine("o numero aparece{0}" + cont + "vezes");
            }
        }
        public static void Exercicio3()
        {
            int[] vet1;
            int[] vet2;
            int[] vet3;

            vet1 = new int[10];
            vet2 = new int[10];
            vet3 = new int[10];
            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                vet1[i] = random.Next(1, 1000); 
            }

            for (int i = 0; i < 10; i++)
            {
                if (vet1[i]%2 == 0)
                {
                    vet1[i] = vet1[i] / 2;
                }
                else
                {
                    vet3[i] = vet1[i] *3;
                }
            }

        }
        public static void Exercicio4()
        {
            int[] vet1;
            int num, contador = 0;

            vet1 = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                vet1[i] = rand.Next(1, 5000);
            }
            Console.WriteLine("insira um valor");


            for (int i = 0; i < 1000; i++)
            {
                if (vet1[i]%2!=0 && vet1[i]%3!=0 && vet1[1]%5!=0 )
                {
                    Console.WriteLine( "o numero é primo");
                    Console.WriteLine("num primos {0}", vet1[i]);
                }
            }
        }

        static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("===========MENU=========");
                Console.WriteLine("para executar o exercício 1 - digite 1");
                Console.WriteLine("para executar o exercício 2 - digite 2");
                Console.WriteLine("para executar o exercício 3 - digite 3");
                Console.WriteLine("para executar o exercício 4 - digite 4");
                Console.WriteLine("para sair digite 0");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Thank you for using my system!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    
                    default:
                        Console.WriteLine("a opção é inválida");
                        break;
                }

            } while (option != 0);

        }
    }
}