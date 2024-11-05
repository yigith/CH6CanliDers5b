
// Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

// Alfabetik Sıralama Kültüre Göre Değişik

string[] sehirler = { "ankara", "Iğdır", "ısparta", "İzmir", "izmit", "Kastamonu", "İstanbul", "Ankara", "Zonguldak", "Bursa" };

Console.WriteLine(string.Join(" ", sehirler));

// kültürü tr yapalım
Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
Array.Sort(sehirler);

Console.WriteLine("tr-TR Kültürüne Göre Sıralandı:");
Console.WriteLine(string.Join(" ", sehirler));

// kültürü en yapalım
Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
Array.Sort(sehirler);

Console.WriteLine("en-US Kültürüne Göre Sıralandı:");
Console.WriteLine(string.Join(" ", sehirler));

Console.ReadKey();
