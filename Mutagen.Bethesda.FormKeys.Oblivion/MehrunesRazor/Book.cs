using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Book
        {
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> DL9StewardNote => Construct(0x5fae);
            public static FormLink<IBookGetter> DL9ApprenticeNote => Construct(0x1a62);
            public static FormLink<IBookGetter> DL9TomeNefarivigum => Construct(0x1a76);
            public static FormLink<IBookGetter> DL9TransmuteGoldSCROLL => Construct(0x14ba);
            public static FormLink<IBookGetter> DL9FinalLetter => Construct(0xd81);
            public static FormLink<IBookGetter> DL9StewardRegistry => Construct(0x1995);
            public static FormLink<IBookGetter> DL9DrathonJournal => Construct(0x148a);
            public static FormLink<IBookGetter> DL9NefarivigumLore => Construct(0x14a2);
            public static FormLink<IBookGetter> DL9receipt => Construct(0x14a7);
            public static FormLink<IBookGetter> DL9StewardDiary => Construct(0x1582);
            public static FormLink<IBookGetter> DL9MoragTongWrit => Construct(0x2532);
            public static FormLink<IBookGetter> DL9JailorNote => Construct(0x1ac0);
            public static FormLink<IBookGetter> DL9ApprenticeLetter => Construct(0x1a60);
        }
    }
}
