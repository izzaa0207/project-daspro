using System;

namespace PeminjamanBuku
{
    class Program
    {
        static void Main(string[] args)
        {
            int denda = 0;
            int hari = 0;
            Console.WriteLine("Masukkan jumlah hari peminjaman buku : ");
            hari = Convert.ToInt32(Console.ReadLine());
            if (hari > 30)
            {
                denda = (hari - 30) * 30000 + 50000 + 400000;
                Console.WriteLine("Denda anda : " + denda);
                Console.WriteLine("Keanggotaan anda dibatalkan");
            }
            else if (hari > 10)
            {
                denda = (hari - 10) * 20000 + 50000;
                Console.WriteLine("Denda anda : " + denda);
            }
            else if (hari > 5)
            {
                denda = hari * 10000;
                Console.WriteLine("Denda anda : " + denda);
            }
            else
            {
                Console.WriteLine("Anda tidak dikenai denda");
            }
            Console.ReadKey();
        }
    }
}