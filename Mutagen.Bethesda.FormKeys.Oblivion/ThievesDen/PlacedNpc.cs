namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            public static FormKey DLFirstMateRef => ModKey.MakeFormKey(0xfd5e);
            public static FormKey DLCPirate01Ref => ModKey.MakeFormKey(0xee17);
            public static FormKey DLCPirate02Ref => ModKey.MakeFormKey(0xee0d);
            public static FormKey DLCPirate03Ref => ModKey.MakeFormKey(0x11ad7);
            public static FormKey DLCSecurityTrainerRef => ModKey.MakeFormKey(0xee09);
            public static FormKey DLCStealthTrainerRef => ModKey.MakeFormKey(0xee0e);
            public static FormKey DLCFletcherRef => ModKey.MakeFormKey(0xee14);
            public static FormKey DLCSupplierRef => ModKey.MakeFormKey(0xec8d);
            public static FormKey DLC06SupplierRef => ModKey.MakeFormKey(0xb551);
        }
    }
}
