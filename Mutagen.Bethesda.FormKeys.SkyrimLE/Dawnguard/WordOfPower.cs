using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class WordOfPower
        {
            private static FormLink<IWordOfPowerGetter> Construct(uint id) => new FormLink<IWordOfPowerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWordOfPowerGetter> DLC1UndeadSummon3 => Construct(0x1a164);
            public static FormLink<IWordOfPowerGetter> DLC1UndeadSummon2 => Construct(0x1a163);
            public static FormLink<IWordOfPowerGetter> DLC1UndeadSummon1 => Construct(0x1a162);
            public static FormLink<IWordOfPowerGetter> DLC1DrainVitality1Gaan => Construct(0x8a65);
            public static FormLink<IWordOfPowerGetter> DLC1DrainVitality2Lah => Construct(0x8a64);
            public static FormLink<IWordOfPowerGetter> DLC1DrainVitality3Haas => Construct(0x8a63);
            public static FormLink<IWordOfPowerGetter> DLC1SoulTearing3Zol => Construct(0x7cb9);
            public static FormLink<IWordOfPowerGetter> DLC1SoulTearing2Vaaz => Construct(0x7cb8);
            public static FormLink<IWordOfPowerGetter> DLC1SoulTearing1Rii => Construct(0x7cb7);
            public static FormLink<IWordOfPowerGetter> DLC1DragonSummon3Viir => Construct(0x30d7);
            public static FormLink<IWordOfPowerGetter> DLC1DragonSummon2Neh => Construct(0x30d6);
            public static FormLink<IWordOfPowerGetter> DLC1DragonSummon1Dur => Construct(0x30d4);
        }
    }
}
