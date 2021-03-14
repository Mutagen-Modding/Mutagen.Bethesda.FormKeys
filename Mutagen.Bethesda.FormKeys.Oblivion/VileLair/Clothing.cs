using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Clothing
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IClothingGetter> Construct(uint id) => new FormLink<IClothingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClothingGetter> LairVileManacles => Construct(0x31aa);
        }
    }
}
