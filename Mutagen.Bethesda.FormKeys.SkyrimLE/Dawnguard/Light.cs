using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Light
        {
            private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILightGetter> DLC1VCCourtyardNightLight => Construct(0x14c52);
            public static FormLink<ILightGetter> DLC1ForbearsBarrierLight => Construct(0x12d71);
            public static FormLink<ILightGetter> DLC1FXRedBossFountainLight => Construct(0xf6a2);
            public static FormLink<ILightGetter> FalmerDarkBlueLight01NS => Construct(0xe6cf);
            public static FormLink<ILightGetter> FXCandleLight2 => Construct(0xd704);
            public static FormLink<ILightGetter> DLC1MagicAurielSpellLight01 => Construct(0xd665);
            public static FormLink<ILightGetter> FXCandleLight => Construct(0xd260);
            public static FormLink<ILightGetter> DLC1SETempleDoor01NS => Construct(0xd259);
            public static FormLink<ILightGetter> DLC1PortalShadLight => Construct(0x19965);
            public static FormLink<ILightGetter> DLC1BFroomLight => Construct(0x195a1);
            public static FormLink<ILightGetter> FarmInteriorFireLight01NoShadow => Construct(0x182ca);
            public static FormLink<ILightGetter> DLC01SCPurpleDesatNS => Construct(0x17650);
            public static FormLink<ILightGetter> MagicLightDLC01SoulRendProjWeak => Construct(0x16123);
            public static FormLink<ILightGetter> EvernightSunlight => Construct(0x1575d);
            public static FormLink<ILightGetter> testSuperMageLight2 => Construct(0x1540d);
            public static FormLink<ILightGetter> testSuperMageLight1 => Construct(0x1540c);
            public static FormLink<ILightGetter> DLC1Torch => Construct(0x15374);
            public static FormLink<ILightGetter> DLC1dunRedwaterDenLightBrightRed => Construct(0x147fd);
            public static FormLink<ILightGetter> DawnGuardIntFireLight01 => Construct(0x1036f);
            public static FormLink<ILightGetter> DLC1MagicLightSunProjectile => Construct(0xf64b);
            public static FormLink<ILightGetter> DLC1FalmerPurple01NS => Construct(0xefe3);
            public static FormLink<ILightGetter> DLC01IdealMasterCrystalLight => Construct(0xbf49);
            public static FormLink<ILightGetter> DLC1WaterLight => Construct(0xaeb7);
            public static FormLink<ILightGetter> DLC1dunRedwaterDenLightBright => Construct(0xa5ae);
            public static FormLink<ILightGetter> DLC1MagicLightSunLightSpell01 => Construct(0xa3ba);
            public static FormLink<ILightGetter> DLC1dunRedwaterDenLight => Construct(0x8cbd);
            public static FormLink<ILightGetter> MagicLightDLC01SoulRendProj => Construct(0x7cbd);
            public static FormLink<ILightGetter> DLC01SCPurpleNS => Construct(0x59c2);
            public static FormLink<ILightGetter> DLC01SCPurple => Construct(0x59c0);
        }
    }
}
