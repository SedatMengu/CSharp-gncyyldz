// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

// Console.WriteLine(typeof(bool).IsPrimitive);
// Console.WriteLine(typeof(char).IsPrimitive);
// Console.WriteLine(typeof(sbyte).IsPrimitive);
// Console.WriteLine(typeof(byte).IsPrimitive);
// Console.WriteLine(typeof(short).IsPrimitive);
// Console.WriteLine(typeof(ushort).IsPrimitive);
// Console.WriteLine(typeof(int).IsPrimitive);
// Console.WriteLine(typeof(uint).IsPrimitive);
// Console.WriteLine(typeof(long).IsPrimitive);
// Console.WriteLine(typeof(ulong).IsPrimitive);
// Console.WriteLine(typeof(float).IsPrimitive);
// Console.WriteLine(typeof(double).IsPrimitive);
// Console.WriteLine(typeof(decimal).IsPrimitive);
// Console.WriteLine(typeof(object).IsPrimitive);
// Console.WriteLine(typeof(string).IsPrimitive);




// string @static = "slm";

// Console.WriteLine(@static);

// int a = 0;

// a = 9;

// a=100;

// Console.WriteLine(a);


// char @char = 'a';

// Console.WriteLine(@char);

// bool evliMisin = true;
// bool satistaMi = false;

// Console.WriteLine(evliMisin);
// Console.WriteLine(satistaMi);

// float @float = 3.14f;
// float @float2= 3.15F;

// Console.WriteLine(@float);
// Console.WriteLine(@float2);


// double @double = 7.10d;
// double @double2 = 7.17D;

// Console.WriteLine((@double , @double2));

// decimal @decimal = 12.9m;
// decimal @decimal2 = 3.2M;

// // Console.WriteLine((@decimal , @decimal2));

// (int @int , 
// string @string , 
// char @char) @tuple = (3,"ahmet",'k');

// Console.WriteLine(@tuple);

// Console.WriteLine(@tuple.@char);

// double sayi = 1_000_00000_000;

// bool x = default;

// Console.WriteLine(x);


// const string name = "kemal";

// readonly string isim = "idris";


// Console.WriteLine(name);

// object rakam = 7;

// rakam = rakam*8;

// Console.WriteLine(rakam);

// object @string = "hello world!";

// Console.WriteLine(@string.GetType());


// object A = "cem";

// string isim = (string)A ;

// Console.WriteLine(isim.ToUpper());

// int a = 7;
// int b = a;
// b = b * 3;

// Console.WriteLine(a);
// Console.WriteLine(b);


// int b = 5;
// b="kale";
// b = true;


// dynamic a = 3;
// a = true;
// a="isim";

// Console.WriteLine(a);
// Console.WriteLine(a.GetType());


// string x = "123";

// Console.WriteLine(int.Parse(x) * 2);

// dynamic x1 = "12";

// Console.WriteLine(short.Parse(x1)*2);

// var a = "9";

// Console.WriteLine(double.Parse(a)*2);


// object a1 = "7";

// string b = (string)a;

// Console.WriteLine(int.Parse(b)*3);



// int a = Convert.ToBase64CharArray(@string);
// // Convert.ToBase64String();
// Convert.ToBoolean();
// Convert.ToByte();
// Convert.ToChar();
// Convert.ToDateTime();
// Convert.ToDecimal();
// Convert.ToDouble();
// Convert.ToHexString();
// Convert.ToInt16();
// Convert.ToInt32();
// Convert.ToInt64();
// Convert.ToSByte();
// Convert.ToSingle();
// Convert.ToString();
// Convert.ToUInt16();
// Convert.ToUInt32();
// Convert.ToUInt64();
// Convert.TryToBase64Chars();
// Convert.TryFromBase64Chars();
// Convert.TryFromBase64String();
// Convert.GetTypeCode();

// string x3 = "123";

// Console.WriteLine(Convert.ToDouble(x3)*2);


// int a = 100 ;

// Console.WriteLine(a.ToString()+100);

// Console.WriteLine(typeof(a)


// int x = 300;

// // double y = x;   // herhangi bir veri kaybına yol açmayacağını bildiği için compiler bunu otomatik olarak yaptı. implicit type convertion


