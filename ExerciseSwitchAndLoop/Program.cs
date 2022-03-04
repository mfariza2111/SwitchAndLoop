using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciseSwitchAndLoop
{
    class Program
       
    {
        /// <summary>
        /// main class
        /// </summary>
        public double gula, beras, minyak, telur, totgula, totberas, totminyak, tottelur;
        public List<double> harga = new List<double>();
        int pilih;

       /// <summary>
       /// untuk menghitung barang yang akan dimasukkan 
       /// </summary>
        public void Hitunggula()
        {
            // fungsi code dibawah ini untuk membaca perintah yang dijalankan  
            Console.WriteLine("Berapa kilogram gula yang ingin anda beli?");
            gula = Double.Parse(Console.ReadLine());
            totgula = gula * 16000;
            harga.Add(totgula);
            Console.WriteLine("\nBerhasil menambahkan Gula sebanyak: {0} kg kedalam keranjang \n", gula);
        }
        /// <summary>
        /// menghitung kilogram barang yang akan dimasukkan 
        /// </summary>
        public void Hitungberas()
        {
            Console.WriteLine("Berapa kilogram beras yang ingin anda beli?");
            beras = Double.Parse(Console.ReadLine());
            totberas = beras * 15000;
            harga.Add(totberas);
            Console.WriteLine("\nBerhasil menambahkan Beras sebanyak: {0} kg kedalam keranjang  \n", beras);
        }
        /// <summary>
        /// menghitung berapa liter minyak yang di masukkan
        /// </summary>
        public void HitungMinyak()
        {
            Console.WriteLine("Berapa liter minyak goreng yang ingin anda beli?");
            minyak = Double.Parse(Console.ReadLine());
            totminyak = minyak * 14000;
            harga.Add(totminyak);
            Console.WriteLine("\nBerhasil menambahkan Minyak Goreng sebanyak: {0} L kedalam keranjang  \n", minyak);
        }
        /// <summary>
        /// menghitung kilogram telur yang akan dimasukkan
        /// </summary>
        public void Hitungtelur()
        {
            Console.WriteLine("Berapa kilogram telur yang ingin anda beli?");
            telur = Double.Parse(Console.ReadLine());
            tottelur = telur * 19000;
            harga.Add(tottelur);
            Console.WriteLine("\nBerhasil menambahkan Telur sebanyak: {0} kg kedalam keranjang \n", telur);
        }


        /// <summary>
        /// untuk menampilkan menu yang akan di pilih
        /// </summary>
        public void Menu()
        {
           
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Gula Rp. 16.000/kg" +
                        "\n2. Beras Rp. 15.000/kg" +
                        "\n3. Minyak Goreng Rp. 14.000/L" +
                        "\n4. Telur 1Kg Rp. 19.000/kg" +
                        "\n5. Selesai/Keluar");
                    Console.Write("Pilihan (1/2/3/4/5) : ");
                    pilih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    
                    switch (pilih)
                    {
                        case 1:
                            Hitunggula();
                            break;
                        case 2:
                            Hitungberas();
                            break;
                        case 3:
                            HitungMinyak();
                            break;
                        case 4:
                            Hitungtelur();
                            break;
                        case 5:
                            if (!harga.Any())
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("--------------------------------------------------------");
                                Console.WriteLine("List Belanja:" +
                                    "\n {0} kg Gula, " +
                                    "\n {1} kg Beras," +
                                    "\n {2} L Minyak," +
                                    "\n {3} kg Telur"
                                    , gula, beras, minyak, telur);
                                Console.WriteLine("Total Belanja = Rp. {0}\n", harga.Sum(x => x));
                                Console.WriteLine("--------------------------------------------------------\n");
                                Console.WriteLine("Apakah masih ingin berbelanja?\n" +
                                    "tekan 'iya' untuk melanjutkan belanja atau tekan 'apa saja untuk keluar'");

                                if (!Console.ReadLine().Equals("iya", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    harga.Clear();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("\n``\n");
                                    break;
                                }
                            }
                        default:
                            Console.WriteLine("Pilihan tidak tersedia");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Harap memsukkan angka 1 - 5\n");
                }
            }
        }
        /// <summary>
        /// untuk menerima argumen dari tipe data string
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        
        {
          
            Program p = new Program();
            Console.WriteLine("Selamat Datang di Aplikasi Pembelian Sembako" +
                "\nSilahkan memilih barang pada menu pembelian" +
                "\n========================================================\n");
            p.Menu();
        }
    }
}



