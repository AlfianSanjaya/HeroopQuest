using src_HeroopQuest.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType { Barbaar, Dwerg, Elf, Tovenaar }
    class Held
    {
        public Held(HeldType type, string naam)
        {
            Naam = naam;
            HeldType = type;
            switch (type)
            {
                case HeldType.Barbaar:
                    AanvalDobbelsteen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    Beschrijving = Resources.barbaarTekst;
                    break;
                case HeldType.Dwerg:
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    Beschrijving = Resources.dwergTekst;
                    break;
                case HeldType.Elf:
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    Beschrijving = Resources.elfTekst;
                    break;
                case HeldType.Tovenaar:
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    AanvalDobbelsteen = 1;
                    Beschrijving = Resources.tovenaarTekst;
                    break;
                default:
                    break;
            }
            HuidigIntelligentie = MaxIntelligentie;
            HuidigLichaam = MaxLichaam;
        }

        public string Naam { get; set; }
        public string Beschrijving { get; private set; }
        public int MaxIntelligentie { get; private set; }
        public int MaxLichaam { get; private set; }
        public int HuidigIntelligentie { get; set; }
        public int HuidigLichaam { get; set; }
        public HeldType HeldType { get; private set; }
        public int AanvalDobbelsteen { get; private set; } = 2;
        public int VerdedigingDobbelsteen { get; private set; } = 2;
        public int LoopDobbelsteen { get; private set; } = 2;

        public void ToonFiche()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t~~~~~~~~~~{Naam} de {HeldType}~~~~~~~~~~" +
                $"\n\t{Beschrijving}");
            Console.WriteLine($"\tIntelligentie: {HuidigIntelligentie}/{MaxIntelligentie}");
            Console.WriteLine($"\tLichaamspunten: {HuidigLichaam}/{MaxLichaam}");
            Console.ResetColor();
        }
    }
}