// // byte z = x;   // explicit tür dönüşümü olacağı için şu şekilde hata verdi. Cannot implicitly convert type 'int' to 'byte'.An explicit conversion exists (are you missing a cast?)CS0266

// byte w = (byte)x; // () cast operatörü ile bu dönüşümü explicit olarak yaptık. 
// Console.WriteLine(w);


// bool c = false;

// decimal d = Convert.ToDecimal(c);

// Console.WriteLine(d);

// int i = 1;

// bool b = Convert.ToBoolean(i);

// Console.WriteLine(b);"


// int l = 97;

// char c = (char)l;

// Console.WriteLine(c);

// int a = 4;
// int b = 6;

// int c = a+b;

// Console.WriteLine(c);

// int i = 10;

// Console.WriteLine(i++);
// Console.WriteLine(++i);


// int a = 9;
// int b = a++;

// Console.WriteLine(a);
// Console.WriteLine(b);

// string a = "adnan";
// string b = "ziyagil";

// Console.WriteLine(a+b);

// string a = "kemal";
// int b = 10;

// Console.WriteLine(a+b);

// int  i = 9 ;

// int i2 = 5;

// Console.WriteLine((i == i2));
// Console.WriteLine(!(i == i2));
// Console.WriteLine((i == i2)!);


// string value ="hello World";
// string value11 = "";

// String result = value ?? "null";
// String result11 = value11 ?? "null";


// Console.WriteLine(result);
// Console.WriteLine(result11);

// bool medeniHal = true;

// int rakamsal = medeniHal==true ? 2:3;

// Console.Write("lütfen bir sayı giriniz: " );

// int sayi = int.Parse(Console.ReadLine());

// int @ternary = sayi<3 ? sayi * 5 : 
//             (sayi >= 3 && sayi < 9 ? sayi*3 : 
//             (sayi >= 9 && sayi % 2 ==0 ? sayi*10 : 
//             (sayi % 2 == 1 ? sayi : -1 )));

// Console.WriteLine(@ternary);


// Console.Write("lütfen ihtimal giriniz: ");

// string ihtimal = Console.ReadLine();

// string sonuc = ihtimal == "1" ? "yağmur yağabilir şemsiye al!": 
//                 ( ihtimal =="2" ? "güneşli , bol bol d vitamini alman dileğiyle..." :
//                 ( ihtimal =="3" ? "hava kapalı , yağmur yağabilir": "ihtimal dışı seçenek"));

// Console.WriteLine(sonuc);

// Console.Write("lütfen hava durumu giriniz: ");

// string ihtimal1 = Console.ReadLine();

// string sonuc1 = ihtimal1 == "yağmurlu" ? "şemsiye al!": 
//                 ( ihtimal1 =="güneşli" ? "bol bol d vitamini alman dileğiyle..." :
//                 ( ihtimal1 =="kapalı" ? "yağmur yağabilir": "ihtimal dışı seçenek"));

// Console.WriteLine(sonuc1);

// Console.Write("lütfen hava durumu giriniz: ");

// string ihtimal1 = Console.ReadLine();

// string sonuc1 = ihtimal1 == "yağmurlu" ? "şemsiye al!": 
//                 ( ihtimal1 =="güneşli" ? "bol bol d vitamini alman dileğiyle..." :
//                 "yağmur yağabilir");

// Console.WriteLine(sonuc1);

// string b = null;

// Console.WriteLine(b ?? " hiç bir değer girmediniz");

// int? a = 19;

// Console.WriteLine(a ?? 10);

// byte b = 100;

// short a1 = b;


// long @longOrnek = 100;

// // int @convertLong = (byte)@longOrnek;

// bool b = true;
// int i = Convert.ToInt32(b);

// Console.WriteLine(i);

// short s = 8;
// bool a = Convert.ToBoolean(s);
// Console.WriteLine(a);

// char x = 'ğ';

// short b = (short)x;

// Console.WriteLine(b);

// short i = 312 ;

// char a = (char)i;

// Console.WriteLine(a);

// int deger = 97;
// char @char = (char)deger;
// Console.WriteLine(@char);

// checked
// {
//     short @short = 300;

//     byte @byte = (byte)@short;

//     Console.WriteLine(@byte);
// }

