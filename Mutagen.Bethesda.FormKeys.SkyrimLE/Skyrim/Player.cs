using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Skyrim
{
    public static FormLink<IPlacedNpcGetter> PlayerRef => new(ModKey.MakeFormKey(0x14));
}