using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım__Inheritance_2
{
    internal class Program
    {
        class Calisan
        {
            public string AdSoyad { get; set; }

            public void BilgiGoster()
            {
                Console.WriteLine($"Çalışan: {AdSoyad}");
            }
        }

        class Yonetici : Calisan
        {
            public string Departman { get; set; }

            // new ile metodu gizliyoruz (shadowing)
            public new void BilgiGoster()
            {
                Console.WriteLine($"Yönetici: {AdSoyad}, Departman: {Departman}");
            }
        }

        static void Main(string[] args)
        {
            Calisan c1 = new Calisan { AdSoyad = "Ali Yılmaz" };
            c1.BilgiGoster();

            Yonetici y1 = new Yonetici { AdSoyad = "Ayşe Kaya", Departman = "İK" };
            y1.BilgiGoster();

            // new ile gölgelemenin farkı burada görülür:
            Calisan c2 = new Yonetici { AdSoyad = "Mehmet Demir", Departman = "Satış" };
            c2.BilgiGoster(); // Base sınıfın metodu çalışır
        }
    }
}
