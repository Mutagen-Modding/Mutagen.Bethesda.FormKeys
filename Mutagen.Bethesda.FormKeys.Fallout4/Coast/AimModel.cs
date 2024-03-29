// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static partial class AimModel
    {
        private static FormLink<IAimModelGetter> Construct(uint id) => new FormLink<IAimModelGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAimModelGetter> DLC03_V118PaintBallAimModel => Construct(0x5d75a);
        public static FormLink<IAimModelGetter> DLC03_ThrowingCaltropAM => Construct(0x54071);
        public static FormLink<IAimModelGetter> DLC03_LeverGun_AM => Construct(0x49ccc);
        public static FormLink<IAimModelGetter> DLC03_RadiumRifle_AM => Construct(0x489d7);
        public static FormLink<IAimModelGetter> DLC03_HarpoonGun_AM => Construct(0x10b83);
    }
}
