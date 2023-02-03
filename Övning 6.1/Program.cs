using System;
namespace Övning_6._1
{
    class program
    {
        static void Main(string[] arg)
        {
            SkrivTalKvadrat(3);
            SkrivTalKvadrat(8);
            SkrivTalKvadrat(15);

        }

        static void SkrivTalKvadrat(int tal)
        {
            Console.WriteLine($"Talet{tal} i kvadrat är : {tal * tal}");
        }
    }
}