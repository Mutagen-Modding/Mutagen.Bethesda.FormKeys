using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class AIPackage
        {
            private static FormLink<IAIPackageGetter> Construct(uint id) => new FormLink<IAIPackageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAIPackageGetter> DLC06SecurityTrainerSleep20x10 => Construct(0x3ec3);
            public static FormLink<IAIPackageGetter> DLClaraBellaCaptainGoAway => Construct(0xfd60);
            public static FormLink<IAIPackageGetter> DLC06BaconRef => Construct(0x74cb);
            public static FormLink<IAIPackageGetter> DLC06PirateWanderWide => Construct(0x3ec8);
            public static FormLink<IAIPackageGetter> DLC06FletcherMakeArrows9x12b => Construct(0x3e94);
            public static FormLink<IAIPackageGetter> DLC06FletcherEnchantArrow9x12 => Construct(0x3e95);
            public static FormLink<IAIPackageGetter> DLC06FletcherMakeArrows9x12a => Construct(0x3e97);
            public static FormLink<IAIPackageGetter> DLC06FletchTestBow9x12 => Construct(0x3e93);
            public static FormLink<IAIPackageGetter> DLC06StealthTrainerPracticeSword7x13 => Construct(0x3e9d);
            public static FormLink<IAIPackageGetter> DLC06StealthTrainerOfferServices7x13 => Construct(0x3e9e);
            public static FormLink<IAIPackageGetter> DLC06SupplierOfferServices10x13 => Construct(0x3ea6);
            public static FormLink<IAIPackageGetter> DLC06FenceOfferServices10x13 => Construct(0x3ea9);
            public static FormLink<IAIPackageGetter> DLC06PiratesGo01 => Construct(0x13dce);
            public static FormLink<IAIPackageGetter> DLC06FenceSleep2x8 => Construct(0x3eaa);
            public static FormLink<IAIPackageGetter> DLC06FenceEat23x3 => Construct(0x3eac);
            public static FormLink<IAIPackageGetter> DL06SupplierEat23x3 => Construct(0x3ead);
            public static FormLink<IAIPackageGetter> DLCSupplierSleep2x7 => Construct(0x3eaf);
            public static FormLink<IAIPackageGetter> DLC06FletcherEat21x3 => Construct(0x3eb0);
            public static FormLink<IAIPackageGetter> DLC06FletcherSleep0x8 => Construct(0x3eb1);
            public static FormLink<IAIPackageGetter> DLC06FirstMateOfferServices => Construct(0xc948);
            public static FormLink<IAIPackageGetter> DLC06PiratesGo02 => Construct(0x1602f);
            public static FormLink<IAIPackageGetter> DLC06PiratesGo03 => Construct(0x16030);
            public static FormLink<IAIPackageGetter> DLC06StealthTrainerEat20x3 => Construct(0x3eb3);
            public static FormLink<IAIPackageGetter> DLC06PiratesStay => Construct(0x16520);
            public static FormLink<IAIPackageGetter> DLC06StealthTrainerSleep23x6 => Construct(0x3eb4);
            public static FormLink<IAIPackageGetter> DLC06StealthTrainerEat12x1 => Construct(0x3eb5);
            public static FormLink<IAIPackageGetter> DLC06SecurityTrainerStudyManual8x12 => Construct(0x3ebc);
            public static FormLink<IAIPackageGetter> DLC06SecurityTrainerUseChest8x12 => Construct(0x3ebd);
            public static FormLink<IAIPackageGetter> DLC06SecurityTrainerEat20x2 => Construct(0x3ec2);
        }
    }
}
