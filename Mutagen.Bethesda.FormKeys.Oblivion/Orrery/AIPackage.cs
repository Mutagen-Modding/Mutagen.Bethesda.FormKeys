namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class AIPackage
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey DLCOrreryBothielWaitforPlayer => ModKey.MakeFormKey(0x123016);
            public static FormKey DLCBanditWanderCurrentLoc => ModKey.MakeFormKey(0x129c49);
            public static FormKey DLCBothielRepairingOrrery => ModKey.MakeFormKey(0x123019);
            public static FormKey DLCOrreryBothielWanderOrrery => ModKey.MakeFormKey(0x12301a);
        }
    }
}
