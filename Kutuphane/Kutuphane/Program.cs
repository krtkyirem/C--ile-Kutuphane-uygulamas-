using System;

namespace Kutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" ");
                Console.WriteLine($"                                                                                                 { DateTime.Now}");
                Console.WriteLine(" ");
                Console.WriteLine("                                      Kütüphane'ye Hoşgeldinizzz :)                              ");
                string[] kitaplar = new string[0];
                while (true)
                {
                    Console.WriteLine("Kitap ekle(1)- Kitap listesi(2)- Çıkış(3)");
                    char enter = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (enter == '1')
                    {
                        Console.WriteLine();                 
                        Array.Resize(ref kitaplar, kitaplar.Length + 1);
                        Console.Write("Kitap'ın isimi , yazarı , türü , numarası :");
                        kitaplar[kitaplar.Length - 1] = Console.ReadLine();
                    }
                    else if (enter == '2')
                    {
                        for (int i = 0; i < kitaplar.Length; i++)
                        {
                            Console.WriteLine(kitaplar[i]);
                        }
                    }
                    else if (enter == '3')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş...");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.Write("Kütüphaneyi tercih ettiğiniz için teşekkür ederiz");
            }
        }
    }
}
