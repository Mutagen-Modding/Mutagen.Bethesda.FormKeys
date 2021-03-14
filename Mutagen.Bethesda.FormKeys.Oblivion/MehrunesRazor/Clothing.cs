using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Clothing
        {
            private static FormLink<IClothingGetter> Construct(uint id) => new FormLink<IClothingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClothingGetter> DL9DrothmeriTunicSoldier => Construct(0x14cb);
            public static FormLink<IClothingGetter> DL9TongHood01 => Construct(0x1b42);
            public static FormLink<IClothingGetter> DL9TongHood04 => Construct(0x2098);
            public static FormLink<IClothingGetter> DL9DrothanHood01 => Construct(0x5fd6);
            public static FormLink<IClothingGetter> DL9DrothanRobe01 => Construct(0x5fd8);
            public static FormLink<IClothingGetter> DL9DrothanHood02 => Construct(0x5fd9);
            public static FormLink<IClothingGetter> DL9DrothanHood03 => Construct(0x5fda);
            public static FormLink<IClothingGetter> DL9DrothanHood04 => Construct(0x5fdb);
            public static FormLink<IClothingGetter> DL9DrothanHood05 => Construct(0x5fdc);
            public static FormLink<IClothingGetter> DL9DrothanRobe02 => Construct(0x5fdd);
            public static FormLink<IClothingGetter> DL9DrothanRobe03 => Construct(0x5fde);
            public static FormLink<IClothingGetter> DL9DrothanRobe04 => Construct(0x5fdf);
            public static FormLink<IClothingGetter> DL9DrothanRobe05 => Construct(0x5fe0);
            public static FormLink<IClothingGetter> DL9ForgeMasterAmulet02 => Construct(0x2742);
            public static FormLink<IClothingGetter> DL9ForgeMasterAmulet03 => Construct(0x2744);
            public static FormLink<IClothingGetter> DL9ForgeMasterApron02 => Construct(0x2745);
            public static FormLink<IClothingGetter> DL9ForgeMasterApron03 => Construct(0x2746);
            public static FormLink<IClothingGetter> DL9DrothmeriTunicVeteran => Construct(0x14cc);
            public static FormLink<IClothingGetter> DL9TongHood03 => Construct(0x208e);
            public static FormLink<IClothingGetter> DL9TongHood02 => Construct(0x1b92);
            public static FormLink<IClothingGetter> DL9ForgeMasterAmulet01 => Construct(0x2736);
            public static FormLink<IClothingGetter> DL9ForgeMasterApron01 => Construct(0x2738);
            public static FormLink<IClothingGetter> DL9DrothmeriTunicRecruit => Construct(0x14ca);
            public static FormLink<IClothingGetter> DL9TongHood05 => Construct(0x20a2);
        }
    }
}
