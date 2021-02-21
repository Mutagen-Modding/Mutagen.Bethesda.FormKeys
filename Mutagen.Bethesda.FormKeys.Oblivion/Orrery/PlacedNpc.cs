using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<IPlacedNpcGetter> Construct(uint id) => new FormLink<IPlacedNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedNpcGetter> DLCOrreryBandit1Ref1 => Construct(0x129c3e);
            public static FormLink<IPlacedNpcGetter> DLCOrreryBandit2Ref1 => Construct(0x129c40);
            public static FormLink<IPlacedNpcGetter> DLCOrreryBandit4Ref1 => Construct(0x129c42);
            public static FormLink<IPlacedNpcGetter> DLCOrreryBandit5Ref1 => Construct(0x129c43);
            public static FormLink<IPlacedNpcGetter> DLCOrreryBandit3Ref1 => Construct(0x129c41);
        }
    }
}
