using System;

namespace _20170809_4Con_ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[20];
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write((i+1)+". ismi giriniz : ");
                isimler[i] = Console.ReadLine();
            }

            Console.WriteLine("-----------------------------------------------");

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            

            /*
             * foreach döngüsü
             * 1. elemandan son elemana doğru sıralı olarak gider.
             * sadece ileri doğru okuyabilir. tersine okuyamaz
             * readonly özelliği vardır. döngü değişkeni sadece okunuz. içine değer atanamaz.
             * for döngüsüne göre daha yeteneksizdir. 
             */

            foreach (string item in isimler)
            {
                //eleman = "a";  //foreach değişkene değer atılamaz.
                Console.WriteLine(item);
            }

            Console.Read();

        }
    }
}
