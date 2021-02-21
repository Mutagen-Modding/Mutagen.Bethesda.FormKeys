using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class VolumetricLighting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IVolumetricLightingGetter> Construct(uint id) => new FormLink<IVolumetricLightingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IVolumetricLightingGetter> VLDLC2Apocrypha => Construct(0x1e2d1);
            public static FormLink<IVolumetricLightingGetter> VLDLC2Ash01Sunset => Construct(0x1e2d0);
            public static FormLink<IVolumetricLightingGetter> VLDLC2Ash01Night => Construct(0x1e2cf);
            public static FormLink<IVolumetricLightingGetter> VLDLC2Ash01Sunrise => Construct(0x1e2ce);
            public static FormLink<IVolumetricLightingGetter> VLDLC2Ash01Day => Construct(0x1e2cd);
        }
    }
}
