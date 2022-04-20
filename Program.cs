using System;

namespace FİBONACCİ
{
    class Program
    {
        static void Main(string[] args)
        {

            int bir = 0, iki = 1, uc;
            int kacincieleman;
            Console.WriteLine("eleman say giriniz:");
            kacincieleman = int.Parse(Console.ReadLine());


            if (kacincieleman > 0)
            {
                if (kacincieleman == 1)
                {
                    Console.WriteLine(bir);
                }
                else
                {


                    for (int i = 0; i < kacincieleman - 2; i++)
                    {

                        uc = bir + iki;
                        bir = iki;
                        iki = uc;
                        Console.WriteLine(uc);

                    }

                    bir = 0;
                    iki = 1;

                }
            }



            else
            {

                Console.WriteLine("o dan büyük deger giriniz.");

            }
        }
    }
}
