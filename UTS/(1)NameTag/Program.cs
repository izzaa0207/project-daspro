using System;

namespace NameTag
{
    class Program
    {
        public static void Main(string [] args) {
            String Nama, NIM, Konsentrasi;
            Console.WriteLine("Nama : ");
            Nama = Console.ReadLine();
            Console.WriteLine("NIM : ");
            NIM = Console.ReadLine();
            Console.WriteLine("Konsentrasi : ");
            Konsentrasi = Console.ReadLine();

            Console.WriteLine("==MAHASISWA TEKNIK INFORMATIKA==");
            Console.WriteLine("|=============================|");
            Console.WriteLine("| Nama :                 {0}|",Nama);
            Console.WriteLine("|                       {0}|",NIM);
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("|                          {0}|",Konsentrasi);
            Console.WriteLine("|=============================|");
            Console.ReadLine();
        }
    }
}