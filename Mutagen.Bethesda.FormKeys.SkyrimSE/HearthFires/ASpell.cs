namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHVampireSleepRested => ModKey.MakeFormKey(0xc35);
            public static FormKey BYOHAdoptionSleepAbilityMale => ModKey.MakeFormKey(0x2f54);
            public static FormKey BYOHAdoptionSleepAbilityFemale => ModKey.MakeFormKey(0x4292);
        }
    }
}
