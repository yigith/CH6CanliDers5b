
baslangic:
Console.Write("Karesi alınmak istenen tam sayı: ");

try
{
	int sayi = Convert.ToInt32(Console.ReadLine());

	int karesi = sayi * sayi;

	Console.WriteLine("Karesi: " + karesi);
}
catch (FormatException ex)
{
    // Console.WriteLine(ex.Message); // default
    Console.WriteLine("Hatalı biçemde bir sayı girdiniz.");
    goto baslangic;
}
catch (OverflowException ex)
{
    // Console.WriteLine(ex.Message); // default
    Console.WriteLine("Çok büyük ya da küçük bir sayı girdiniz.");
    goto baslangic;
}

Console.ReadKey();
