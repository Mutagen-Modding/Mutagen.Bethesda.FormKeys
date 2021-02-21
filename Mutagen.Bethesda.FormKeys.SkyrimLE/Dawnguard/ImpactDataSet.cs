using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class ImpactDataSet
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IImpactDataSetGetter> Construct(uint id) => new FormLink<IImpactDataSetGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImpactDataSetGetter> NPCVampireLordFootWalkImpactSet => Construct(0x13777);
            public static FormLink<IImpactDataSetGetter> NPCVampireLordFootRunImpactSet => Construct(0x13776);
            public static FormLink<IImpactDataSetGetter> FXHarkonPushImpactSet => Construct(0x11f89);
            public static FormLink<IImpactDataSetGetter> NPCDogIdleWhineImpactSet => Construct(0x11841);
            public static FormLink<IImpactDataSetGetter> NPCDogIdleShakeImpactSet => Construct(0x1183d);
            public static FormLink<IImpactDataSetGetter> NPCDogIdleScratchBImpactSet => Construct(0x11838);
            public static FormLink<IImpactDataSetGetter> NPCDogIdleScratchAImpactSet => Construct(0x11837);
            public static FormLink<IImpactDataSetGetter> NPCDogBarkDistantImpactSet => Construct(0x1182f);
            public static FormLink<IImpactDataSetGetter> NPCDogAttackPowerImpactSet => Construct(0x11827);
            public static FormLink<IImpactDataSetGetter> NPCDogAttackImpactSet => Construct(0x11826);
            public static FormLink<IImpactDataSetGetter> NPCDogAggroWarningImpactSet => Construct(0x11824);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyIdleWhineImpactSet => Construct(0x117db);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyIdleShakeImpactSet => Construct(0x1179c);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyIdleScratchBImpactSet => Construct(0x11798);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyIdleScratchAImpactSet => Construct(0x11795);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyBarkDistantImpactSet => Construct(0x11794);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyBarkImpactSet => Construct(0x11793);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyAttackPowerImpactSet => Construct(0x11792);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyAggroWarningImpactSet => Construct(0x11791);
            public static FormLink<IImpactDataSetGetter> NPCDogHuskyAttackImpactSet => Construct(0x11790);
            public static FormLink<IImpactDataSetGetter> NPCDogDeathHoundAttackBImpactSet => Construct(0x11761);
            public static FormLink<IImpactDataSetGetter> NPCDogDeathHoundAttackAImpactSet => Construct(0x11760);
            public static FormLink<IImpactDataSetGetter> NPCDogDeathHoundAttackPowerImpactSet => Construct(0x1175f);
            public static FormLink<IImpactDataSetGetter> NPCDogDeathHoundAttackPowerShortImpactSet => Construct(0x1175e);
            public static FormLink<IImpactDataSetGetter> NPCDogDeathHoundBreatheRunImpactSet => Construct(0x1175d);
            public static FormLink<IImpactDataSetGetter> NPCDogDeathHoundBarkImpactSet => Construct(0x1175c);
            public static FormLink<IImpactDataSetGetter> NPCDogDeathHoundBreatheImpactSet => Construct(0x115ee);
            public static FormLink<IImpactDataSetGetter> DLC1MAGSunFireImpactSet => Construct(0xd9ae);
            public static FormLink<IImpactDataSetGetter> NPCArmoredTrollFootFrontWalkImpactSet => Construct(0x39a4);
            public static FormLink<IImpactDataSetGetter> NPCArmoredTrollFootBackWalkImpactSet => Construct(0x39a3);
            public static FormLink<IImpactDataSetGetter> DLC1MAGVampireDrainImpactSet => Construct(0x1a3fb);
            public static FormLink<IImpactDataSetGetter> testMAGLightSpellImpactSet => Construct(0x15415);
            public static FormLink<IImpactDataSetGetter> FXMeleeGargoyleFleshImpactSet => Construct(0x10a28);
            public static FormLink<IImpactDataSetGetter> NPCGargoyleFootWalkRImpactSet => Construct(0xf8aa);
            public static FormLink<IImpactDataSetGetter> NPCGargoyleFootWalkLImpactSet => Construct(0xf8a9);
            public static FormLink<IImpactDataSetGetter> NPCHorseSkeletonFootSprintBackImpactSet => Construct(0xefad);
            public static FormLink<IImpactDataSetGetter> NPCHorseSkeletonFootSprintFrontImpactSet => Construct(0xefac);
            public static FormLink<IImpactDataSetGetter> NPCHorseSkeletonFootWalkBackImpactSet => Construct(0xefab);
            public static FormLink<IImpactDataSetGetter> NPCHorseSkeletonFootWalkFrontImpactSet => Construct(0xefaa);
            public static FormLink<IImpactDataSetGetter> WPNzBoltImpactSet => Construct(0xa311);
            public static FormLink<IImpactDataSetGetter> DLC01MAGSoulRendImpactSet => Construct(0x7cc0);
        }
    }
}
