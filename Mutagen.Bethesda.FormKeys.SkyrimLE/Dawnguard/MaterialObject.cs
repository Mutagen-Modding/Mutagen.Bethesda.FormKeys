using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class MaterialObject
        {
            private static FormLink<IMaterialObjectGetter> Construct(uint id) => new FormLink<IMaterialObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMaterialObjectGetter> DLC1SnowMaterialGlacierINT1P => Construct(0x13816);
            public static FormLink<IMaterialObjectGetter> DLC1SnowMaterialIceWall => Construct(0xc115);
        }
    }
}
