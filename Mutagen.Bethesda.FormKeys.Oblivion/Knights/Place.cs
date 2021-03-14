using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Place
        {
            private static FormLink<IPlaceGetter> Construct(uint id) => new FormLink<IPlaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlaceGetter> NDFortBulwark03 => Construct(0x1cf2);
            public static FormLink<IPlaceGetter> NDFortBulwark02 => Construct(0x1432);
            public static FormLink<IPlaceGetter> NDGarlasMalatar02a => Construct(0x16f8);
            public static FormLink<IPlaceGetter> NDHolding => Construct(0x24ba);
            public static FormLink<IPlaceGetter> NDGarlasMalatar03 => Construct(0x23c0);
            public static FormLink<IPlaceGetter> NDPrioryoftheNineHouse => Construct(0x2277);
            public static FormLink<IPlaceGetter> NDVanua => Construct(0x1850);
            public static FormLink<IPlaceGetter> NDKynarethCave => Construct(0x2214);
            public static FormLink<IPlaceGetter> NDFortBulwark => Construct(0xfd6);
            public static FormLink<IPlaceGetter> NDGarlasMalatar => Construct(0x1c57);
            public static FormLink<IPlaceGetter> NDVanua02 => Construct(0x1e1a);
            public static FormLink<IPlaceGetter> NDVanua01 => Construct(0x24be);
            public static FormLink<IPlaceGetter> NDPrioryoftheNineUndercroft => Construct(0x1c58);
            public static FormLink<IPlaceGetter> NDPrioryoftheNineBasement => Construct(0x1a82);
            public static FormLink<IPlaceGetter> NDPrioryoftheNineChapel => Construct(0x19c5);
            public static FormLink<IPlaceGetter> NDPrioryoftheNine => Construct(0x1cf1);
            public static FormLink<IPlaceGetter> NDGarlasMalatar01 => Construct(0x1215);
            public static FormLink<IPlaceGetter> TestAyleid => Construct(0x28da);
            public static FormLink<IPlaceGetter> AyleidWorld => Construct(0x28e1);
        }
    }
}
