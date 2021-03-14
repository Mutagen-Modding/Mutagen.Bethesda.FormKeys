using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Sound
        {
            private static FormLink<ISoundGetter> Construct(uint id) => new FormLink<ISoundGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundGetter> AMBKnightsDisappear => Construct(0xcef);
            public static FormLink<ISoundGetter> NPCAuroranFootRight => Construct(0xcf0);
            public static FormLink<ISoundGetter> NPCAuroranFootLeft => Construct(0xcf1);
            public static FormLink<ISoundGetter> AMBBarrierDestroyed2D => Construct(0xcf2);
            public static FormLink<ISoundGetter> AMBWhiteoutReturn2D => Construct(0xcf3);
            public static FormLink<ISoundGetter> NPCUmarilDeath => Construct(0xcf4);
            public static FormLink<ISoundGetter> NPCUmarilInjured => Construct(0xcf5);
            public static FormLink<ISoundGetter> NPCUmarilFootRight => Construct(0xcf6);
            public static FormLink<ISoundGetter> NPCUmarilFootLeft => Construct(0xcf7);
            public static FormLink<ISoundGetter> NPCUmarilAttack => Construct(0xcf8);
            public static FormLink<ISoundGetter> AMBBearDistant2D => Construct(0xcf9);
            public static FormLink<ISoundGetter> AMBWhiteout2D => Construct(0xcfa);
            public static FormLink<ISoundGetter> AMBMagicBarrierLP => Construct(0xcfb);
            public static FormLink<ISoundGetter> AMBMaceTransport2D => Construct(0xcfc);
            public static FormLink<ISoundGetter> AMBSecretStaircaseStereo => Construct(0xcfd);
            public static FormLink<ISoundGetter> AMBSecretStaircaseMono => Construct(0xcfe);
            public static FormLink<ISoundGetter> AMBTowerGardenLP03 => Construct(0xcff);
            public static FormLink<ISoundGetter> AMBTowerGardenLP02 => Construct(0xd00);
            public static FormLink<ISoundGetter> AMBTowerGardenLP01 => Construct(0xd01);
            public static FormLink<ISoundGetter> AMBOrbSmashStereo => Construct(0xd02);
            public static FormLink<ISoundGetter> AMBOrbSmashMono => Construct(0xd03);
            public static FormLink<ISoundGetter> AMBRWindCloudPlaneGust => Construct(0xd04);
            public static FormLink<ISoundGetter> AMBWCloudPlaneLP2D => Construct(0xd05);
            public static FormLink<ISoundGetter> TRPStatueRotate4 => Construct(0xd06);
            public static FormLink<ISoundGetter> TRPStatueRotate9 => Construct(0xd07);
            public static FormLink<ISoundGetter> TRPStatueRotate10 => Construct(0xd08);
            public static FormLink<ISoundGetter> ND05StatueRotate => Construct(0xd09);
        }
    }
}
