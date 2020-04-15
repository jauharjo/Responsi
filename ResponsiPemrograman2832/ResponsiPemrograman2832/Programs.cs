using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2832
{
    class Programs
    {
        static void Main(string[] args)
        {
            var kar1 = new Karyawan("0123456", "Nur", 3000000);
            var kar2 = new Karyawan("0234567", "Jauhar", 1500000);
            var kar3 = new Karyawan("0345678", "Muslih", 2000000);

            Console.WriteLine("\n=====================================================");
            Console.WriteLine("\t\tList Gaji Bulanan");
            Console.WriteLine("=====================================================");
            Console.WriteLine("No   NIK \t\t Nama \t\t Gaji Bulanan");
            Console.WriteLine("1.   {0} \t\t {1} \t\t {2}", kar1.Nik, kar1.Nama, kar1.GajiBulanan);
            Console.WriteLine("2.   {0} \t\t {1} \t {2}", kar2.Nik, kar2.Nama, kar2.GajiBulanan);
            Console.WriteLine("3.   {0} \t\t {1} \t {2}", kar3.Nik, kar3.Nama, kar3.GajiBulanan);
            Console.WriteLine("\n=====================================================");
            Console.WriteLine("\tKenaikan Gaji Karyawan Sebesar 10%");
            Console.WriteLine("=====================================================");
            Console.WriteLine("No   NIK \t\t Nama \t\t Gaji Bulanan");
            Console.WriteLine("1.   {0} \t\t {1} \t\t {2}", kar1.Nik, kar1.Nama, (kar1.GajiBulanan) * 110 / 100);
            Console.WriteLine("2.   {0} \t\t {1} \t {2}", kar2.Nik, kar2.Nama, (kar2.GajiBulanan) * 110 / 100);
            Console.WriteLine("3.   {0} \t\t {1} \t {2}", kar3.Nik, kar3.Nama, (kar3.GajiBulanan) * 110 / 100);

            Console.ReadKey();
        }
    }
}
