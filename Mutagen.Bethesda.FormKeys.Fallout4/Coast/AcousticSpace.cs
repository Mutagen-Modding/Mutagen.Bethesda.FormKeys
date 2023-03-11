// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static class AcousticSpace
    {
        private static FormLink<IAcousticSpaceGetter> Construct(uint id) => new FormLink<IAcousticSpaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAcousticSpaceGetter> DLC03ExtShipMetal => Construct(0x5db18);
        public static FormLink<IAcousticSpaceGetter> DLC03IntCaveSmall => Construct(0x5d800);
        public static FormLink<IAcousticSpaceGetter> DLC03IntAcadiaServerA => Construct(0x5d7b0);
        public static FormLink<IAcousticSpaceGetter> DLC03IntAcadiaMedium => Construct(0x5d7af);
        public static FormLink<IAcousticSpaceGetter> DLC03IntIndustrialNucleusRooms => Construct(0x4d2e1);
        public static FormLink<IAcousticSpaceGetter> DLC03IntIndustrialNucleusLarge => Construct(0x4d2d9);
    }
}