namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class AIPackage
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey DLCFrostcragAurelinwaeOfferServices => ModKey.MakeFormKey(0x1247);
            public static FormKey DLCFrostcragAurelinwaeWanderstheICArbDistrict => ModKey.MakeFormKey(0x1253);
            public static FormKey DLCFrostcragAurelinwaeSleeps => ModKey.MakeFormKey(0x124b);
            public static FormKey DLCFrostcragAurelinwaeDefaultWander => ModKey.MakeFormKey(0x1248);
            public static FormKey FrostcragSpireAtronachFollow => ModKey.MakeFormKey(0x173b);
            public static FormKey FrostcragSpireAtronachWait => ModKey.MakeFormKey(0x173c);
            public static FormKey DLCFrostcragAurelinwaeEats => ModKey.MakeFormKey(0x1249);
        }
    }
}
