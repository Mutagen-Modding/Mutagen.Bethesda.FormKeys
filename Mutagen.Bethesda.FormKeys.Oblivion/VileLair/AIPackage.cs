namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class AIPackage
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey LairVileTarisServicesPackage => ModKey.MakeFormKey(0x328a);
            public static FormKey LairVileMinionReturnHomeSuccess => ModKey.MakeFormKey(0x7e62);
            public static FormKey LairVileMinionStudyTime => ModKey.MakeFormKey(0xe3e);
            public static FormKey LairVilePrisonerSleep => ModKey.MakeFormKey(0xe1f);
            public static FormKey LairVileMinionSleep => ModKey.MakeFormKey(0xe2b);
            public static FormKey LairVileTarisServicesOutdoorPackage => ModKey.MakeFormKey(0x379f);
            public static FormKey LairVileMinionBreakfast => ModKey.MakeFormKey(0xe34);
            public static FormKey LairVileMinionDinner => ModKey.MakeFormKey(0xe35);
            public static FormKey LairVileMinionTrain => ModKey.MakeFormKey(0xe36);
            public static FormKey LairVileMinionPrayer => ModKey.MakeFormKey(0xe37);
            public static FormKey LairVileMinionGardenTending => ModKey.MakeFormKey(0xe38);
            public static FormKey LairVileMinionBlessing => ModKey.MakeFormKey(0x137c);
            public static FormKey LairVileMinionFeedPrisoner => ModKey.MakeFormKey(0xe3d);
            public static FormKey LairVileMinionKill => ModKey.MakeFormKey(0x7976);
            public static FormKey LairVileMinionExecutePrisoner => ModKey.MakeFormKey(0x208d);
        }
    }
}
