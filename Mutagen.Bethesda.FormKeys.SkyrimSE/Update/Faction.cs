namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Faction
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey PetFramework_PetFollowingFaction => ModKey.MakeFormKey(0x2f1d);
            public static FormKey PetFramework_PetFaction => ModKey.MakeFormKey(0x2f1b);
            public static FormKey CR08ExclusionFaction => ModKey.MakeFormKey(0x944);
        }
    }
}
