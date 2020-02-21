using src_HeroopQuest.GameClasses;
using System;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Held held1 = new Held(HeldType.Barbaar, "Conan");
            Held held2 = new Held(HeldType.Tovenaar, "Gandalf");

            Console.WriteLine(held1.AanvalDobbelsteen);
            Console.WriteLine(held2.HeldType);
        }
    }
}
