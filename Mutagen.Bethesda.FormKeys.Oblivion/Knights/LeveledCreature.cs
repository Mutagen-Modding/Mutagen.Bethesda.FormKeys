using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class LeveledCreature
        {
            private static FormLink<ILeveledCreatureGetter> Construct(uint id) => new FormLink<ILeveledCreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledCreatureGetter> NDLL1UmarilSpiritLvl100 => Construct(0xfb5);
            public static FormLink<ILeveledCreatureGetter> ND10LLAuroranLieutenant => Construct(0xfb6);
            public static FormLink<ILeveledCreatureGetter> ND10LLAuroranOrbStay => Construct(0xfb7);
            public static FormLink<ILeveledCreatureGetter> ND10LLAuroranOrbRun => Construct(0xfb8);
            public static FormLink<ILeveledCreatureGetter> ND10LLAuroranBattle => Construct(0xfb9);
            public static FormLink<ILeveledCreatureGetter> ND08LL1AuroranLvl100 => Construct(0xfba);
            public static FormLink<ILeveledCreatureGetter> ND04LL1AuroranLvl100 => Construct(0xfbb);
            public static FormLink<ILeveledCreatureGetter> NDLL1UmarilRealLvl100 => Construct(0xfbc);
            public static FormLink<ILeveledCreatureGetter> NDLL1AuroranLvl100 => Construct(0xfbd);
            public static FormLink<ILeveledCreatureGetter> NDLL1Auroran100 => Construct(0xfbe);
        }
    }
}