// byte b1 = 156;
// byte b2 = 3;
// int sonuc = b1 + b2;
// Console.WriteLine(b1+b2);

// int i = 5;
// i /=2;
// Console.WriteLine(i);

// string s1 = "adnan";
// string s2 = "Ziyagil";
// Console.WriteLine(s1!=s2);

// int i1 = 2;
// int i2 = 3;
// (i1!=i2);
// Console.WriteLine(i1==i2);

// int i1 = 100;
// int i2 = 200;

// bool max = (i1>i2) ? true : false ;
// Console.Write(max);

// string value = "Hello World!";
// string result = value ?? "null";
// Console.WriteLine(result);

// bool medeniHal= false;

// if (medeniHal == true)
// { 
//     Console.WriteLine("Evlilere Kampamya");
// }
// else
// {
//     Console.WriteLine('a');
// }

// object @object = true;

// Console.WriteLine(@object is null);
// Console.WriteLine(@object is Program);
// Console.WriteLine(@object is int);
// Console.WriteLine(@object is null);
// Console.WriteLine(@object is bool);


// "string @string ="abcd";
// string @string2 =null;
// Console.WriteLine(@string is null);
// Console.WriteLine(@string2 is null);"

// örnek : 

// object @object = 123;
// Type a = @object as Type ;

// object x = 123;
// int y = x as int;

// object x1 = 123;
// int? y1 = x1 as int?;

// string a = null;
// Console.WriteLine(a ?? "merhaba") ;
// Console.WriteLine(a ==null ? "merhaba": a);

// int? id = null;
// Console.WriteLine(id ??= 1);
// Console.WriteLine(id);


// int rakam = 8 ;

// switch (rakam)
// {
//     case 8 :
//     Console.WriteLine("adi mehmettir.");
//     break;

//     case "ayşe" :
//     Console.WriteLine("adi ayşedir");
//     break;

// //     case "hilmi" :
// //     Console.WriteLine("adi hilmidir");
// //     break;
// //     // default:
// //     // Console.WriteLine("adi mehmet , ayşe veya hilmi değildir.");
// //     // break;
// // }


// // int i = 10;

// // switch (i)
// // {
// //     case 5:
// //     Console.WriteLine(i*10);
// //     break;
// //     case 8:
// //     Console.WriteLine(i*8);
// //     break;
// //     case 10:
// //     goto case 5 ;
// //     default:
// //     goto case 5;
// // }

// // string mesaj ="";
// // switch (DateTime.Now.DayOfWeek)
// // {
// //     case DayOfWeek.Monday :
// //         mesaj = "bu gün pazartesi";
// //     break;
// //     case DayOfWeek.Tuesday :
// //         mesaj = "bu gün salı";
// //     break;
// //     case DayOfWeek.Wednesday:
// //         mesaj = "bu gün çarşamba";
// //     break;
// //     case DayOfWeek.Thursday :
// //         mesaj = "bu gün perşembe";
// //     break;
// //     case DayOfWeek.Friday :
// //         mesaj = "bu gün cuma";
// //     break;
// //     case DayOfWeek.Saturday :
// //         mesaj = "bu gün cumartesi";
// //     break;
// //     case DayOfWeek.Sunday :
// //         mesaj = "bu gün pazar";
// //     break;
// // }
// // Console.WriteLine(mesaj);

// // string mesaj1 =DateTime.Now.DayOfWeek switch
// // {
// //     DayOfWeek.Monday => "bu gün pazartesi",
// //     DayOfWeek.Tuesday => "bu gün salı",
// //     DayOfWeek.Wednesday=> "bu gün çarşamba",
// //     DayOfWeek.Thursday => "bu gün perşembe",
// //     DayOfWeek.Friday => "bu gün cuma",
// //     DayOfWeek.Saturday =>"bugün cumartesi",
// //     DayOfWeek.Sunday => "bugün pazar"
// // };

// // Console.WriteLine(mesaj1);


// // int i = 31;

// // if(i<30)
// // {
// //     Console.WriteLine("i değeri 30 dan küçüktür.");
// // }
// // else
// // {
// //     Console.WriteLine("i değeri 30 dan büyüktür.");
// // }

