namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey CounterMiddle02ClutterMagesGuildFrostCrag => ModKey.MakeFormKey(0x5d6f);
            public static FormKey CrateClutterMiddle03FC => ModKey.MakeFormKey(0x353b);
            public static FormKey CrateClutterMiddle05FC => ModKey.MakeFormKey(0x353c);
            public static FormKey VendorMysticEmporiumAurelinwae => ModKey.MakeFormKey(0x124c);
            public static FormKey DLCFrostcragChestJewelryUpper01 => ModKey.MakeFormKey(0x5e34);
            public static FormKey FrostcragSpireAddons => ModKey.MakeFormKey(0x124e);
            public static FormKey FrostcragTestContainer => ModKey.MakeFormKey(0xd48);
        }
    }
}
