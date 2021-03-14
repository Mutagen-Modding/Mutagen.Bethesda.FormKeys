using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class VolumetricLighting
        {
            private static FormLink<IVolumetricLightingGetter> Construct(uint id) => new FormLink<IVolumetricLightingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IVolumetricLightingGetter> VLSoulCairn => Construct(0x14cf8);
        }
    }
}
