using System;

class Lantai
{
    static void Main(String[] args)
    {
        //Console.WriteLine("=== GEDUNG ===");
        int x = 1;
        int y = 5;
        int lantai = 0;
        int angka = 0;
        int ketemu = 0;

        Console.WriteLine("Cari Loker : ");
        int nolok = Convert.ToInt32(Console.ReadLine());
        for (;;)
        {
            for (int i = x; i <= x+2; i++){
                lantai = i;
                //Console.WriteLine("Lantai {0}", i);
                for (int j = 1; j <= y; j++){
                    angka = angka + 1;
                    //Console.Write("<{0}>", angka);
                    if (angka == nolok){
                        Console.Write("Loker Ketemu di Lantai {0}", i);
                        ketemu = ketemu + 1;
                    }              
                }
                Console.WriteLine();
                if ( y != 8){
                    y = y + 1;
                }
            }

            if (ketemu == 1){
                break;
            } else {
                Console.WriteLine("Lanjut Mencari? [Ya/Tidak]: ");
                x = lantai + 1;
                y = 5;
                string pilihan = Console.ReadLine();
                if (pilihan.ToLower() == "tidak"){
                    break;
                }
            }
        }
    }
}