namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            public static FormKey xDL06CaptainsQuarters => ModKey.MakeFormKey(0x139d);
            public static FormKey xDL06DunBarrowHaven => ModKey.MakeFormKey(0xce6);
            public static FormKey xDL06DunBarrowHaven02 => ModKey.MakeFormKey(0xd94);
            public static FormKey xDL06ShipInterior => ModKey.MakeFormKey(0x19a9);
        }
    }
}
