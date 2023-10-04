// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Reflection.Metadata;

// #region A operasyonu
//     Console.WriteLine("Hello, World!");
//     Console.WriteLine(typeof(bool).IsPrimitive);
//     Console.WriteLine(typeof(char).IsPrimitive);
//     Console.WriteLine(typeof(sbyte).IsPrimitive);
//     Console.WriteLine(typeof(byte).IsPrimitive);
//     Console.WriteLine(typeof(short).IsPrimitive);
//     Console.WriteLine(typeof(ushort).IsPrimitive);
//     Console.WriteLine(typeof(int).IsPrimitive);
//     Console.WriteLine(typeof(uint).IsPrimitive);
//     Console.WriteLine(typeof(long).IsPrimitive);
//     Console.WriteLine(typeof(ulong).IsPrimitive);
//     Console.WriteLine(typeof(float).IsPrimitive);
//     Console.WriteLine(typeof(double).IsPrimitive);
//     Console.WriteLine(typeof(decimal).IsPrimitive);
// #endregion



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

// string y = "true";

// if (bool.Parse(y) == true) ;
//     Console.WriteLine("yes")
// else;
// {
//     Console.WriteLine("no")
// };

// dynamic x = "12";

// Console.WriteLine(short.Parse(x)*2);

// var a = "9";

// Console.WriteLine(double.Parse(a)*2);


// object a = "7";

// string b = (string)a;

// Console.WriteLine(int.Parse(b)*3);

// string @string = "2";


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


// int x = 300;

// // double y = x;   // herhangi bir veri kaybına yol açmayacağını bildiği için compiler bunu otomatik olarak yaptı. implicit type convertion


// // byte z = x;   // explicit tür dönüşümü olacağı için şu şekilde hata verdi. Cannot implicitly convert type 'int' to 'byte'.An explicit conversion exists (are you missing a cast?)CS0266

// byte w = (byte)x; // () cast operatörü ile bu dönüşümü explicit olarak yaptık. 
// Console.WriteLine(w);


// bool c = false;

// decimal d = Convert.ToDecimal(c);

// Console.WriteLine(d);

int i = 1;

bool b = Convert.ToBoolean(i);

Console.WriteLine(b);