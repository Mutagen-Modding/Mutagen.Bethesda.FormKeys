using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class LeveledCreature
        {
            private static FormLink<ILeveledCreatureGetter> Construct(uint id) => new FormLink<ILeveledCreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledCreatureGetter> DL9LLVeteran100 => Construct(0xd8e);
            public static FormLink<ILeveledCreatureGetter> DL9LLSoldier100 => Construct(0x1afc);
            public static FormLink<ILeveledCreatureGetter> DL9LLLaborersALL100 => Construct(0x2752);
            public static FormLink<ILeveledCreatureGetter> DL9LLSoldierNoPackage100 => Construct(0x5543);
            public static FormLink<ILeveledCreatureGetter> DL9LLDrothmeri100 => Construct(0xd88);
            public static FormLink<ILeveledCreatureGetter> DL9LLDrothmeri50 => Construct(0x2164);
            public static FormLink<ILeveledCreatureGetter> DL9LLnoVeterans50 => Construct(0x2980);
            public static FormLink<ILeveledCreatureGetter> DL9LLnoVeterans100 => Construct(0xd8d);
        }
    }
}