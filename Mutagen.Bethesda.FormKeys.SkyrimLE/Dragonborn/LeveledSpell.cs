using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class LeveledSpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<ILeveledSpellGetter> Construct(uint id) => new FormLink<ILeveledSpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledSpellGetter> DLC2ZahkriisosShockSpell => Construct(0x3d474);
            public static FormLink<ILeveledSpellGetter> DLC2LSpellConjureLeftHand => Construct(0x279ea);
            public static FormLink<ILeveledSpellGetter> DLC2MiraakLSpells => Construct(0x23f6b);
            public static FormLink<ILeveledSpellGetter> DLC2LSpellBanditBoss05FireFrostShock => Construct(0x1e8b0);
            public static FormLink<ILeveledSpellGetter> DLC2LSpellBanditBoss03FireFrostShock => Construct(0x1e8af);
            public static FormLink<ILeveledSpellGetter> DLC2LSpellBanditBoss021FireFrostShock => Construct(0x1e8ad);
        }
    }
}
