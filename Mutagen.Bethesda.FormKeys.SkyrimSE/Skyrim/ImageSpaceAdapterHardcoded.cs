using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Skyrim
{
    public static partial class ImageSpaceAdapter
    {
        public static FormLink<IImageSpaceAdapterGetter> ImageSpaceConcussion => Construct(0x164);
        public static FormLink<IImageSpaceAdapterGetter> ExplosionInFace => Construct(0x166);
    }
}