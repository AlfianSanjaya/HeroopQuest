using src_HeroopQuest.GameClasses;
using src_HeroopQuest.Properties;
using System;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Resources.barbaarTekst);
            Held held1 = new Held(HeldType.Barbaar, "Conan");
            Held held2 = new Held(HeldType.Tovenaar, "Gandalf");

            Console.WriteLine(held1.AanvalDobbelsteen);
            Console.WriteLine(held2.HeldType);

            held1.ToonFiche();
        }
    }
}
