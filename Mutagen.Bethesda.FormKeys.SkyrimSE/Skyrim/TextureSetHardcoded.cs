using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Skyrim
{
    public static partial class TextureSet
    {
        public static FormLink<ITextureSetGetter> NullTextureSet => Construct(0x28);
    }
}