using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class BodyPartData
    {
        public static FormLink<IBodyPartDataGetter> PlayerBodyPartData => Construct(0x1C);
    }
}