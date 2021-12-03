using System;

namespace cek_bilangan_prima_week_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bilangan, sisa, jumlahBilangan;
           
            Console.Write("Silahkan masukan bilangan bulat = ");
            bilangan = Convert.ToInt16(Console.ReadLine());
            jumlahBilangan = 0;
            for (int i = 1; i <= bilangan; i++)
            {
                sisa = bilangan % i;
                if (sisa == 0)
                    jumlahBilangan = jumlahBilangan + 1;
                else
                    jumlahBilangan = jumlahBilangan;
            }
            if (jumlahBilangan > 2)
            {
                Console.WriteLine("Bukan bilangan prima!");
            }
            else
            {
                Console.WriteLine("Bilangan prima!");
            }
        }
    }
}
  
