using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IPlaceGetter> Construct(uint id) => new FormLink<IPlaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlaceGetter> LairVile04 => Construct(0x5a65);
            public static FormLink<IPlaceGetter> LairVile01 => Construct(0xce6);
            public static FormLink<IPlaceGetter> LairVile02 => Construct(0x13c8);
            public static FormLink<IPlaceGetter> LairVile03 => Construct(0x208f);
        }
    }
}
