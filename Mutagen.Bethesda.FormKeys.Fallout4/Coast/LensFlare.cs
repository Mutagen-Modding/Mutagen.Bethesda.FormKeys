// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static class LensFlare
    {
        private static FormLink<ILensFlareGetter> Construct(uint id) => new FormLink<ILensFlareGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILensFlareGetter> DLC03RedEyeLampFlare => Construct(0x56a20);
        public static FormLink<ILensFlareGetter> DLC03OilLampFlare02 => Construct(0x48c20);
        public static FormLink<ILensFlareGetter> DLC03AnglerLampFlare => Construct(0x4872a);
        public static FormLink<ILensFlareGetter> DLC03SubBaseExtNukeFlare => Construct(0x38043);
        public static FormLink<ILensFlareGetter> DLC03SubMissileNukeFlash => Construct(0x2f310);
        public static FormLink<ILensFlareGetter> DLC03OilLampFlare => Construct(0x1a3f8);
        public static FormLink<ILensFlareGetter> DLC03MistySunFlare => Construct(0x74c7);
    }
}