// // Console.WriteLine("1.ürün fiyatını yazınız");
// // int urunFiyat1 = int.Parse(Console.ReadLine());
// // Console.WriteLine("2.ürün fiyatını yazınız");
// // int urunFiyat2 = int.Parse(Console.ReadLine());

// // int toplam = urunFiyat1 + urunFiyat2;

// // if (toplam>= 200)
// // {
// //     urunFiyat2 = urunFiyat2 / 4;
// //     Console.WriteLine("Toplam Fiyat: " +toplam);
// // }

// // if (toplam <200)
// // {
// //     Console.WriteLine("Toplam Fiyat: " +toplam);
// // }

// // int number = 10;

// // switch (number)
// // {
// //     case 5:
// //         Console.WriteLine("Number is 5");
// //         break;

// //     case 10 when IsEven(number):
// //         Console.WriteLine("Number is 10 and even");
// //         break;

// //     case 10 when !IsEven(number):
// //         Console.WriteLine("Number is 10 and odd");
// //         break;

// //     default:
// //         Console.WriteLine("Number is neither 5 nor 10");
// //         break;
// // }

// // bool IsEven(int number)
// // {
// //     throw new NotImplementedException();
// // }

// // int satisTutari = 1000;

// // switch (satisTutari)
// // {
// //     case 100 when (true):
// //     Console.WriteLine("1");
// //     break;
// // }

// // int i = 10;
// // switch(i)
// // {
// //     case 5:
// //     Console.WriteLine(i*10);
// //     break;

// //     case 7:
// //     Console.WriteLine(i*7);
// //     break;

// //     case 10:
// //     goto case 5;

// //     default:
// //     goto case 5;
// // }

// string mesaj = DateTime.Now.DayOfWeek switch
// {
//     DayOfWeek.Monday => "bugün pazartesi",
//     DayOfWeek.Tuesday => "bugün salı",
//     DayOfWeek.Wednesday => "bugün çarşamba",
//     DayOfWeek.Thursday => "bugün perşembe",
//     DayOfWeek.Friday => "bugün cuma",
//     DayOfWeek.Saturday => "bugün cumartesi",
//     DayOfWeek.Sunday => "bugün pazar",
//     _ => throw new NotImplementedException(),
// };
// Console.WriteLine(mesaj);

// int a = 10;

// string isim = "";

//     switch(a)
//     {
//         case 5 :
//         isim = "hilmi";
//         break;
//         case 7 :
//         isim = "rıfkı";
//         break;
//         case 10:
//         isim = "cem";
//         break;
//     }
//     Console.WriteLine(isim);


// int i = 10;
//     string isim1 = i switch
//     {
//         5=>"hilmi",
//         7=>"rıfkı",
//         10=>"cem",
//         _ => throw new NotImplementedException(),
//     };
//     Console.WriteLine(isim1);


// int b = 10;
// string uzay = "";

// switch (b)
// {
//     case 5 when (true):
//     uzay = "hilmi";
//     break;
//     case 7 when(2==2):
//     uzay = "rıfkı";
//     break;
//     case 10 when(3==3):
//     uzay = "cem";
//     break;
// }
// Console.WriteLine(uzay);


// int i = 10;
//     string isim = i switch
//     {
//         5 when (false)=>"hilmi",
//         7 when (4==4)=>"rıfkı",
//         10 when (2==3)=>"cem",
//         10 when (3==3)=> "doğru",
//         _ => throw new NotImplementedException(),     /// bu satır default yerine geçiyor.
//     };
//     Console.WriteLine(isim);

// int a=10;
//     string isim = a switch
//     {
//         var b when a==5 && a%2==1 => "rıfkı",
//         var b when a==7 && a%2==0 => "rıfkı2",
//         var b => "hiçbiri",
//         // _ => throw new NotImplementedException(),
//     };
//     Console.WriteLine(isim);


// string adi = "nevin";
// int yasi = 32;
// string mesaj="";

// switch (adi , yasi)
// {
//     case ("hüseyin" , 20):
//     mesaj = "hoşgeldin Hüseyin";
//     break;
//     case("cansu",23):
//     mesaj="hoşegldin cansu";
//     break;
//     default:
//     mesaj="tanımlanamadı";
//     break;
// }
// Console.WriteLine(mesaj);

