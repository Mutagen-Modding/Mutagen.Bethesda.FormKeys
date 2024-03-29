// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static partial class Cell
    {
        private static FormLink<ICellGetter> Construct(uint id) => new FormLink<ICellGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ICellGetter> TestDrewWorkshop => Construct(0xb7f);
        public static FormLink<ICellGetter> TestCory01 => Construct(0x95a);
    }
}
