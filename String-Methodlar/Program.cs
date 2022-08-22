using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper ToLower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba!")); //sonuna ekler

            //Compare CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0 1 -1
            Console.WriteLine(String.Compare(degisken,degisken2,true)); //büyük küçük harf duyarsız
            Console.WriteLine(String.Compare(degisken,degisken2,false)); //büyük küçük harf duyarlı

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Zikriye"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //PadLeft PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //degisken2 nin solundan 30 karaktere tamamla
            Console.WriteLine(degisken + degisken2.PadRight(30,'*')); // ""      sağından "    "       * ile tamamla
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10'uncu indexten itibaren (10 dahil) kaldır/sil
            Console.WriteLine(degisken.Remove(5,3)); //5'inci indexten itibaren (5 dahil) 3 karakter kaldır/sil
            Console.WriteLine(degisken.Remove(0,1));



            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(' ', '*'));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

        }
    }
}
