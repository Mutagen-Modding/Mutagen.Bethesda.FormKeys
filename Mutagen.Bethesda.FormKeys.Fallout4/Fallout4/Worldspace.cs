// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static class Worldspace
    {
        private static FormLink<IWorldspaceGetter> Construct(uint id) => new FormLink<IWorldspaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWorldspaceGetter> Commonwealth => Construct(0x3c);
        public static FormLink<IWorldspaceGetter> DiamondCityFX => Construct(0xf93);
        public static FormLink<IWorldspaceGetter> DiamondCity => Construct(0xf94);
        public static FormLink<IWorldspaceGetter> Goodneighbor => Construct(0x54bd5);
        public static FormLink<IWorldspaceGetter> SanctuaryHillsWorld => Construct(0xa7ff4);
    }
}