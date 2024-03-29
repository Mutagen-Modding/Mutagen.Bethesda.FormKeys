// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static partial class AcousticSpace
    {
        private static FormLink<IAcousticSpaceGetter> Construct(uint id) => new FormLink<IAcousticSpaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAcousticSpaceGetter> DLC04IntBottlingPlantMedium => Construct(0x57122);
        public static FormLink<IAcousticSpaceGetter> DLC04IntArcadeRoomA => Construct(0x56b84);
        public static FormLink<IAcousticSpaceGetter> DLC04IntFunHouseTunnels => Construct(0x53507);
        public static FormLink<IAcousticSpaceGetter> DLC04IntJunkyardUFO => Construct(0x51c81);
        public static FormLink<IAcousticSpaceGetter> DLC04QSTDLC04GZVaultTec => Construct(0x4cbb7);
        public static FormLink<IAcousticSpaceGetter> DLC04Monorail => Construct(0x4ada4);
    }
}
