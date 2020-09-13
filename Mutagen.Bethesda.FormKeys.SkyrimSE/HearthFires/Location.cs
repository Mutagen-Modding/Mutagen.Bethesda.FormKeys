namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Location
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHHouse3LocationInterior => ModKey.MakeFormKey(0xbe1d);
            public static FormKey BYOHHouse2LocationInterior => ModKey.MakeFormKey(0xbe0a);
            public static FormKey BYOHHouse3Location => ModKey.MakeFormKey(0x520a);
            public static FormKey BYOHHouse2Location => ModKey.MakeFormKey(0x5209);
            public static FormKey BYOHHouse1LocationInterior => ModKey.MakeFormKey(0x3092);
            public static FormKey BYOHHouse1Location => ModKey.MakeFormKey(0x308a);
        }
    }
}
