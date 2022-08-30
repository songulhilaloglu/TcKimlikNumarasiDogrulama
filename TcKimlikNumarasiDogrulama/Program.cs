/*1- basla
* 2- kullanıcıdan tc kimlik numarası girmesi istenir, tc alınır
* 3- tc kimlik numarası 11 basamak girildiyse ve 
	1. basamak 0 değilse işleme devam edilir, 
	11 basamaklı değil ve 1. basamağı 0 ise  işlem durdurulur, tekrar girmesi istenir.
* 4- 11 basamaklı ise ve 1. basamağı 0 değilse ; 
	tek basamaklı haneler toplanır çift basamakl haneler toplanır
* 5- Tek basamaklı hanelerin toplamının 7 katı 
	çift basamaklı hanelerin toplamından çıkarılır
* 6- Çıkan sayının 10 a bölümünden kalan kimlik numarasının 
	10. hanesine eşit ise tc doğru , değil ise tc hatalıdır.
* 7- ilk 10 hanenin toplamının 10 a bölümünden kalan 11. haneye eşit ise tc doğru, 
	değil ise tc hatalıdır
* 8- bitir
*/
Console.WriteLine("Kimliğinizi giriniz: ");
string tcKimlikNumarası = Console.ReadLine();

int tcLenght = tcKimlikNumarası.Length; // 11  61012490586

if (tcLenght == 11 && Convert.ToInt32(tcKimlikNumarası.Substring(0, 1)) != 0)
{
    Console.WriteLine(tcKimlikNumarası.Substring(0, 1)); // 6
    Console.WriteLine(tcKimlikNumarası.Substring(2, 1)); // 0
    Console.WriteLine(tcKimlikNumarası.Substring(4, 1)); // 2
    Console.WriteLine(tcKimlikNumarası.Substring(6, 1)); // 9
    Console.WriteLine(tcKimlikNumarası.Substring(8, 1)); // 5

    int TekBasamaklarinToplami = Convert.ToInt32(tcKimlikNumarası.Substring(0, 1)) +
                                Convert.ToInt32(tcKimlikNumarası.Substring(2, 1)) +
                                Convert.ToInt32(tcKimlikNumarası.Substring(4, 1)) +
                                Convert.ToInt32(tcKimlikNumarası.Substring(6, 1)) +
                                Convert.ToInt32(tcKimlikNumarası.Substring(8, 1));
    Console.WriteLine(TekBasamaklarinToplami);

    Console.WriteLine(tcKimlikNumarası.Substring(1, 1)); // 1
    Console.WriteLine(tcKimlikNumarası.Substring(3, 1)); // 1
    Console.WriteLine(tcKimlikNumarası.Substring(5, 1)); // 4
    Console.WriteLine(tcKimlikNumarası.Substring(7, 1)); // 0

    int CiftSayilarinToplami = Convert.ToInt32(tcKimlikNumarası.Substring(1, 1)) +
                                Convert.ToInt32(tcKimlikNumarası.Substring(3, 1)) +
                                Convert.ToInt32(tcKimlikNumarası.Substring(5, 1)) +
                                Convert.ToInt32(tcKimlikNumarası.Substring(7, 1));

    Console.WriteLine(CiftSayilarinToplami);

    int islem = (TekBasamaklarinToplami * 7) - CiftSayilarinToplami;
    Console.WriteLine(islem);

    int ModDegeri = 10;
    int Mod = islem % ModDegeri;

    Console.WriteLine(Mod);
    int DokuzuncuRakam = Convert.ToInt32(tcKimlikNumarası.Substring(9, 1));
    if (Mod == DokuzuncuRakam)
    {
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("T.C. Hatalı");
    }
    int OnHaneninToplami = Convert.ToInt32(tcKimlikNumarası.Substring(0, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(1, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(2, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(3, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(4, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(5, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(6, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(7, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(8, 1)) +
                            Convert.ToInt32(tcKimlikNumarası.Substring(9, 1));

    Console.WriteLine(OnHaneninToplami);

    int Mod1 = OnHaneninToplami % ModDegeri;
    Console.WriteLine(Mod1);

    if (Mod1 == Convert.ToInt32(tcKimlikNumarası.Substring(10, 1)))
    {
        Console.WriteLine("T.C Doğrulandı");
    }
    else
    {
        Console.WriteLine("T.C. Hatalı");
    }
}

else
    Console.WriteLine("Lütfen 11 haneli ve 0 ile başlamayan numara giriniz");