// string adi2 = "nevin";
// int yasi2 = 32;
// string mesaj2=(adi2 , yasi2) switch 
// {
//     ("hüseyin" , 20) => mesaj2 = "hoşgeldin Hüseyin",
//     ("nevin",32) =>    mesaj2="hoşegldin nevin",
//     _ => throw new NotImplementedException(),
// };
// Console.WriteLine(mesaj2);

// int s1 = 10;
// int s2 = 20;

// string mesaj =(s1,s2)
// switch 
// {
//     (5,10) => mesaj ="sayılar 5 ile 10",
//     (10,20) =>mesaj="sayılar 10 ile 20",
//     _ => throw new NotImplementedException(),
// };

// Console.WriteLine(mesaj);


// string adi = "nevin";
// int yasi = 32;
// string mesaj="";

// switch (adi , yasi)
// {
//     case ("hüseyin" , 20):
//     mesaj = "hoşgeldin Hüseyin";
//     break;
//     case("cansu",23):
//     mesaj="hoşegldin cansu";
//     break;
//     default:
//     mesaj="tanımlanamadı";
//     break;
// }
// Console.WriteLine(mesaj);

// string adi = "nevin";
// int yasi = 32;
// string mesaj=(adi , yasi)

// switch 
// {
//     ("hüseyin" , 20) => mesaj = "hoşgeldin Hüseyin",
//     ("cansu",23)=> mesaj="hoşegldin cansu",
//     _ => throw new NotImplementedException(),
// };
// Console.WriteLine(mesaj);


// string adi = "nevin";
// int yasi = 32;
// string mesaj=(adi , yasi)

// switch 
// {
//     var a when a.adi=="hüseyin" && a.yasi== 20 => mesaj = "hoşgeldin Hüseyin",
//     var a when a.adi=="cansu" && a.yasi==21 => mesaj="hoşheldin cansu",
//     var a when a.adi=="nevin" && a.yasi==32 => mesaj="hoşgeldin nevin",
//     _ => throw new NotImplementedException(),
// };
// Console.WriteLine(mesaj);

// int i = 10;
// if(i==10)
// {
//     Console.WriteLine("i değeri 10 dur");
//     Console.WriteLine("merhabalar");
// }
// else
// {
//     Console.WriteLine("i değeri 10 değildir.");
//     Console.WriteLine("merhabalar");
// }

// int sayi = 250;

// if (sayi>100 && sayi<=200)
// {
//     Console.WriteLine("100 ile 200 arasındadır.");
// }
// else if(sayi>200 && sayi<=300)
// {
//     Console.WriteLine("200 ile 300 arasındadır.");
// }
// else if (sayi>200 && sayi<=300)
// {
//     Console.WriteLine("200 ile 400 arasındadır.");
// }
// else
// {
//     Console.WriteLine("hata1");
// }
// if(true) Console.WriteLine("t1");

// if (true) Console.WriteLine("b1");
// Console.WriteLine("c1");


// Console.Write("Lütfen Birinci Ürünün Fiyatını Giriniz: ");
// int fiyat1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Lütfen ikinci Ürünün Fiyatını Giriniz: ");
// int fiyat2 = Convert.ToInt32(Console.ReadLine());

// int toplam1 = fiyat1 + fiyat2;
// int toplam2 = fiyat1 + fiyat2*3/4;
// if ((fiyat1+fiyat2)>200)
// {
//    Console.WriteLine(toplam2);
// }
// else
// {
//     Console.WriteLine(toplam1);


// string kullaniciAdi = "kullanıcı";
// string parola = "12345";

// Console.Write("Lütfen Kullanıcı adını giriniz : ");
// string? girilenKullaniciAdi = Console.ReadLine();

// Console.Write("lütfen parola giriniz : ");
// string? girilenParola= Console.ReadLine();

// if ( kullaniciAdi == girilenKullaniciAdi)
// {
//     if (parola==girilenParola)
//     {
//         Console.WriteLine("giriş başarılı");
//     }
//     else
//     {
//         Console.WriteLine("parola hatalı");
//     }
// }
// else
// {
//     Console.WriteLine("kullanıcı adı hatalı");
// }

// 3- döndürme :
//         int i1 = 100 , i2 = 200;
//         int max = (i1>i2) ? i1 : i2;
//         Console.Write(max);         ---> 200

