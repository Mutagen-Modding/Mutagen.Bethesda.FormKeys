// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static partial class Perk
    {
        private static FormLink<IPerkGetter> Construct(uint id) => new FormLink<IPerkGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IPerkGetter> DLC05ArmorRackPerk => Construct(0x92e);
    }
}
