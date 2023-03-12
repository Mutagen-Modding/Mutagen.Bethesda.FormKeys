using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Oblivion
{
    public static FormLink<IPlacedNpcGetter> PlayerRef => new(ModKey.MakeFormKey(0x14));
}