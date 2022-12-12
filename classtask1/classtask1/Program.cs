using System;

namespace classtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ededi 1 vahid artiran program
            Console.WriteLine("ededi daxil edin");
            int num=Convert.ToInt32(Console.ReadLine());
            var resultartim = artim(num);
            Console.WriteLine(resultartim);
        }
        static int artim(int num)
        {
            num++;
            return num;
        }
    }
}
