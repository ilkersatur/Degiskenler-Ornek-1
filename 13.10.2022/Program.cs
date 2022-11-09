
Console.WriteLine("personel");
Console.Write("id = ");
int personel_id = Convert.ToInt16(Console.ReadLine());
Console.Write("Ad Soyad = ");
string personel_ad_soyad = Console.ReadLine();
Console.Write("Yaş = ");
byte personel_yas = Convert.ToByte(Console.ReadLine());

Console.Write("Cinsiyet K ya da E  ");
char cinsiyet = Convert.ToChar(Console.ReadLine());
if (cinsiyet == 'k' || cinsiyet == 'K')
{
    Console.WriteLine("KADIN");
}
if (cinsiyet == 'e' || cinsiyet == 'E')
{
    Console.WriteLine("ERKEK");

}
if (cinsiyet != 'e' && cinsiyet != 'E' && cinsiyet != 'k' && cinsiyet != 'K')
{
    Console.WriteLine("K ya da E giriniz");
}

Console.WriteLine("Maaş zam hesaplama ");
Console.WriteLine("Ana Para ");
decimal ana_para = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Zam oranı ");
decimal zam_oranı = Convert.ToDecimal(Console.ReadLine());
decimal yeni_maas = ana_para + ((ana_para * zam_oranı) / 100);
Console.WriteLine(personel_id + " " + personel_ad_soyad + " Yeni Maaş " + yeni_maas + " Türk Lirasi");
