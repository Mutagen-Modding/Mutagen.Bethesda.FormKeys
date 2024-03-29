// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class TextureSet
    {
        private static FormLink<ITextureSetGetter> Construct(uint id) => new FormLink<ITextureSetGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ITextureSetGetter> DLC06DirtGravelAlphaDecal01 => Construct(0x1a76);
    }
}
