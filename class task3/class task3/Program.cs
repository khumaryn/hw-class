using System;

namespace class_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yazilani int-e cevirmek
            Console.WriteLine("ededi daxil edin");
            string num = Console.ReadLine();
            resultnum = int_ecevirmek(number);
            Console.WriteLine(num);


            
        }
        static int int_ecevirmek(int number)
        {
            string num = Console.ReadLine();
            return Convert.ToInt32 (num);
        }
    }     
}
