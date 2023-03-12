using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Skyrim
{
    public static partial class Eyes
    {
        public static FormLink<IEyesGetter> eyeReanimate => Construct(0x1A);
    }
}