namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Ingredient
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1MountainFlower01Yellow => ModKey.MakeFormKey(0x2a78);
            public static FormKey DLC01PoisonBloom => ModKey.MakeFormKey(0x185fb);
            public static FormKey DLC01ChaurusHunterAntennae => ModKey.MakeFormKey(0x183b7);
            public static FormKey DLC01GlowPlant01Ingredient => ModKey.MakeFormKey(0xb097);
            public static FormKey DLC01MothWingAncestor => ModKey.MakeFormKey(0x59ba);
        }
    }
}
