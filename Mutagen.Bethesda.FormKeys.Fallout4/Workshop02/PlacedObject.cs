// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static partial class PlacedObject
    {
        private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IPlacedObjectGetter> CtestBedRef001 => Construct(0xb83);
    }
}
