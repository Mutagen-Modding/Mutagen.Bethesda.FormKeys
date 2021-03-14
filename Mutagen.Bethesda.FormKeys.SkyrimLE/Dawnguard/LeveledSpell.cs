using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class LeveledSpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<ILeveledSpellGetter> Construct(uint id) => new FormLink<ILeveledSpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledSpellGetter> DLC1RevenantLeftHand50 => Construct(0x10f6c);
            public static FormLink<ILeveledSpellGetter> DLC1ReanimateCorpseLeftHand50 => Construct(0x10f6b);
            public static FormLink<ILeveledSpellGetter> DLC1RaiseZombieLeftHand50 => Construct(0x10f6a);
        }
    }
}
