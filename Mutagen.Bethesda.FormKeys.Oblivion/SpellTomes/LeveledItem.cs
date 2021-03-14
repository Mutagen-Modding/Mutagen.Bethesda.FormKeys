using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class LeveledItem
        {
            private static FormLink<ILeveledItemGetter> Construct(uint id) => new FormLink<ILeveledItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes3Journeyman100 => Construct(0x11dd);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes4Expert100 => Construct(0x11de);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes1Novice100 => Construct(0x11db);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes2Apprentice100 => Construct(0x11dc);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes1NoviceAlteration100 => Construct(0x2852);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes1NoviceConjuration100 => Construct(0x2853);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes1NoviceDestruction100 => Construct(0x2854);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes1NoviceMysticism100 => Construct(0x2855);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes1NoviceRestoration100 => Construct(0x2856);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes1NoviceIllusion100 => Construct(0x2857);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes2ApprenticeRestoration100 => Construct(0x2d3e);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes3JourneymanRestoration100 => Construct(0x2d3f);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes4ExpertRestoration100 => Construct(0x2d41);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes2ApprenticeAlteration100 => Construct(0x2d42);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes3JourneymanAlteration100 => Construct(0x2d43);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes4ExpertAlteration100 => Construct(0x2d44);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes2ApprenticeConjuration100 => Construct(0x2d45);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes3JourneymanConjuration100 => Construct(0x2d46);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes4ExpertConjuration100 => Construct(0x2d47);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes2ApprenticeMysticism100 => Construct(0x2d48);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes3JourneymanMysticism100 => Construct(0x2d49);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes4ExpertMysticism100 => Construct(0x2d4a);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes2ApprenticeIllusion100 => Construct(0x2d4b);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes3JourneymanIllusion100 => Construct(0x2d4c);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes4ExpertIllusion100 => Construct(0x2d4d);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes2ApprenticeDestruction100 => Construct(0x2d4e);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes3JourneymanDestruction100 => Construct(0x2d4f);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes4ExpertDestruction100 => Construct(0x2d50);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes1Novice50 => Construct(0x40e9);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes2Apprentice50 => Construct(0x40ea);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes3Journeyman50 => Construct(0x40eb);
            public static FormLink<ILeveledItemGetter> LL0DLCSpellTomes4Expert50 => Construct(0x40ec);
            public static FormLink<ILeveledItemGetter> LL2DLCSpellTomesNPCLvl100 => Construct(0x40ed);
        }
    }
}