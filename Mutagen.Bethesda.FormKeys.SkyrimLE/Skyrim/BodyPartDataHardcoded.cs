using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Skyrim
{
    public static partial class BodyPartData
    {
        public static FormLink<IBodyPartDataGetter> PlayerBodyPartData => Construct(0x1C);
    }
}