namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class MaterialObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1SnowMaterialGlacierINT1P => ModKey.MakeFormKey(0x13816);
            public static FormKey DLC1SnowMaterialIceWall => ModKey.MakeFormKey(0xc115);
        }
    }
}
