// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Knights
{
    public static partial class Clothing
    {
        private static FormLink<IClothingGetter> Construct(uint id) => new FormLink<IClothingGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IClothingGetter> ND01RedDiamondRing => Construct(0xedf);
    }
}
