using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

SelamVer(isim: "Ferhat");
SelamVer(isim: "İsimli kişi");
SelamVer();

int sonuc = Topla(6,58);

//Diziler  / Arrays


string ogrenci1 = "Engin";
string ogrenci2 = "Ferhat";
string ogrenci3 = "Yılmaz";

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Ferhat";
ogrenciler[2] = "Yılmaz";

ogrenciler = new string[4];
ogrenciler[3] = "Ahmet";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara","İstanbul","İzmir"};
string[] sehirler2 = new[] { "Bursa","Antalya","Diyarbakır"};

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Ferhat";
person1.LastName = "Yılmaz";
person1.DateOfBirthYear = 2001;
person1.NationalIdentity = 12345; //Kimlik No doğru ise maske verildi, değil ise maske verilmedi çıktısı alınır.

Person person2 = new Person();
person2.FirstName = "Deneme";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//MyList
List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add(item: "Adana 1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba" + isim);
}


static int Topla(int sayi1 = 5,int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam :"+ sonuc.ToString());
    return sonuc;
}



public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}