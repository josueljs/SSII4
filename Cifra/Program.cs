using System;

namespace Cifra
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuexit = false;
            string texto, choice;
            int num;
            
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("");

            Console.Write("Digite o texto a ser criptografado: ");
            texto = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Você vai converter o seguinte texto:");
            Console.WriteLine(texto); 
            Console.WriteLine("");

            Console.WriteLine("Criptografando...");
            Console.WriteLine("Eis o texto criptografado:");
            string textocriptografado = ROT47(texto);
            Console.WriteLine(textocriptografado);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("QUAL FOI A CIFRA CRIPTOGRÁFICA UTILIZADA PARA CRIPTOGRAFAR OS DADOS?");
            Console.WriteLine("1. Cifra de Cesar");
            Console.WriteLine("2. ROT13");
            Console.WriteLine("3. ROT47");
            Console.WriteLine("4. Cifra de Vigenère");
            Console.WriteLine("5. Cifra de Gronsfeld");
            Console.WriteLine("");

            while (!menuexit)
            {
                do
                {
                    Console.Write("Digite a resposta: ");
                    choice = Console.ReadLine();
                    Console.WriteLine("");
                } while (!Int32.TryParse(choice, out num) || num < 1 || num > 5);
                //Console.WriteLine("");

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Resposta errada, tente novamente...");
                        break;

                    case 2:
                        Console.WriteLine("Resposta errada, tente novamente...");
                        break;

                    case 3:
                        Console.WriteLine("Resposta exata! Parabéns!");
                        menuexit = true;
                        break;

                    case 4:
                        Console.WriteLine("Resposta errada, tente novamente...");
                        break;

                    case 5:
                        Console.WriteLine("Resposta errada, tente novamente...");
                        break;
                }
            }

            Console.ReadKey();


        }

        static string ROT47(string s)
        {
            char[] ca = new char[s.Length];
            
            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c >= 33 && c <= 126)
                {
                    int j = c + 47;
                    if (j > 126) j -= 94;
                    ca[i] = (char)j;
                }

                else
                {
                    ca[i] = c;
                }

            }

            return new string(ca);
        }
                

    }
}
