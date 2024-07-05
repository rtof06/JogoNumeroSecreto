using System;
using System.Collections.Generic;

class Sistema
{
    static void Main()
    {

        Random n = new Random();
        int num = n.Next(1, 101);

        Inicio(num);

        void Inicio(int num)    
        {
            
            Console.WriteLine("************ BEM VINDO AO JOGO DO NÚMERO SECRETO! ************");
            Console.WriteLine("O número aleatório foi gerado com sucesso. Deseja iniciar? (s/n)");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                Play(num);
            }
            else if (resposta == "n")
            {
                Console.WriteLine("Beleza! Até a próxima...");
            } else
            {
                Console.Clear();
                Console.WriteLine("\nResponda 'sim' ou 'nao' amigao!!\n\n");
                Inicio(num);
            }
        }

        static void Play(int num)
        {
            Console.Write("\nFaça seu chute (de 1 a 100): ");
            string chute = Console.ReadLine();
            if (int.TryParse(chute, out int c))
            {
                if (c > num)
                {
                    if (c > 100)
                    {
                        Console.WriteLine("Seu chute foi maior do que 100!\n");
                        Play(num);
                    } 
                    else
                    {
                        Console.WriteLine("O número é menor do que o chute.\n");
                        Play(num);
                    }                        
                }
                else if (c < num)
                {
                    if (c < 1)
                    {
                        Console.WriteLine("Seu chute foi menor do que 1!\n");
                        Play(num);
                    }
                    else
                    {
                        Console.WriteLine("O número é maior do que o chute.\n");
                        Play(num);
                    }                    
                }
                else
                {
                    Console.WriteLine("Parabéns! O número secreto é " + num);
                    Console.WriteLine("Deseja jogar novamente? (s/n)");
                    string again = Console.ReadLine();
                    
                    if (again == "s")
                    {
                        Console.WriteLine("\nBeleza! O número aleatório está sendo gerado...");
                        Random n = new Random();
                        int newNum = n.Next(1, 101);
                        Play(newNum);
                    } else
                    {
                        Console.WriteLine("\nOk! Até a próxima.");
                    }

                }
            }
            else
            {
                Console.WriteLine("\nInsira um número válido.");
                Play(num);
            }
        }
    }
        
}


