using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswwa = "Eril";

            //objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswwa = "Welly";

            //objek dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            //membuat objec list
            List<Mahasiswa> list = new List <Mahasiswa>();
            List<Dosen> list0 = new List<Dosen>();

            //menambahkan elemen list
            list.Add(mhs1);
            list.Add(mhs2);

            //tambahkan objek dosen kedalam list
            list0.Add(dosen);

            //mengakses elemen list mahasiswa
            Mahasiswa mhs = list[0];
           // Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswwa);

            //mengakses elemen list dosen
            Dosen dsn = list0[0];
            //Console.WriteLine("{0}, {1}", dosen.Nik, dosen.NamaDosen);

            Console.WriteLine("Nim\tNama");
            Console.WriteLine("=============");
            foreach(Mahasiswa maha in list)
            {
                Console.WriteLine("{0}\t{1}", maha.Nim, maha.NamaMahasiswwa);
            }
            Console.ReadKey();
        }
    }
}
