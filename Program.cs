internal class Program
{
    private static void Main(string[] args)
    {
        // Dizileri birden fazla tanımama şekli var ona bakıcaz.Bir dizinin elemanlarına nasıl değer atanır ve bu elemana nasıl ulaşılır. 
        // Sonrada döngüler ile dizi kullanımına bakacağız.
        // Dizinin tanımı; Aynı tipteki değişkenleri bellekte arka arkaya saklama işlemini yapmaya yarar.
        // Dizinin elemanlarının veri tipleri her zaman aynı olmalıdır. Bir string dizi tanımandığında onun içine integer bir değer atanamaz.
        // Diziler sıfırıncı elemandan başlar dolayısıyla dizin içinde beşinci elemana ulaşmak için dizinin 4.cü indeksteki elemanını şeklinde ulaşmalıyız.

        // Dizi Tanımlama
        string[] renkler = new string[5];  // Burada elemanları string tipte renkler adında ve elemanları belli olmayıp dizinin boyutu (5) belli olan bir dizin tanımlaması yaptık.
        string[] hayvanlar = {"Kedi","Tavşan","Kuş","Maymun"}; // Burada hayvanlar adında bir dizi tanımladık.Dizin string elemanlardan oluşuyor.dizinin 4 tane elemanlarınında ataması yapılmış ve dizinin boyutuda 4 dür.

           // Burada int tipinde elemanlara sahip bir dizin oluşturduk.Ama elemanıda boyutuda belli değildir daha sonra kullanılacağı zaman boyutu belirleyebiliriz.
        int[] dizi;
        dizi = new int[4];

        // Dizilere Değer Atama ve Erişim
        renkler[0] = "Mavi";   // Burada renkler adındaki dizinin (0) sıfırıncı elemanına mavi rengi atadık.
        dizi[3] =10;          // Burada 'dizi' adındaki dizinin 3.cü elemanına 10 nun atamasını yaptık    

        Console.WriteLine(hayvanlar[0]);   // Burada hayvanlar dizinin elemanları yukarıda atanmıştı zaten bizde burada o elamana(sıfırıncı elemana) erişim sağlıyoruz.
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        // Döngülerle dizi kullanımı
        // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
        Console.WriteLine("Lütfen dizinin eleman sayısını giriniz");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayıDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("Lütfen {0}. sayıyı giriniz :",i+1);
            sayıDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in sayıDizisi)
          toplam += sayi;

        Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);  
        
       
        




    }   
} 