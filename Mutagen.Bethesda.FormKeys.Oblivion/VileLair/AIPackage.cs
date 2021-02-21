using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class AIPackage
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IAIPackageGetter> Construct(uint id) => new FormLink<IAIPackageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAIPackageGetter> LairVileTarisServicesPackage => Construct(0x328a);
            public static FormLink<IAIPackageGetter> LairVileMinionReturnHomeSuccess => Construct(0x7e62);
            public static FormLink<IAIPackageGetter> LairVileMinionStudyTime => Construct(0xe3e);
            public static FormLink<IAIPackageGetter> LairVilePrisonerSleep => Construct(0xe1f);
            public static FormLink<IAIPackageGetter> LairVileMinionSleep => Construct(0xe2b);
            public static FormLink<IAIPackageGetter> LairVileTarisServicesOutdoorPackage => Construct(0x379f);
            public static FormLink<IAIPackageGetter> LairVileMinionBreakfast => Construct(0xe34);
            public static FormLink<IAIPackageGetter> LairVileMinionDinner => Construct(0xe35);
            public static FormLink<IAIPackageGetter> LairVileMinionTrain => Construct(0xe36);
            public static FormLink<IAIPackageGetter> LairVileMinionPrayer => Construct(0xe37);
            public static FormLink<IAIPackageGetter> LairVileMinionGardenTending => Construct(0xe38);
            public static FormLink<IAIPackageGetter> LairVileMinionBlessing => Construct(0x137c);
            public static FormLink<IAIPackageGetter> LairVileMinionFeedPrisoner => Construct(0xe3d);
            public static FormLink<IAIPackageGetter> LairVileMinionKill => Construct(0x7976);
            public static FormLink<IAIPackageGetter> LairVileMinionExecutePrisoner => Construct(0x208d);
        }
    }
}
