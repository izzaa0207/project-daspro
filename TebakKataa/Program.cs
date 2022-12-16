using System;
using System.Collections.Generic;

namespace TebakKataa
{
    class Program
    {
        static string kataRahasia = "bakso";
        static int kesempatan = 5;
        static List<string> tebakanPemain = new List<string>{};
        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            //EndGame();
        }
        static void Intro()
        {
            Console.WriteLine("Selamat datang, hari ini kita akan bermain tebak kata");
            Console.WriteLine($"Anda memiliki {kesempatan} untuk menebak huruf penyusun kata misteri.");
            Console.WriteLine($"Petunjuknya adalah kata tersebut merupakan salah satu makanan");
            Console.WriteLine($"kata tersebut terdiri atas {kataRahasia.Length} huruf");
            Console.WriteLine("Dapatkah kamu menebaknya ?");
            Console.ReadKey();
            Console.WriteLine();
        }
        static void PlayGame(){
            while (kesempatan>0)
            {
                Console.Write("Apa huruf tebakanmu?(a-z) : ");
                string input = Console.ReadLine();
                tebakanPemain.Add(input);
                if (jawaban(kataRahasia,tebakanPemain))
                {
                    Console.WriteLine("Tebakan anda benar");
                    Console.WriteLine($"Kata misteri hari ini : {kataRahasia} ");
                    break;
                }else{if (kataRahasia.Contains(input))
                {
                    Console.WriteLine("Huruf itu ada di dalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya");
                    Console.WriteLine(cekhuruf(kataRahasia, tebakanPemain));
                }else{
                    Console.WriteLine("Huruf tidak ada ...");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                }
                //showend();
                //break;
                }

                if (kesempatan==0)
                {
                    //Console.WriteLine("Maaf kesempatan anda telah habis.");
                    //Console.WriteLine($"jawabannya adalah : {kataRahasia}");
                    EndGame();
                    break;
                }
                static bool jawaban(string kataRahasia, List<string> list){
                    bool status = false;
                    for (int i = 0; i < kataRahasia.Length; i++)
                    {
                        string c = Convert.ToString(kataRahasia[i]);
                        if (list.Contains(c))
                        {
                            status = true;
                        }else{
                            return status = false;
                        }
                    }
                    return status;
                }
                static string cekhuruf(string kataRahasia, List<string> list){
                    string x = "";
                    for (int i = 0; i < kataRahasia.Length; i++)
                    {
                        string c = Convert.ToString(kataRahasia[i]);
                        if (list.Contains(c))
                        {
                            x = x + c;
                        }else{
                            x = x + ".";
                        }
                    }
                    return x;
                }
                static void EndGame(){
                    Console.WriteLine("Finish");
                    Console.WriteLine($"Jawabannya adalah {kataRahasia}");
                }
            }
        }
    }
}