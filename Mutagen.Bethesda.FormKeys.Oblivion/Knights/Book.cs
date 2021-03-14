using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Book
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> ND05ConjurerNote2 => Construct(0xed0);
            public static FormLink<IBookGetter> ND05ConjurerNote1 => Construct(0xed1);
            public static FormLink<IBookGetter> NDBook3ValuableKnightsoftheNine => Construct(0xed2);
            public static FormLink<IBookGetter> NDBook4RareAdabala => Construct(0xed3);
            public static FormLink<IBookGetter> NDBook3ValuableShezarr => Construct(0xed4);
            public static FormLink<IBookGetter> NDBook2ReligiousSongofPelinalV8 => Construct(0xed5);
            public static FormLink<IBookGetter> NDBook2ReligiousSongofPelinalV7 => Construct(0xed6);
            public static FormLink<IBookGetter> NDBook2ReligiousSongofPelinalV6 => Construct(0xed7);
            public static FormLink<IBookGetter> NDBook2ReligiousSongofPelinalV5 => Construct(0xed8);
            public static FormLink<IBookGetter> NDBook2ReligiousSongofPelinalV4 => Construct(0xed9);
            public static FormLink<IBookGetter> NDBook2ReligiousSongofPelinalV3 => Construct(0xeda);
            public static FormLink<IBookGetter> NDBook2ReligiousSongofPelinalV2 => Construct(0xedb);
            public static FormLink<IBookGetter> NDBook2ReligiousSongofPelinalV1 => Construct(0xedc);
            public static FormLink<IBookGetter> NDWayshrineMap => Construct(0xedd);
            public static FormLink<IBookGetter> ND01SirAmielsJournal => Construct(0xede);
        }
    }
}
