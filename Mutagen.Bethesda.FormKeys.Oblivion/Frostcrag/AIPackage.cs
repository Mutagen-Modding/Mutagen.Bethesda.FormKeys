using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class AIPackage
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IAIPackageGetter> Construct(uint id) => new FormLink<IAIPackageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAIPackageGetter> DLCFrostcragAurelinwaeOfferServices => Construct(0x1247);
            public static FormLink<IAIPackageGetter> DLCFrostcragAurelinwaeWanderstheICArbDistrict => Construct(0x1253);
            public static FormLink<IAIPackageGetter> DLCFrostcragAurelinwaeSleeps => Construct(0x124b);
            public static FormLink<IAIPackageGetter> DLCFrostcragAurelinwaeDefaultWander => Construct(0x1248);
            public static FormLink<IAIPackageGetter> FrostcragSpireAtronachFollow => Construct(0x173b);
            public static FormLink<IAIPackageGetter> FrostcragSpireAtronachWait => Construct(0x173c);
            public static FormLink<IAIPackageGetter> DLCFrostcragAurelinwaeEats => Construct(0x1249);
        }
    }
}
