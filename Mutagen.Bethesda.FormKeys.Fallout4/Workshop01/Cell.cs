// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static class Cell
    {
        private static FormLink<ICellGetter> Construct(uint id) => new FormLink<ICellGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ICellGetter> DLC02HoldingCell => Construct(0xbe3);
        public static FormLink<ICellGetter> CTESTCOPY0000 => Construct(0x91f);
        public static FormLink<ICellGetter> DLC02TestTraps => Construct(0xc10);
    }
}