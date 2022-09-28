using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İşlemli Atama Operatörleri :
            // += operatörü değişkeni eşitliğin karşısındaki sayıyla toplar.
            // -= operatörü değişkeni eşitliğin karşısındaki sayıdan çıkartma işlemi yapar.
            // /= operatörü değişkeni eşitliğin karşısındaki sayıyla böler.
            // *= operatörü değişkeni eşitliğin karşısındaki sayıyla çarpar.

            // Mantıksal Atama Operatörleri :
            // || Veya anlamına gelir.
            // && Ve anlamına gelir.
            // ! Değil anlamına gelir.(True değerini False, False değerini True haline getirir.)

            // İlişkisel Operatörler :
            // < küçüktür.
            // > büyüktür.
            // <= küçük eşittir.
            // >= büyük eşittir.
            // == eşit eşittir.
            // != eşit değildir.

            // Aritmetik Operatörler :
            // / bölme işlemi.
            // * çarpma işlemi.
            // + toplama işlemi.
            // - çıkartma işlemi.
            // % bölümünden kalanı gösterir.
            // ++ konduğu değişkeni 1 arttırır.
            // -- konduğu değişkeni 1 eksiltir.

            Console.WriteLine("İşlemli Atama Operatörleri Örneklerini Görmek istiyorsanız 1");
            Console.WriteLine("Mantıksal Atama Operatörleri Örneklerini Görmek istiyorsanız 2");
            Console.WriteLine("İlişkisel Operatör Örneklerini Görmek istiyorsanız 3");
            Console.WriteLine("Aritmetik Operatör Örneklerini Görmek istiyorsanız 4");
            int orn0 = Convert.ToInt32(Console.ReadLine());

            //İşlemli atama operatörleri örnekleri.
            if (orn0 == 1) 
            {
                double a, b;
                Console.Write("1. sayıyı giriniz : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("2. sayıyı giriniz : ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("+= Örneği için 1");
                Console.WriteLine("-= Örneği için 2");
                Console.WriteLine("/= Örneği için 3");
                Console.WriteLine("*= Örneği için 4");
                int orn1 = Convert.ToInt32(Console.ReadLine());

                if(orn1 == 1)
                {
                    // += örneği
                    a += b; // a'yı b ile topluyor ve a'nın yeni değerini kaydediyor.
                    Console.WriteLine("1. Sayınızın {1} ile toplanmış hali : {0}", a, b);   // Çıktısı 9, a'nın değeri artık 9.
                }
                else if (orn1 == 2)
                {
                    // -= örneği
                    a -= b; // a'dan b'yi çıkarıyor ve a'nın yeni değerini kaydediyor.
                    Console.WriteLine("1. Sayınızın {1} ile eksiltilmiş hali : {0}", a, b);
                }

                else if(orn1 == 3)
                {
                    // /= örneği
                    a /= b; // a'yı b'ye bölüyor ve a'nın yeni değerini kaydediyor.
                    Console.WriteLine("1. Sayınızın {1} ile bölünmüş hali : {0}", a, b);    
                }
                
                else if(orn1 == 4)
                {
                    // *= örneği
                    a *= b; // a'yı b ile çarpıyor ve a'nın yeni değerini kaydediyor.
                    Console.WriteLine("1. Sayınızın {1} ile çarpılmış hali : {0}", a, b);
                }

                else
                {
                    Console.WriteLine("Verilen değerlerden birini girmediniz programı yeniden başlatınız."); 
                }
            }

            //Mantıksal atama operatörleri örnekleri.
            if(orn0 == 2)
            {
                bool dogru = true, yanlis = false;

                if (dogru && yanlis)
                    Console.WriteLine("Maalesef...");//Bu yazı ekrana gelmeyecek çünkü && (ve) kullanadığımızda iki değer de true olmalı.
                if (dogru || yanlis)
                    Console.WriteLine("Güzel!");//Bu yazı ekrana gelecek çünkü || (veya) operatörü için tek true değer yeterli.
                if (dogru && !yanlis)
                    Console.WriteLine("İyi.");//Bu yazı ekrana gelecek çünkü ! (değil) operatörü false olan yanlis değişkenini true yapıyor.
            }

            // İlişkisel operatör örnekleri.
            if(orn0 == 3)
            {
                bool sonuc;
                double a, b;
                Console.Write("1. Sayıyı giriniz : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("2. Sayıyı giriniz : ");
                b = Convert.ToDouble(Console.ReadLine());

                sonuc = a < b;      // a değişkeni b'den küçük ise aşağısı true olur değilse false.
                    Console.WriteLine("{0} değeri {1} değerinden küçük : {2}", a, b, sonuc);
                sonuc = a > b;      // a değişkeni b'den büyük ise aşağısı true olur değilse false.
                    Console.WriteLine("{0} değeri {1} değerinden büyük : {2}", a, b, sonuc);
                sonuc = a <= b;      // a değişkeni b'den küçük veya eşit ise aşağısı true olur değilse false.
                    Console.WriteLine("{0} değeri {1} değerinden küçük veya eşit : {2}", a, b, sonuc);
                sonuc = a >= b;      // a değişkeni b'den büyük veya eşit ise aşağısı true olur değilse false.
                    Console.WriteLine("{0} değeri {1} değerinden büyük veya eşit : {2}", a, b, sonuc);
                sonuc = a == b;      // a değişkeni b'ye eşit ise aşağısı true olur değilse false.
                    Console.WriteLine("{0} değeri {1} değerine eşit : {2}", a, b, sonuc);
                sonuc = a != b;      // a değişkeni b'ye eşit değilse aşağısı ture olur değilse false.
                    Console.WriteLine("{0} değeri {1} değerine eşit değildir : {2}", a, b, sonuc);
            }

            // Aritmetik operatör örnekleri.
            if (orn0 == 4)
            {
                double a, b;
                double bolme, carpma, toplama, cikartma, mod, arttir, eksilt;
                Console.Write("1. sayıyı giriniz : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("2. sayıyı giriniz : ");
                b = Convert.ToDouble(Console.ReadLine());

                bolme = a / b;      // a değişkenini b'ye bölüp sonucu aşağıya yazıyor.
                Console.WriteLine("{0} sayısının {1} ile bölümü = {2}", a, b, bolme);
                carpma = a * b;     // a değişkeninin b ile çarpıp sonucu aşağıya yazıyor.
                Console.WriteLine("{0} sayısının {1} ile çarpımı = {2}", a, b, carpma);
                toplama = a + b;    // a değişkenini b ile toplayıp sonucu aşağıya yazıyor.
                Console.WriteLine("{0} sayısının {1} ile toplamı = {2}", a, b, toplama);
                cikartma = a - b;   // a değişkeninden b'yi çıkarıp sonucu aşağıya yazıyor.
                Console.WriteLine("{0} sayısının {1} ile çıkarılması = {2}", a, b, cikartma);
                mod = a % b;        // a değişkeninin b ile bölümünden kalanını aşağıya yazıyor.
                Console.WriteLine("{0} sayısının {1} ile bölümünden kalan = {2}", a, b, mod);
                a++;                // a değişkenini 1 arttırıp aşağıya yazıyor.
                Console.WriteLine("1. sayının 1 artmış hali : {0} ", a);
                b--;                // b değişkeninini 1 azaltıp aşağıya yazıyor.
                Console.WriteLine("2. sayının 1 eksilmiş hali {0} ", b);
            }

            else
                Console.WriteLine("Verilen değerlerden herhangi birisini girmediniz programı yeniden başlatın.");
        }
    }
}
