// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class ImageSpaceAdapter
    {
        private static FormLink<IImageSpaceAdapterGetter> Construct(uint id) => new FormLink<IImageSpaceAdapterGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImageSpaceAdapterGetter> DLC06BlurImod => Construct(0x5e77);
    }
}
