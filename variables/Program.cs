using System.Globalization;

byte b = 5; // 1byte
sbyte c = 5; // 1byte

short s = 5; // 2byte
ushort us = 5; //2byte

Int16 i16 = 2; //2byte
Int32 i32 = 2; //4byte
Int64 i64 = 2; //8byte
int i = 2; //4byte

uint ui = 2; //4byte
long l = 4; //8byte
ulong ul = 4; //8byte

// Reel Sayılar
float f = 5; //4byte
double d = 5; //8byte
decimal de = 5; //16byte

char ch = '2'; //2byte
string str = "Fatih"; //sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o1 = "x";
object o2 = 'c';
object o3 = 4;
object o4 = 4.3;

// String İfadeler
string str1 = string.Empty;
str1 = "Fatih Kürekçi";
string name = "Fatih";
string surname = "Kürekçi";
string fullName = name + " " + surname;

//Integer Tanımlama Şekilleri
int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

//Boolean
bool bool1 = 10 > 2;

//Değişken Dönüşümleri
string str20 = "20";
int int20 = 20;
string newValue = str20 + int20.ToString();
Console.WriteLine(newValue); //Çıktı: 2020
int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); //Çıktı: 40
int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22); //Çıktı: 40

// DateTime
string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime);
string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine(dateTime2);
string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);