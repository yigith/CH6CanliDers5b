
using SiralamaGercegi;

List<string> adlar =  new List<string>() { "Mahir", "Hamit", "Gizem", "Gülşen", "Salih", "Gözde" };
adlar.AddRange(new[] { "İrem", "Ezgi", "Yaşar", "Mehmet Ali" });

Console.WriteLine("Şu Ana Kadar Ekleneler");
Console.WriteLine(string.Join("-", adlar));

Console.WriteLine("Sıraladıktan Sonra");
adlar.Sort();
Console.WriteLine(string.Join("-", adlar));

Console.WriteLine();
// SORT METODU Ezgi'nin Gizem'den önce geleceğini nereden biliyor?
// Bu bilgi sizde Sort() metodunun içinde tanımlı var mıdır?

int[] sayilar = { 14, 18, 78, 34, 23, 11, 29 };
Console.WriteLine("öncesi : " + string.Join(" > ", sayilar));
Array.Sort(sayilar);
Console.WriteLine("sonrası: " + string.Join(" > ", sayilar));

// Array.Sort metodu hangi sayının önce geleceğini nereden biliyordu?
// Bu bilgi sizce Sort metodunun içine kodlanmış mıydı?

List<Araba> arabalar = new List<Araba>();
arabalar.Add(new Araba("Toros", 1992));
arabalar.Add(new Araba("Şahin", 2000));
arabalar.Add(new Araba("Mustang", 2020));
arabalar.Add(new Araba("Toros", 1990));
arabalar.Add(new Araba("Clio", 2022));
arabalar.Add(new Araba("Doblo", 2012));
arabalar.Add(new Araba("Porsche", 2000));

Console.WriteLine("öncesi : " + string.Join(" > ", arabalar));
arabalar.Sort(); // çalışır mı?
Console.WriteLine("sonrası: " + string.Join(" > ", arabalar));


Console.ReadKey();