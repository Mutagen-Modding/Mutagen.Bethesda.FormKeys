namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Cell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHHouseUtilityCell => ModKey.MakeFormKey(0x2fe4);
            public static FormKey BYOHHouse2Hjaalmarch => ModKey.MakeFormKey(0x11cb3);
            public static FormKey BYOHHouse1FalkreathBasement => ModKey.MakeFormKey(0x4849);
            public static FormKey BYOHHouse2HjaalmarchBasement => ModKey.MakeFormKey(0x15154);
            public static FormKey BYOHHouse3PaleBasement => ModKey.MakeFormKey(0x16a55);
            public static FormKey BYOHHouse3Pale => ModKey.MakeFormKey(0x16a56);
            public static FormKey BYOHHouse1Falkreath => ModKey.MakeFormKey(0x2fec);
        }
    }
}
