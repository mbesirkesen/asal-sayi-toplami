using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//N'e Kadar Asal Sayıların Toplamı: Kullanıcıdan alınan N sayısına kadar olan tüm asal sayıların toplamını bulan bir program yazın.

namespace asal_sayi_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            //KULLANICIDAN N SAYISINI ALMA
            Console.Write("lutfen hangi sayiya kadar asal sayilarin toplamini yazdıracagımızı tuslayın(N): ");
            int n = int.Parse(Console.ReadLine());
            //DWGİSKEN ATAMA
            int toplam = 0, flag = 0, k = 0;
            //ÖZEL DURUMLARI GOZ ONUNE ALALIM
            if (2 <= n)
            {
                toplam += 2;
            }
            //N SAYİSİNA KADAR OLAN ASAL SAYILARIN TOPLAMI
            for (int i = 3; i <= n; i++)
            {
                flag = 0;
                k = i;
                for (int l = 2; l < k; l++)
                {
                    if (k % l == 0)
                    { 
                        flag = 1;
                        break;
                    }
                }
                
                if (flag != 1)
                {
                    toplam += k;
                }
            }
            //N SAYISINA KADAR OLAN TÜM ASAL SAYİLARIN TOPLAMINI EKRANA YAZDIRMA
            Console.WriteLine("N SAYISINA KADAR OLAN TÜM ASAL SAYILARIN TOPLAMI: " + toplam);
            Console.ReadKey();
        }
    }
}
