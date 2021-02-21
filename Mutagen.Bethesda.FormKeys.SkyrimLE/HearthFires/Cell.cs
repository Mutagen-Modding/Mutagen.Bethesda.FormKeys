using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Cell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<ICellGetter> Construct(uint id) => new FormLink<ICellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICellGetter> BYOHHouseUtilityCell => Construct(0x2fe4);
            public static FormLink<ICellGetter> BYOHHouse2Hjaalmarch => Construct(0x11cb3);
            public static FormLink<ICellGetter> BYOHHouse1FalkreathBasement => Construct(0x4849);
            public static FormLink<ICellGetter> BYOHHouse2HjaalmarchBasement => Construct(0x15154);
            public static FormLink<ICellGetter> BYOHHouse3PaleBasement => Construct(0x16a55);
            public static FormLink<ICellGetter> BYOHHouse3Pale => Construct(0x16a56);
            public static FormLink<ICellGetter> BYOHHouse1Falkreath => Construct(0x2fec);
        }
    }
}
