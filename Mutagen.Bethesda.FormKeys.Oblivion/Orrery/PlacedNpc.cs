namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey DLCOrreryBandit1Ref1 => ModKey.MakeFormKey(0x129c3e);
            public static FormKey DLCOrreryBandit2Ref1 => ModKey.MakeFormKey(0x129c40);
            public static FormKey DLCOrreryBandit4Ref1 => ModKey.MakeFormKey(0x129c42);
            public static FormKey DLCOrreryBandit5Ref1 => ModKey.MakeFormKey(0x129c43);
            public static FormKey DLCOrreryBandit3Ref1 => ModKey.MakeFormKey(0x129c41);
        }
    }
}
