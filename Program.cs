using System;

namespace oop_6115261031_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            Img i1 = new Img("sea", "500","300", "321112", "JPG");
            Album a1 = new Album("001", "view", "321112", "img",  i1);
            Console.WriteLine(a1.ToString());
            Img i2 = new Img("waterfall", "650", "700", "112111", "JPG");
            Album a2 = new Album("002", "view", "112111", "img", i2);
            Console.WriteLine(a2.ToString());
        }
    }
}