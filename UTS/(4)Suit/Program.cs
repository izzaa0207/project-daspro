using System;

namespace Suit
{
    class Program
    {
        static void Main(string[] args)
        {
            int skorMenang = 0;
            int skorKalah = 0;
            int skorSeri = 0;
            char userInput = ' ';
            Random rnd = new Random();

            while (userInput != 'e')
            {
                Console.Write("Pilih salah satu [b]atu, [g]unting, [k]ertas, atau [e]xit (b/g/k/e) : ");
                userInput = Convert.ToChar(Console.ReadLine());

                if (userInput == 'e')
                {
                    Console.WriteLine("Bye bye !!");
                    break;
                }

                int comp = rnd.Next(1, 4);
                if (userInput == 'b')
                {
                    if (comp == 1)
                    {
                        Console.WriteLine("Komputer memilih : batu");
                        Console.WriteLine("Babak ini seri !");
                        skorSeri++;
                    }
                    else if (comp == 2)
                    {
                        Console.WriteLine("Komputer memilih : gunting");
                        Console.WriteLine("Hore, kamu menang !");
                        skorMenang++;
                    }
                    else if (comp == 3)
                    {
                        Console.WriteLine("Komputer memilih : kertas");
                        Console.WriteLine("Sayang sekali, kamu kalah !");
                        skorKalah++;
                    }
                }
                else if (userInput == 'g')
                {
                    if (comp == 1)
                    {
                        Console.WriteLine("Komputer memilih : batu");
                        Console.WriteLine("Sayang sekali, kamu kalah !");
                        skorKalah++;
                    }
                    else if (comp == 2)
                    {
                        Console.WriteLine("Komputer memilih : gunting");
                        Console.WriteLine("Babak ini seri !");
                        skorSeri++;
                    }
                    else if (comp == 3)
                    {
                        Console.WriteLine("Komputer memilih : kertas");
                        Console.WriteLine("Hore, kamu menang !");
                        skorMenang++;
                    }
                }
                else if (userInput == 'k')
                {
                    if (comp == 1)
                    {
                        Console.WriteLine("Komputer memilih : batu");
                        Console.WriteLine("Hore, kamu menang !");
                        skorMenang++;
                    }
                    else if (comp == 2)
                    {
                        Console.WriteLine("Komputer memilih : gunting");
                        Console.WriteLine("Sayang sekali, kamu kalah !");
                        skorKalah++;
                    }
                    else if (comp == 3)
                    {
                        Console.WriteLine("Komputer memilih : kertas");
                        Console.WriteLine("Babak ini seri !");
                        skorSeri++;
                    }
                }
                Console.WriteLine("Skor kamu : {0} - {1} - {2}", skorMenang, skorSeri, skorKalah);
                Console.WriteLine("Tekan enter untuk melanjutkan");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}