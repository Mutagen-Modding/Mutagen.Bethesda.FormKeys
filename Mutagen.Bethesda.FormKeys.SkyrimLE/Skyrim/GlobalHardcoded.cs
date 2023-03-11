using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Skyrim
{
    public static partial class Global
    {
        public static FormLink<IGlobalGetter> PlayCredits => Construct(0x63);
    }
}