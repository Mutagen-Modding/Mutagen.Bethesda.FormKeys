using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Clothing
        {
            private static FormLink<IClothingGetter> Construct(uint id) => new FormLink<IClothingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClothingGetter> ND01RedDiamondRing => Construct(0xedf);
        }
    }
}
