// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static class ImageSpace
    {
        private static FormLink<IImageSpaceGetter> Construct(uint id) => new FormLink<IImageSpaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImageSpaceGetter> DLC04_ClearDAWN_L => Construct(0x4f579);
        public static FormLink<IImageSpaceGetter> DLC04_ClearDAY => Construct(0x4f578);
        public static FormLink<IImageSpaceGetter> DLC04_ClearDUSK_E => Construct(0x4f577);
        public static FormLink<IImageSpaceGetter> DLC04_ClearDUSK => Construct(0x4f576);
        public static FormLink<IImageSpaceGetter> DLC04_ClearDUSK_L => Construct(0x4f575);
        public static FormLink<IImageSpaceGetter> DLC04_ClearNIGHT => Construct(0x4f574);
        public static FormLink<IImageSpaceGetter> DLC04ImageSpaceInterior => Construct(0x42fc4);
    }
}
