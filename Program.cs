﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            //Membuat objek untuk semua karyawan

            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.NIK = "211-234-445";
            karyawantetap.NAMA = "Icha Nura Nughraha";
            karyawantetap.GajiBulanan = 20000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.NIK = "213-224-546";
            karyawanharian.NAMA = "Muhammad Sabik";
            karyawanharian.HitunganJamKerja = 10;
            karyawanharian.PendapatanPerJam = 25000;

            Sales sales = new Sales();
            sales.NIK = "321-233-344";
            sales.NAMA = "Ulil Al Ikhlas";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 50000;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.NIK, karyawan.NAMA, karyawan.Pendapatan());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}