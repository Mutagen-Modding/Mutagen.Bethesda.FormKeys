// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Update
{
    public static partial class ImageSpace
    {
        private static FormLink<IImageSpaceGetter> Construct(uint id) => new FormLink<IImageSpaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImageSpaceGetter> ISKarthspireFogNIGHT => Construct(0x1bd1);
        public static FormLink<IImageSpaceGetter> ISKarthspireFogDUSK => Construct(0x1bd0);
        public static FormLink<IImageSpaceGetter> ISKarthspireFogDAY => Construct(0x1bcf);
        public static FormLink<IImageSpaceGetter> ISKarthspireFogDAWN => Construct(0x1bce);
        public static FormLink<IImageSpaceGetter> UnderwaterImageSpace => Construct(0x946);
    }
}
