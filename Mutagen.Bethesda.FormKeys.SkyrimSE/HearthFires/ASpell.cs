using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> BYOHVampireSleepRested => Construct(0xc35);
            public static FormLink<IASpellGetter> BYOHAdoptionSleepAbilityMale => Construct(0x2f54);
            public static FormLink<IASpellGetter> BYOHAdoptionSleepAbilityFemale => Construct(0x4292);
        }
    }
}
