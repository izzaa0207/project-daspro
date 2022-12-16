using System;


 namespace AduDadu
 {
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int komputerRandomNum;

            int playerPoints = 0;
            int komputerPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Game Adu Dadu\n");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Selamat datang di Game Adu Dadu !");
                Console.WriteLine("Pada game ini, kamu akan bermain melawan komputer");
                Console.WriteLine("Kamu akan bermain dalam 10 ronde");
                Console.WriteLine("Setiap putaran dadu menghasilkan angka tertentu");
                Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang");
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("Tekan tombol untuk memulai game");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("Nilai dadu kamu " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                komputerRandomNum = random.Next(1, 7);
                Console.WriteLine("Nilai dadu komputer " + komputerRandomNum);

                if(playerRandomNum > komputerRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Kamu memenangkan babak ini!");
                }
                else if(playerRandomNum < komputerRandomNum)
                {
                    komputerPoints++;
                    Console.WriteLine("Komputer memenangkan babak ini!");
                }
                else
                {
                    Console.WriteLine("Babak ini seri!");
                }
                Console.WriteLine("Skor saat ini - Kamu : " + playerPoints + ". Komputer : " + komputerPoints + ".");
                Console.WriteLine();
            }

            if(playerPoints > komputerPoints)
            {
                Console.WriteLine("Selamat, kamu menang !");
            }
            else if(playerPoints < komputerPoints)
            {
                Console.WriteLine("Sayang sekali, kamu kalah !");
            }
            else
            {
                Console.WriteLine("Permainan seri !");
            }
            Console.ReadKey();
        }
    }
 }