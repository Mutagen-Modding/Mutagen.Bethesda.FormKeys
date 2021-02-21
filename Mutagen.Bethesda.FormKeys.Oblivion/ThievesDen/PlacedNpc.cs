using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IPlacedNpcGetter> Construct(uint id) => new FormLink<IPlacedNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedNpcGetter> DLFirstMateRef => Construct(0xfd5e);
            public static FormLink<IPlacedNpcGetter> DLCPirate01Ref => Construct(0xee17);
            public static FormLink<IPlacedNpcGetter> DLCPirate02Ref => Construct(0xee0d);
            public static FormLink<IPlacedNpcGetter> DLCPirate03Ref => Construct(0x11ad7);
            public static FormLink<IPlacedNpcGetter> DLCSecurityTrainerRef => Construct(0xee09);
            public static FormLink<IPlacedNpcGetter> DLCStealthTrainerRef => Construct(0xee0e);
            public static FormLink<IPlacedNpcGetter> DLCFletcherRef => Construct(0xee14);
            public static FormLink<IPlacedNpcGetter> DLCSupplierRef => Construct(0xec8d);
            public static FormLink<IPlacedNpcGetter> DLC06SupplierRef => Construct(0xb551);
        }
    }
}
