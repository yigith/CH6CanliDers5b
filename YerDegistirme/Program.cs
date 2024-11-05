
using YerDegistirme;

Console.WriteLine("İki sayı girin");
Console.Write("Sayı 1: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı 2: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Öncesi: {0} ve {1}", sayi1, sayi2);
Yardimci.YerDegistir<int>(ref sayi1, ref sayi2);
Console.WriteLine("Öncesi: {0} ve {1}", sayi1, sayi2);


// SORU: Peki yer değiştirmek istediğimiz değerler
// string olsaydı? ya da Araba olsaydı ya da DateTime olsaydı, her biri için ayrı metot mu yazmalıydık?

string ad1 = "melis", ad2 = "murat";
Console.WriteLine("Öncesi: {0} ve {1}", ad1, ad2);
Yardimci.YerDegistir<string>(ref ad1, ref ad2);
Console.WriteLine("Öncesi: {0} ve {1}", ad1, ad2);

bool deger1 = true, deger2 = false;
Console.WriteLine("Öncesi: {0} ve {1}", deger1, deger2);
Yardimci.YerDegistir(ref deger1, ref deger2);
Console.WriteLine("Öncesi: {0} ve {1}", deger1, deger2);

Console.ReadKey();
