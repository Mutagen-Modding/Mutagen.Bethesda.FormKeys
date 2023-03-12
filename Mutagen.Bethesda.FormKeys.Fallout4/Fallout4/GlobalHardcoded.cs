using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class Global
    {
        public static FormLink<IGlobalGetter> PlayCredits => Construct(0x63);
    }
}