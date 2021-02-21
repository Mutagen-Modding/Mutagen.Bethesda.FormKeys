using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Footstep
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IFootstepGetter> Construct(uint id) => new FormLink<IFootstepGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFootstepGetter> NPCVampireLordFootRunRFootstep => Construct(0x1377b);
            public static FormLink<IFootstepGetter> NPCVampireLordFootRunLFootstep => Construct(0x1377a);
            public static FormLink<IFootstepGetter> NPCVampireLordFootWalkRFootstep => Construct(0x13779);
            public static FormLink<IFootstepGetter> NPCVampireLordFootWalkLFootstep => Construct(0x13778);
            public static FormLink<IFootstepGetter> NPCDogAggroWarningFootstep => Construct(0x118f2);
            public static FormLink<IFootstepGetter> NPCDogIdleWhineFootstep => Construct(0x118f1);
            public static FormLink<IFootstepGetter> NPCDogIdleShakeFootstep => Construct(0x11861);
            public static FormLink<IFootstepGetter> NPCDogIdleScratchBFootstep => Construct(0x11852);
            public static FormLink<IFootstepGetter> NPCDogIdleScratchAFootstep => Construct(0x1184e);
            public static FormLink<IFootstepGetter> NPCDogAttackPowerFootstep => Construct(0x1184d);
            public static FormLink<IFootstepGetter> NPCDogAttackFootstep => Construct(0x1184c);
            public static FormLink<IFootstepGetter> NPCDogBarkDistantFootstep => Construct(0x11849);
            public static FormLink<IFootstepGetter> NPCDogHuskyIdleWhineFootstep => Construct(0x117fc);
            public static FormLink<IFootstepGetter> NPCDogHuskyIdleShakeFootstep => Construct(0x117fb);
            public static FormLink<IFootstepGetter> NPCDogHuskyIdleScratchBFootstep => Construct(0x117fa);
            public static FormLink<IFootstepGetter> NPCDogHuskyIdleScratchAFootstep => Construct(0x117f9);
            public static FormLink<IFootstepGetter> NPCDogHuskyBarkDistantFootstep => Construct(0x117f8);
            public static FormLink<IFootstepGetter> NPCDogHuskyBarkFootstep => Construct(0x117f7);
            public static FormLink<IFootstepGetter> NPCDogHuskyAttackPowerFootstep => Construct(0x117f6);
            public static FormLink<IFootstepGetter> NPCDogHuskyAggroWarningFootstep => Construct(0x117dd);
            public static FormLink<IFootstepGetter> NPCDogHuskyAttackFootstep => Construct(0x1178f);
            public static FormLink<IFootstepGetter> NPCDogDeathHoundAttackPowerShortFootstep => Construct(0x1178e);
            public static FormLink<IFootstepGetter> NPCDogDeathHoundAttackPowerFootstep => Construct(0x1178d);
            public static FormLink<IFootstepGetter> NPCDogDeathHoundAttackBFootstep => Construct(0x1178c);
            public static FormLink<IFootstepGetter> NPCDogDeathHoundAttackAFootstep => Construct(0x11779);
            public static FormLink<IFootstepGetter> NPCDogDeathHoundBreatheRunFootstep => Construct(0x11778);
            public static FormLink<IFootstepGetter> NPCDogDeathHoundBarkFootstep => Construct(0x11776);
            public static FormLink<IFootstepGetter> NPCDogDeathHoundBreatheFootstep => Construct(0x115ec);
            public static FormLink<IFootstepGetter> NPCArmoredTrollFootFrontWalkFootstep => Construct(0x39a6);
            public static FormLink<IFootstepGetter> NPCArmoredTrollFootBackWalkFootstep => Construct(0x39a5);
            public static FormLink<IFootstepGetter> NPCGargoyleFootWalkRFootstep => Construct(0xf8ac);
            public static FormLink<IFootstepGetter> NPCGargoyleFootWalkLFootstep => Construct(0xf8ab);
            public static FormLink<IFootstepGetter> NPCHorseSkeletonFootSprintBackFootstep => Construct(0xefb1);
            public static FormLink<IFootstepGetter> NPCHorseSkeletonFootSprintFrontFootstep => Construct(0xefb0);
            public static FormLink<IFootstepGetter> NPCHorseSkeletonFootWalkBackFootstep => Construct(0xefaf);
            public static FormLink<IFootstepGetter> NPCHorseSkeletonFootWalkFrontFootstep => Construct(0xefae);
        }
    }
}
