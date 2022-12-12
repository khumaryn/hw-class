using System;

namespace classtask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bize verilmis ad soyadi birlesdirsin
            Console.WriteLine("adi ve soyadi daxil edin");
            string name = Console.ReadLine();
            string surname= Console.ReadLine();
            var fullname = adsoyad(name,  surname);

                Console.WriteLine(fullname);

        }
        static string adsoyad(string name, string surname)
        {
            var adsoyad = name + " " + surname;
            return adsoyad;
        }


    }
}
