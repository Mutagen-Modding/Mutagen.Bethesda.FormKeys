using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static FormLink<IPlacedNpcGetter> PlayerRef => new(ModKey.MakeFormKey(0x14));
}