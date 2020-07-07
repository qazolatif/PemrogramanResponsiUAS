using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi: ");
            Console.WriteLine("1). Tambah Penjualan");
            Console.WriteLine("2). Hapus Penjualan");
            Console.WriteLine("3). Tampilkan Penjualan");
            Console.WriteLine("4). Keluar");

            Console.WriteLine();
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Penjualan penjualan = new Penjualan();

            Console.WriteLine("TAMBAH DATA PENJUALAN");

            Console.Write("Nota       : ");
            penjualan.nota = (Console.ReadLine());

            Console.Write("Tanggal    : ");
            penjualan.tanggal = Console.ReadLine();

            Console.Write("Customer   : ");
            penjualan.customer = (Console.ReadLine());

            Console.Write("Jenis [T/K]: ");
            penjualan.jenis = Console.ReadLine();

            Console.Write("Total Nota : ");
            penjualan.total = Convert.ToDouble(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("HAPUS DATA PENJUALAN");

            bool found = true;

            string n;
            Console.Write("Nota: ");
            n = (Console.ReadLine());

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if (daftarPenjualan[i].nota == n)
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("Data dengan nota {0} tidak ditemukan", n);
            }
            else
            {
                Console.WriteLine("Data dengan nota {0} berhasil dihapus", n);
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("DATA MENU PENJUALAN");
            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NOTA | TANGGAL | CUSTOMER | JENIS | TOTAL |");
            Console.WriteLine("==================================================");
            
            for(int i = 0; i < daftarPenjualan.Count; i++) 
            {
                if(daftarPenjualan[i].jenis == "T")
                {
                    Console.WriteLine(" {0}. | {1} | {2} | {3} | Tunai | {4} |", i + 1, daftarPenjualan[i].nota, daftarPenjualan[i].tanggal, daftarPenjualan[i].customer, daftarPenjualan[i].total);
                }
                else
                {
                    Console.WriteLine(" {0}. | {1} | {2} | {3} | Kredit | {4} |", i + 1, daftarPenjualan[i].nota, daftarPenjualan[i].tanggal, daftarPenjualan[i].customer, daftarPenjualan[i].total);
                }
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
