using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class MoveableStatic
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IMoveableStaticGetter> Construct(uint id) => new FormLink<IMoveableStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMoveableStaticGetter> DLC2TelMithrynTeleportFXActivate => Construct(0x3ca86);
            public static FormLink<IMoveableStaticGetter> DLC2TelMithrynTeleportFXActivateBeam => Construct(0x3ca84);
            public static FormLink<IMoveableStaticGetter> DLC2SignRRBlacksmith01 => Construct(0x3bd5e);
            public static FormLink<IMoveableStaticGetter> ApoHeadScone03 => Construct(0x3a4bc);
            public static FormLink<IMoveableStaticGetter> ApoHeadScone02 => Construct(0x3a4ba);
            public static FormLink<IMoveableStaticGetter> ApoMouthSconce03 => Construct(0x3a4b7);
            public static FormLink<IMoveableStaticGetter> ApoMouthSconce02 => Construct(0x3a4b6);
            public static FormLink<IMoveableStaticGetter> DLC2BannerTemple01 => Construct(0x3a495);
            public static FormLink<IMoveableStaticGetter> FlyingBookLoopDbl01 => Construct(0x39e36);
            public static FormLink<IMoveableStaticGetter> ApoFloatingPylon01 => Construct(0x39d60);
            public static FormLink<IMoveableStaticGetter> DLC2DarkElfLanternGlow06 => Construct(0x39bbd);
            public static FormLink<IMoveableStaticGetter> DLC2DarkElfLanternGlow05 => Construct(0x39bbc);
            public static FormLink<IMoveableStaticGetter> DLC2DarkElfLanternGlow04 => Construct(0x39bbb);
            public static FormLink<IMoveableStaticGetter> DLC2DarkElfLanternGlow03 => Construct(0x39bb7);
            public static FormLink<IMoveableStaticGetter> DLC2DarkElfLanternGlow02 => Construct(0x39bb5);
            public static FormLink<IMoveableStaticGetter> DLC2DarkElfLanternGlow01 => Construct(0x39bb4);
            public static FormLink<IMoveableStaticGetter> ApoPaperTwister03 => Construct(0x39b87);
            public static FormLink<IMoveableStaticGetter> DLC2SkallVillagePrayerEffect => Construct(0x397f8);
            public static FormLink<IMoveableStaticGetter> ApoPaperTwister02 => Construct(0x39742);
            public static FormLink<IMoveableStaticGetter> ApoPaperTwister01 => Construct(0x3973d);
            public static FormLink<IMoveableStaticGetter> ApoBookStackSm03 => Construct(0x39735);
            public static FormLink<IMoveableStaticGetter> ApoBookStackSm02 => Construct(0x39732);
            public static FormLink<IMoveableStaticGetter> ApoBookStackSm01 => Construct(0x39731);
            public static FormLink<IMoveableStaticGetter> FXApoMist01LongHalfVis => Construct(0x3972f);
            public static FormLink<IMoveableStaticGetter> FXApoMist01Long => Construct(0x3972e);
            public static FormLink<IMoveableStaticGetter> FXApoMistLowSwirls01HalfVis => Construct(0x39727);
            public static FormLink<IMoveableStaticGetter> FXApoMistLowSwirls01 => Construct(0x39724);
            public static FormLink<IMoveableStaticGetter> DLC2TelvanniTorchLightFX => Construct(0x391f1);
            public static FormLink<IMoveableStaticGetter> ApoPaperPile02 => Construct(0x38b19);
            public static FormLink<IMoveableStaticGetter> ApoPaperPile01 => Construct(0x38b10);
            public static FormLink<IMoveableStaticGetter> ApoBanner04 => Construct(0x386b2);
            public static FormLink<IMoveableStaticGetter> ApoBanner03 => Construct(0x386b1);
            public static FormLink<IMoveableStaticGetter> ApoBanner02 => Construct(0x386b0);
            public static FormLink<IMoveableStaticGetter> ApoBanner01 => Construct(0x386aa);
            public static FormLink<IMoveableStaticGetter> DLC2BannerAlchemy01 => Construct(0x38456);
            public static FormLink<IMoveableStaticGetter> DLC2BannerGeneralGoods01 => Construct(0x38455);
            public static FormLink<IMoveableStaticGetter> DLC2BannerTelvanni01 => Construct(0x38452);
            public static FormLink<IMoveableStaticGetter> DLC2BannerRedoran01 => Construct(0x38451);
            public static FormLink<IMoveableStaticGetter> ApoStacksTwisting01 => Construct(0x33bc2);
            public static FormLink<IMoveableStaticGetter> ApoFlyingBookLoop01 => Construct(0x33bbd);
            public static FormLink<IMoveableStaticGetter> DLC2ApocTenticlePatchNear02 => Construct(0x2c413);
            public static FormLink<IMoveableStaticGetter> DLC2ApocTenticlePatchNear01 => Construct(0x2c412);
            public static FormLink<IMoveableStaticGetter> Campfire01LandBurningDirtPath01 => Construct(0x2c0b0);
            public static FormLink<IMoveableStaticGetter> DLC2dunNchardak_FXWaterfallThin2048x512 => Construct(0x2b5d7);
            public static FormLink<IMoveableStaticGetter> DLC2dunNchardak_FXWaterfallThin3096x256 => Construct(0x2b5d6);
            public static FormLink<IMoveableStaticGetter> DLC2dunNchardak_FXWaterfallThin512x128 => Construct(0x2b5d5);
            public static FormLink<IMoveableStaticGetter> DLC2dunNchardak_FXWaterfallThin512x64 => Construct(0x2b5d4);
            public static FormLink<IMoveableStaticGetter> DLC2dunNchardak_FXWaterfallThin2048x128 => Construct(0x2b5d3);
            public static FormLink<IMoveableStaticGetter> DLC2dunNchardak_FXWaterfallThin4096x256 => Construct(0x2b5d2);
            public static FormLink<IMoveableStaticGetter> DLC2OceanWavesStraight => Construct(0x2adc5);
            public static FormLink<IMoveableStaticGetter> DLC2OceanWaveCurveOuter => Construct(0x2adc4);
            public static FormLink<IMoveableStaticGetter> DLC2CastleKarstaagTorch => Construct(0x2aab8);
            public static FormLink<IMoveableStaticGetter> DLC2ToolsChisel01 => Construct(0x28b3e);
            public static FormLink<IMoveableStaticGetter> Campfire01LandBurning_Ash => Construct(0x289e8);
            public static FormLink<IMoveableStaticGetter> DLC2_FXCreekFlatLargeNoCurrent => Construct(0x24cd1);
            public static FormLink<IMoveableStaticGetter> FXCreekFlatLong01_LSnowGlacierRocks => Construct(0x24820);
            public static FormLink<IMoveableStaticGetter> DLC2ApocEnvTenticleSky01 => Construct(0x24754);
            public static FormLink<IMoveableStaticGetter> DLC2ApocEnvTenticle01 => Construct(0x2473d);
            public static FormLink<IMoveableStaticGetter> ApoDarkWaterEye01 => Construct(0x2454d);
            public static FormLink<IMoveableStaticGetter> SiltStrider => Construct(0x23f10);
            public static FormLink<IMoveableStaticGetter> DLC2ApocTenticlePatchNear => Construct(0x1fde3);
            public static FormLink<IMoveableStaticGetter> DLC2DBBookLevelLightEffectMS => Construct(0x1eb96);
            public static FormLink<IMoveableStaticGetter> DLC2FXShrubCharredLarge01 => Construct(0x1d745);
            public static FormLink<IMoveableStaticGetter> DLC2FXShrubCharred01 => Construct(0x1d744);
            public static FormLink<IMoveableStaticGetter> DLC2LandscapeSmoke01 => Construct(0x1d739);
            public static FormLink<IMoveableStaticGetter> FXCreekFlatLong01_LMineDirt => Construct(0x1cbd3);
            public static FormLink<IMoveableStaticGetter> DLC2ScatteredEmbers02 => Construct(0x1a56d);
            public static FormLink<IMoveableStaticGetter> DLC2ScatteredEmbers01 => Construct(0x1a56c);
            public static FormLink<IMoveableStaticGetter> DLC2FXFlamingRockDebrisSmall => Construct(0x1a56b);
            public static FormLink<IMoveableStaticGetter> DLC2FXFlamingRockDebris => Construct(0x1a56a);
            public static FormLink<IMoveableStaticGetter> DLC2FXShrubSmokingWithDirt => Construct(0x1a54b);
            public static FormLink<IMoveableStaticGetter> DLC2FXShrubSmokingLarge01 => Construct(0x1a54a);
            public static FormLink<IMoveableStaticGetter> DLC2FXShrubSmoking01 => Construct(0x1a549);
            public static FormLink<IMoveableStaticGetter> DLC2FXAmbPlantSmoke => Construct(0x19ad7);
            public static FormLink<IMoveableStaticGetter> DLC2FXAmbAshBlowingConstant01 => Construct(0x19ad4);
            public static FormLink<IMoveableStaticGetter> DLC2FXAmbAshBlowing01 => Construct(0x19ad3);
            public static FormLink<IMoveableStaticGetter> TundraStreamTransition01_Ice => Construct(0x196f2);
            public static FormLink<IMoveableStaticGetter> FXCreekFlatLong01_Ice => Construct(0x19673);
            public static FormLink<IMoveableStaticGetter> FXCreekFlatLong01_LSnow => Construct(0x19657);
            public static FormLink<IMoveableStaticGetter> Campfire01LandBurning_LDirtSnowPath => Construct(0x18619);
            public static FormLink<IMoveableStaticGetter> Campfire01LandBurning_SnowRocks => Construct(0x18616);
        }
    }
}
