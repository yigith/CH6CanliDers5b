
Console.WriteLine("Ankara mı önce gelir Zonguldak mı?");
int sonuc = "ankara".CompareTo("zonguldak");
Console.WriteLine("Sonuç: " + sonuc);

// negatif sonuç döndürse metodun uygulandığı nesne önce gelir
// pozitif ise sonra gelir
// 0 ise aynıdır

Console.WriteLine("Konya mı önce gelir Balıkesir mi?");
sonuc = "Konya".CompareTo("Balıkesir");
Console.WriteLine("Sonuç: " + sonuc);

Console.WriteLine("Trabzon mu önce gelir Trabzon mu?");
sonuc = "Trabzon".CompareTo("Trabzon");
Console.WriteLine("Sonuç: " + sonuc);


Console.WriteLine("Sayı olarak 3 mü önce gelir 100 mü?");
Console.WriteLine("Sonuç: " + 3.CompareTo(100));

Console.WriteLine("true mü önce gelir false mu");
Console.WriteLine("Sonuç: " + true.CompareTo(false));

// bu türlerin hepsinde CompareTo olması tesadüf mü?

// bu türlerin hepsine IComparable interface'ini uyguladı
// ta ki günün birinde bu türleri başka bir sınıf sıralamak isterse
// o standarda uygun olarak hangisinin önce gelebileceğini 
// IComparable görünümde nesneleri kıyaslayarak bilebilsin

Console.ReadKey();