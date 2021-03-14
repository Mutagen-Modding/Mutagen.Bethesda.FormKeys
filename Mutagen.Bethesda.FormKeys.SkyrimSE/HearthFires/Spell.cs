using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Spell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> BYOHVampireSleepRested => Construct(0xc35);
            public static FormLink<ISpellGetter> BYOHAdoptionSleepAbilityMale => Construct(0x2f54);
            public static FormLink<ISpellGetter> BYOHAdoptionSleepAbilityFemale => Construct(0x4292);
        }
    }
}