// Console.Write("kullancı adı giriniz : ");
// string? kullaniciAdi = Console.ReadLine();

// Console.Write("parola giriniz : ");
// string? parola = Console.ReadLine();

// string mesaj = (kullaniciAdi=="kullanıcı") ? "kullanıcı adı doğrulandı" : "kullanıcı adı hatalı";
// Console.WriteLine(mesaj);
// string mesaj2 = (parola=="12345") ? "parola doğrulandı" : "parola hatalı";
// Console.WriteLine(mesaj2);

// Console.Write("1.sayıyı giriniz : ");
// int? sayi1 = int.Parse(Console.ReadLine());

// Console.Write("2.sayıyı giriniz : ");
// int? sayi2 = int.Parse(Console.ReadLine());

// Console.Write("işlem türünü yazınız : ");
// char islem = char.Parse(Console.ReadLine());

#region if yapısı ile
    // if (islem=='a')
//     Console.WriteLine(sayi1+sayi2);
// else if (islem=='b')
//     Console.WriteLine(sayi1-sayi2);
// else if(islem=='c')
//     Console.WriteLine(sayi1/sayi2);
// else if(islem=='d')
//     Console.WriteLine(sayi1*sayi2);
// else
//     Console.WriteLine("işlem türü yanlış seçildi.");
#endregion

#region switch ile
    // switch (islem)
    // {
    //     case 'a' :
    //     Console.WriteLine(sayi1+sayi2);
    //     break;
    //     case 'b' :
    //     Console.WriteLine(sayi1-sayi2);
    //     break;
    //     case 'c' :
    //     Console.WriteLine(sayi1*sayi2);
    //     break;
    //     case 'd' :
    //     Console.WriteLine(sayi1/sayi2);
    //     break;
    //     default:
    //     Console.WriteLine("işlem türü hatalı girildi");
    //     break;
    // }
#endregion

#region switc expression
// int? sonuc = islem switch
// {
//     'a'=> sayi1+sayi2 ,
//     'b'=> sayi1-sayi2 ,
//     'c'=> sayi1*sayi2 ,
//     'd'=> sayi1/sayi2 ,
//     _ => throw new NotImplementedException(),
// };
// Console.WriteLine(sonuc);
#endregion

#region if-elseif ile 
    // Console.Write("1.sayıyı giriniz : ");
    // int? sayi1 = int.Parse(Console.ReadLine());

    // Console.Write("2.sayıyı giriniz : ");
    // int? sayi2 = int.Parse(Console.ReadLine());

    // Console.Write("işlem türünü yazınız : ");
    // char islem = char.Parse(Console.ReadLine());

    // if (islem=='a')
    //     Console.WriteLine(sayi1+sayi2);
    // else if (islem=='b')
    //     Console.WriteLine(sayi1-sayi2);
    // else if(islem=='c')
    //     Console.WriteLine(sayi1/sayi2);
    // else if(islem=='d')
    //     Console.WriteLine(sayi1*sayi2);
    // else
    //     Console.WriteLine("işlem türü yanlış seçildi.");
#endregion

#region ternary operatörü ile
    // Console.Write("1.sayıyı giriniz : ");
    // int? sayi1 = int.Parse(Console.ReadLine());

    // Console.Write("2.sayıyı giriniz : ");
    // int? sayi2 = int.Parse(Console.ReadLine());

    // Console.Write("işlem türünü yazınız : ");
    // char islem = char.Parse(Console.ReadLine());

    // Console.WriteLine(islem=='a' ? sayi1+sayi2:(islem=='b'? sayi1-sayi2:(islem=='c'? sayi1*sayi2:(islem=='d'?sayi1/sayi2:"işlem başarısız"))));
#endregion

#region if ile
    // Console.Write("lütfen bir sayı giriniz : ");
    // int? sayi1 = int.Parse(Console.ReadLine());
    // if(sayi1!=10)
    // Console.WriteLine("sayı 10 değildir.");
#endregion

#region ternary operatörü ile
    // Console.Write("lütfen bir sayı giriniz : ");
    // int? sayi1 = int.Parse(Console.ReadLine());
    // Console.WriteLine(sayi1==10 ? "":  "sayı 10 değildir.");
