using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUIS1_PBO
{
    internal class Program
    {
        class CommunityMember
        {
            public String Nama, Umur, Alamat, JenisKelamin;
        }

        class Employee : CommunityMember
        {
            public int NIP, Gaji;
            public String TanggalRekrut;
            private int _DanaPensiun;

            public int DanaPensiun
            {
                get { return _DanaPensiun; }
            }

            public void TotalDanaPensiun(int JmlDapen)
            {
                _DanaPensiun += JmlDapen;
            }

            public virtual void HitungGaji()
            {
                int TotalGaji = Gaji;
            }
        }

        class Student : CommunityMember
        {
            public int NIM;
            public String Kelas;
        }

        class Alumnus : CommunityMember
        {
            public int NIM, Angkatan;
        }

        class Faculty : Employee
        {
            public String NamaFakultas;
        }

        class Staff : Employee
        {
            public String Jabatan;

            public override void HitungGaji()
            {
                int GajiTahunan = Gaji * 12;
                Console.WriteLine("Total Gaji Tahunan : Rp." + GajiTahunan);
            }
        }

        class Administrator : Faculty
        {
            public String Role;
        }

        class Teacher : Faculty
        {
            public String MataKuliah;
        }


        static void Main(string[] args)
        {
            Staff staff1 = new Staff();
            staff1.Nama = "Andre";
            staff1.Umur = "20";
            staff1.Alamat = "Jember";
            staff1.JenisKelamin = "Laki-Laki";
            staff1.NIP = 1053;
            staff1.TanggalRekrut = "18 September 2022";
            staff1.Gaji = 8000000;
            staff1.Jabatan = "Petugas Keamanan";

            Console.WriteLine("Nama : " + staff1.Nama);
            Console.WriteLine("Umur : " + staff1.Umur);
            Console.WriteLine("Alamat : " + staff1.Alamat);
            Console.WriteLine("Jenis Kelamin : " + staff1.JenisKelamin);
            Console.WriteLine("NIP : " + staff1.NIP);
            Console.WriteLine("Tanggal Rekrut : " + staff1.TanggalRekrut);
            Console.WriteLine("Gaji : Rp." + staff1.Gaji);
            staff1.HitungGaji();
            Console.WriteLine("Jabatan : " + staff1.Jabatan + "\n");


            Teacher teacher1 = new Teacher();
            teacher1.Nama = "Andi";
            teacher1.Umur = "30";
            teacher1.Alamat = "Jember";
            teacher1.JenisKelamin = "Laki-Laki";
            teacher1.NIP = 1001053;
            teacher1.TanggalRekrut = "15 Januari 2002";
            teacher1.Gaji = 1100000;
            teacher1.MataKuliah = "Metodologi Penelitian";

            Console.WriteLine("Nama : " + teacher1.Nama);
            Console.WriteLine("Umur : " + teacher1.Umur);
            Console.WriteLine("Alamat : " + teacher1.Alamat);
            Console.WriteLine("Jenis Kelamin : " + teacher1.JenisKelamin);
            Console.WriteLine("NIP : " + teacher1.NIP);
            Console.WriteLine("Tanggal Rekrut : " + teacher1.TanggalRekrut);
            Console.WriteLine("Gaji : Rp." + teacher1.Gaji);
            Console.WriteLine("Mengampu Mata Kuliah : " + teacher1.MataKuliah);

            Console.WriteLine("Input Dana Pensiun: ");
            int jmlUangDapen = int.Parse(Console.ReadLine());
            teacher1.TotalDanaPensiun(jmlUangDapen);
            Console.WriteLine("Total Dana Pensiun : Rp. " + teacher1.DanaPensiun + "\n");

            Administrator admin1 = new Administrator();
            admin1.Nama = "Dono";
            admin1.Umur = "25";
            admin1.Alamat = "Jember";
            admin1.JenisKelamin = "Laki-Laki";
            admin1.NIP = 5055;
            admin1.TanggalRekrut = "20 Februari 2015";
            admin1.Gaji = 10000000;
            admin1.Role = "Administrator Keamanan Sistem";

            Console.WriteLine("Nama : " + admin1.Nama);
            Console.WriteLine("Umur : " + admin1.Umur);
            Console.WriteLine("Alamat : " + admin1.Alamat);
            Console.WriteLine("Jenis Kelamin : " + admin1.JenisKelamin);
            Console.WriteLine("NIP : " + admin1.NIP);
            Console.WriteLine("Tanggal Rekrut : " + admin1.TanggalRekrut);
            Console.WriteLine("Gaji : Rp." + admin1.Gaji);
            Console.WriteLine("Role : " + admin1 .Role + "\n");

        }
    }
}


            


    

