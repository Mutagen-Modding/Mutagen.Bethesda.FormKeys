using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Clothing
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IClothingGetter> Construct(uint id) => new FormLink<IClothingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClothingGetter> DLC06Footpads01 => Construct(0x83af);
            public static FormLink<IClothingGetter> DLC06Footpads02 => Construct(0x83b1);
            public static FormLink<IClothingGetter> DLC06Footpads03 => Construct(0x83b2);
            public static FormLink<IClothingGetter> DLC06Footpads04 => Construct(0x83b3);
            public static FormLink<IClothingGetter> DLC06Footpads05 => Construct(0x83b4);
        }
    }
}
