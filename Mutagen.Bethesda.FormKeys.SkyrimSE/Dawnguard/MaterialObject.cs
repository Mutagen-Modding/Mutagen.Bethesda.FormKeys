using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class MaterialObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IMaterialObjectGetter> Construct(uint id) => new FormLink<IMaterialObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMaterialObjectGetter> DLC1SnowMaterialGlacierINT1P => Construct(0x13816);
            public static FormLink<IMaterialObjectGetter> DLC1SnowMaterialIceWall => Construct(0xc115);
        }
    }
}
