baslangic:
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Masaüstünde okunmasını istediğiniz dosyanın tam adı (abc.txt gibi): ");
string ad = Console.ReadLine();

string masaustuYol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string dosyaYolu = masaustuYol + "\\" + ad;

try
{
	string icerik = File.ReadAllText(dosyaYolu);
    Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine(icerik);
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Dosya okunurken hata oluştu.");
}
finally
{
    // try ya da catch bloğundan çıktıktan sonra çalışır
    Console.WriteLine("");
}

goto baslangic;

Console.ReadKey();