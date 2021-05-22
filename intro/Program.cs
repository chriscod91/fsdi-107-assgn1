using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.Exc1();
            

            float res = p.Sum(123.334f, 345.123f);
            Console.WriteLine(res);

            string a = p.GetTheAnswer();
            Console.WriteLine("the answer to life, universe and everything is:" + a);


            //get the most expensive of 3 products
            decimal exp = p.GetMostExpensive(0m, 12m, -3m);
            Console.WriteLine("the priciest one is" + exp);

        }

        decimal GetMostExpensive(decimal m1, decimal m2, decimal m3)
        {
            return Math.Max(Math.Max(1, -5), -3);
        }

        string GetTheAnswer()
        {
            return "512";
        }
        float Sum(float n1, float n2)
        {
            return n1 + n2;
        }
        void Exc1()
        {
            // print numbers from 1 to 14
            // exept 7 and 13
            // $$ means and
            //! means not
            for (int i = 1; i <= 14; i++)
            {
                if (i != 7 && i != 13)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // return_type name (parametres)

        string SayHello()
        {
            Console.WriteLine("hello there!");
            int age = 17;

            if (age > 18)
            {
                return "hi!";
            }
            return "";
        }







    }
}
