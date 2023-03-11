// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static class ImageSpace
    {
        private static FormLink<IImageSpaceGetter> Construct(uint id) => new FormLink<IImageSpaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImageSpaceGetter> DLC06ImageSpaceF4 => Construct(0x1e15);
        public static FormLink<IImageSpaceGetter> DLC06ImageSpaceF4Interior => Construct(0x434c);
    }
}