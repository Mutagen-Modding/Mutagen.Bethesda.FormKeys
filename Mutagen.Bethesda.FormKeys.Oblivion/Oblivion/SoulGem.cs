using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class SoulGem
        {
            private static FormLink<ISoulGemGetter> Construct(uint id) => new FormLink<ISoulGemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoulGemGetter> SE38MuseumItem7 => Construct(0x81e62);
            public static FormLink<ISoulGemGetter> SE38Item7 => Construct(0x81e60);
            public static FormLink<ISoulGemGetter> Mg17BlackSoulGemFilled => Construct(0xc6988);
            public static FormLink<ISoulGemGetter> MG02BlackSoulGem => Construct(0x3c7fc);
            public static FormLink<ISoulGemGetter> BlackSoulGemFilled => Construct(0x382e0);
            public static FormLink<ISoulGemGetter> SoulGem5Grand5GrandSoul => Construct(0x382df);
            public static FormLink<ISoulGemGetter> SoulGem5Grand4GreaterSoul => Construct(0x382de);
            public static FormLink<ISoulGemGetter> SoulGem5Grand3CommonSoul => Construct(0x382dd);
            public static FormLink<ISoulGemGetter> SoulGem5Grand2LesserSoul => Construct(0x382dc);
            public static FormLink<ISoulGemGetter> SoulGem5Grand1PettySoul => Construct(0x382db);
            public static FormLink<ISoulGemGetter> SoulGem4Greater4GreaterSoul => Construct(0x382da);
            public static FormLink<ISoulGemGetter> SoulGem4Greater3CommonSoul => Construct(0x382d9);
            public static FormLink<ISoulGemGetter> SoulGem4Greater2LesserSoul => Construct(0x382d8);
            public static FormLink<ISoulGemGetter> SoulGem4Greater1PettySoul => Construct(0x382d7);
            public static FormLink<ISoulGemGetter> SoulGem3Common3CommonSoul => Construct(0x382d6);
            public static FormLink<ISoulGemGetter> SoulGem3Common2LesserSoul => Construct(0x382d5);
            public static FormLink<ISoulGemGetter> SoulGem3Common1PettySoul => Construct(0x382d4);
            public static FormLink<ISoulGemGetter> SoulGem2Lesser2LesserSoul => Construct(0x382d3);
            public static FormLink<ISoulGemGetter> SoulGem2Lesser1PettySoul => Construct(0x382d2);
            public static FormLink<ISoulGemGetter> SoulGem1Petty1PettySoul => Construct(0x382d1);
            public static FormLink<ISoulGemGetter> AzurasStar => Construct(0x193);
            public static FormLink<ISoulGemGetter> BlackSoulGem => Construct(0x192);
            public static FormLink<ISoulGemGetter> SoulGemEmpty5Grand => Construct(0x15b8e);
            public static FormLink<ISoulGemGetter> SoulGemEmpty4Greater => Construct(0x15b8c);
            public static FormLink<ISoulGemGetter> SoulGemEmpty3Common => Construct(0x15b8b);
            public static FormLink<ISoulGemGetter> BlackSoulGemGrand => Construct(0x1ec14);
            public static FormLink<ISoulGemGetter> Mg17BlackSoulGem => Construct(0x15208);
            public static FormLink<ISoulGemGetter> SoulGemEmpty2Lesser => Construct(0x23d69);
            public static FormLink<ISoulGemGetter> SoulGemEmpty1Petty => Construct(0x23d67);
        }
    }
}