#endregion


#region if yapısı ile
    
// #endregion

// object x = "ali";
// if(x is string)
// {
//     string? _x = x as string ;
// }

#endregion


// object x = "ali meral";

// if ( x is "ali meral")
//     Console.WriteLine("ali meral");
// else if (x is null)
//     Console.WriteLine("null");

// object rakam = 123;

// if (rakam is 124)
//     Console.WriteLine("rakam 124");
// else if (rakam is 123)
//     Console.WriteLine("rakam 123 dür");

// Console.Write("lütfen 1.sayıyı giriniz : ");
// int sayi1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("lütfen 2.sayıyı giriniz : ");
// int sayi2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("girilen sayıların toplamı : " + ((sayi1 + sayi2)));
// Console.WriteLine("girilen sayıların çarpımı : " + ((sayi1 * sayi2)));
// Console.WriteLine("girilen sayıların farkı : " + ((sayi1 - sayi2)));
// Console.WriteLine("girilen sayıların bölümü : " + ((sayi1 / sayi2)));


// try
// {
//     int s1=0,s2=5;
//     int a = s2/s1;
// }
// catch (Exception hata)
// {
//     Console.WriteLine("mesaj : " + hata.Data);
//     Console.WriteLine("mesaj : " + hata.HelpLink);
//     Console.WriteLine("mesaj : " + hata.HResult);
//     Console.WriteLine("mesaj : " + hata.InnerException);
//     Console.WriteLine("mesaj : " + hata.Message);
//     Console.WriteLine("mesaj : " + hata.Source);
//     Console.WriteLine("mesaj : " + hata.StackTrace);
//     Console.WriteLine("mesaj : " + hata.TargetSite);
// }

// string a = "r";

// try
// {
//     int s1 =0,s2=5;
//     int s3 = s2/s1;
// }
// catch (DivideByZeroException ex) when (a=="r")
// {
//    Console.WriteLine("mesaj : " + ex.Message);
// }
// catch (DivideByZeroException ex) when (a=="c")
// {
//     Console.WriteLine("mesaj : " + ex.Message);
// }



// try
// {
//     Console.Write("1.sayıyı giriniz : ");
//     int sayi1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("2.sayıyı giriniz : ");
//     int sayi2 = Convert.ToInt32(Console.ReadLine());  
//     Console.WriteLine("toplam : " +(sayi1+sayi2));
// }   
// catch (FormatException ex)
// {
//     Console.WriteLine("mesaj : " + ex.Message);
// }
// 1- ArgumentException
// 2- ArgumentNullException
// 3- ArgumentOutOfRangeException
// 4- DivideByZeroException)
// 5- FileNotFoundException
// 6- FormatException
// 7- IndexOutOfRangeException
// 8- InvalidOperationException
// 9- KeyNotFoundException
// 10- NotSupportedException
// 11- NullReferenceException
// 12- OverflowException
// 13- OutOfMemoryException
// 14- StackOverflowException
// 15- TimeoutException

// string x = "a";
//     try
//     {
//         int s1 = 0 , s2=5;
//         int a = s2/s1;
//     }
//     catch(DivideByZeroException ex) when (x=="a")
//     {
//         Console.WriteLine("mesaj1 : " +ex.Message);
//     }
//      catch(DivideByZeroException ex) when (x=="b")
//     {
//         Console.WriteLine("mesaj2 : " +ex.Message);
//     }
//      catch(DivideByZeroException ex)
//     {
//         Console.WriteLine("mesaj3 : " +ex.Message);
//     }
//     catch(FormatException ex)
//     {
//         Console.WriteLine("mesaj : " +ex.Message);
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine("mesaj : " +ex.Message);
//     }

// int toplam = 0;

// for ( int i=0 ; i < 41; i += 2)
// {
//     toplam += i;
// }
// Console.WriteLine(toplam);

Console.Write("Lütfen Bir Sayı Giriniz : ");
int sayi = Convert.ToInt32(Console.ReadLine());
int sonuc = 1;

for ( int i = 1 ; i<=sayi ; i++)
{
    sonuc *= i;
}
Console.WriteLine("Girilen sayının Faktöriyeli : " + sonuc);
