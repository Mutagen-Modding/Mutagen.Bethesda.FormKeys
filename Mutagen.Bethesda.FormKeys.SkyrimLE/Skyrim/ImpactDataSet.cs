using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class ImpactDataSet
        {
            private static FormLink<IImpactDataSetGetter> Construct(uint id) => new FormLink<IImpactDataSetGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImpactDataSetGetter> MAGPowerSerpentStoneImpactImpactSet => Construct(0xe02);
            public static FormLink<IImpactDataSetGetter> NPCDragonFlightRoarPaarthurnaxImpactSet => Construct(0x172a8);
            public static FormLink<IImpactDataSetGetter> NPCDragonFlightRoarImpactSet => Construct(0x172a7);
            public static FormLink<IImpactDataSetGetter> MAGDwarvenSteamImpactSet => Construct(0x10fdf7);
            public static FormLink<IImpactDataSetGetter> NPCDogBarkImpactSet => Construct(0x10f8a4);
            public static FormLink<IImpactDataSetGetter> NPCWolfBarkImpactSet => Construct(0x10f8a3);
            public static FormLink<IImpactDataSetGetter> NPCWolfBreatheRunImpactSet => Construct(0x10f89e);
            public static FormLink<IImpactDataSetGetter> NPCWolfBreatheImpactSet => Construct(0x10f89d);
            public static FormLink<IImpactDataSetGetter> NPCFoxBreatheImpactSet => Construct(0x10f89a);
            public static FormLink<IImpactDataSetGetter> NPCFoxBreatheRunImpactSet => Construct(0x10f894);
            public static FormLink<IImpactDataSetGetter> MAGMG07StaffMagnusImpactSet => Construct(0x105f37);
            public static FormLink<IImpactDataSetGetter> MS06PotemaMAGShockBarrierImpactSet => Construct(0x1034c4);
            public static FormLink<IImpactDataSetGetter> NPCWerewolfFootJumpDownImpactSet => Construct(0x10163a);
            public static FormLink<IImpactDataSetGetter> NPCWerewolfFootJumpUpImpactSet => Construct(0x101639);
            public static FormLink<IImpactDataSetGetter> MAGPoisonSprayImpactSet => Construct(0xfff4b);
            public static FormLink<IImpactDataSetGetter> NPCWerewolfFootSprintBackImpactSet => Construct(0xff248);
            public static FormLink<IImpactDataSetGetter> NPCWerewolfFootSprintFrontImpactSet => Construct(0xff247);
            public static FormLink<IImpactDataSetGetter> NPCWerewolfFootRunImpactSet => Construct(0xf7ea9);
            public static FormLink<IImpactDataSetGetter> PHYBodyBones => Construct(0xf7b64);
            public static FormLink<IImpactDataSetGetter> PHYBonesImpactSet => Construct(0xf75ad);
            public static FormLink<IImpactDataSetGetter> BloodSprayBleedImpactSetRed => Construct(0xf457b);
            public static FormLink<IImpactDataSetGetter> NPCWerewolfFootWalkImpactSet => Construct(0xf23e3);
            public static FormLink<IImpactDataSetGetter> FXMeleeWerewolfFleshImpactSet => Construct(0xf23c4);
            public static FormLink<IImpactDataSetGetter> MAGDragonFrost01LargeImpactSet => Construct(0xd7863);
            public static FormLink<IImpactDataSetGetter> MAGFrost01LargeImpactSet => Construct(0xd6c64);
            public static FormLink<IImpactDataSetGetter> NPCHareFootWalkFrontImpactSet => Construct(0xd3ad4);
            public static FormLink<IImpactDataSetGetter> MAGFirebolt01WithRocksImpactSet => Construct(0xd07c2);
            public static FormLink<IImpactDataSetGetter> TGControlImpactSet => Construct(0xce27a);
            public static FormLink<IImpactDataSetGetter> NPCHagravenFootWalkRImpactSet => Construct(0xc0d33);
            public static FormLink<IImpactDataSetGetter> NPCHagravenFootWalkLImpactSet => Construct(0xc0d2c);
            public static FormLink<IImpactDataSetGetter> NPCSkeletonFootWalkRImpactSet => Construct(0xbfb25);
            public static FormLink<IImpactDataSetGetter> NPCSkeletonFootWalkLImpactSet => Construct(0xbfb24);
            public static FormLink<IImpactDataSetGetter> NPCMammothFootRunFrontImpactSet => Construct(0xb2dcd);
            public static FormLink<IImpactDataSetGetter> NPCMammothFootRunBackImpactSet => Construct(0xb2dcc);
            public static FormLink<IImpactDataSetGetter> VOCShoutDisarm01ImpactSet => Construct(0xa7244);
            public static FormLink<IImpactDataSetGetter> DA09LightBeam01ImpactSet => Construct(0x2c481);
            public static FormLink<IImpactDataSetGetter> MAGFlameWaveImpactSet => Construct(0x647bd);
            public static FormLink<IImpactDataSetGetter> PHYMaterialBlade1HandSmallImpactSet => Construct(0x624b3);
            public static FormLink<IImpactDataSetGetter> PHYGenericClothImpactSet => Construct(0x624ad);
            public static FormLink<IImpactDataSetGetter> PHYBookImpactSet => Construct(0x5cf0e);
            public static FormLink<IImpactDataSetGetter> PHYGenericMetalHeavyImpactSet => Construct(0x5cf05);
            public static FormLink<IImpactDataSetGetter> PHYGenericMetalMediumImpactSet => Construct(0x5cf04);
            public static FormLink<IImpactDataSetGetter> PHYGenericMetalLightImpactSet => Construct(0x5cefc);
            public static FormLink<IImpactDataSetGetter> NPCHorkerFootBackWalkImpact => Construct(0x42abb);
            public static FormLink<IImpactDataSetGetter> NPCHorkerFootFrontWalkImpact => Construct(0x42aba);
            public static FormLink<IImpactDataSetGetter> MAGShockStorm01ImpactSet => Construct(0x25dab);
            public static FormLink<IImpactDataSetGetter> _ImpactDataSet => Construct(0xe7717);
            public static FormLink<IImpactDataSetGetter> PHYMaterialBlunt2HandImpactSet => Construct(0xe752f);
            public static FormLink<IImpactDataSetGetter> PHYMaterialBlunt1HandImpactSet => Construct(0xe752b);
            public static FormLink<IImpactDataSetGetter> PHYMaterialBlade2HandImpactSet => Construct(0xe7526);
            public static FormLink<IImpactDataSetGetter> WPNBlockBlunt2HandImpactSet => Construct(0xe64aa);
            public static FormLink<IImpactDataSetGetter> PHYMeatImpactSet => Construct(0xe4f26);
            public static FormLink<IImpactDataSetGetter> WPNzBlunt2HandImpactSet => Construct(0xe4cb0);
            public static FormLink<IImpactDataSetGetter> FSTSprintBarefootRImpactSet => Construct(0xe41e7);
            public static FormLink<IImpactDataSetGetter> FSTSprintBarefootLImpactSet => Construct(0xe41e6);
            public static FormLink<IImpactDataSetGetter> FSTRunBarefootRImpactSet => Construct(0xe41e5);
            public static FormLink<IImpactDataSetGetter> FSTRunBarefootLImpactSet => Construct(0xe41e4);
            public static FormLink<IImpactDataSetGetter> NPCWolfFootFrontWalkImpactSet => Construct(0xdce9a);
            public static FormLink<IImpactDataSetGetter> NPCWolfFootBackWalkImpactSet => Construct(0xdce99);
            public static FormLink<IImpactDataSetGetter> WPNzCrGiantClubImpactSet => Construct(0xc4e32);
            public static FormLink<IImpactDataSetGetter> PHYBodyLargeImpactSet => Construct(0xc1ad6);
            public static FormLink<IImpactDataSetGetter> WPNzUnarmedImpactSet => Construct(0xc190f);
            public static FormLink<IImpactDataSetGetter> NPCBearFootFrontRunImpactSet => Construct(0xa19a6);
            public static FormLink<IImpactDataSetGetter> NPCBearFootBackRunImpactSet => Construct(0xa19a5);
            public static FormLink<IImpactDataSetGetter> NPCGoatFootBackImpactSet => Construct(0x5e3d7);
            public static FormLink<IImpactDataSetGetter> NPCGoatFootFrontImpactSet => Construct(0x5e3d6);
            public static FormLink<IImpactDataSetGetter> WPNBlockBlade2HandImpactSet => Construct(0x97785);
            public static FormLink<IImpactDataSetGetter> WPNzBlade2HandImpactSet => Construct(0x949d5);
            public static FormLink<IImpactDataSetGetter> PHYMaterialCarriageWheelImpactSet => Construct(0x84781);
            public static FormLink<IImpactDataSetGetter> MAGReanimatelImpactSet => Construct(0x75346);
            public static FormLink<IImpactDataSetGetter> MAGShockBarrierImpactSet => Construct(0x592d0);
            public static FormLink<IImpactDataSetGetter> NPCSpiderFrostbiteGiantFootWalkRImpactSet => Construct(0x2e2f2);
            public static FormLink<IImpactDataSetGetter> NPCSpiderFrostbiteGiantFootWalkLImpactSet => Construct(0x2e2f1);
            public static FormLink<IImpactDataSetGetter> NPCSpiderFrostbiteAttackImpactSet => Construct(0x2a60d);
            public static FormLink<IImpactDataSetGetter> NPCMudcrabFootWalkRImpactSet => Construct(0xb97c9);
            public static FormLink<IImpactDataSetGetter> NPCMudcrabFootWalkLImpactSet => Construct(0xb97c8);
            public static FormLink<IImpactDataSetGetter> FXMeleePunchLargeImpactSet => Construct(0xaf666);
            public static FormLink<IImpactDataSetGetter> FXMeleePunchMediumImpactSet => Construct(0xaf640);
            public static FormLink<IImpactDataSetGetter> PHYBoulderSmallImpactSet => Construct(0xaf63c);
            public static FormLink<IImpactDataSetGetter> MAGAuraWhisperImpactSet => Construct(0xad38f);
            public static FormLink<IImpactDataSetGetter> MAGAbsorbGreenImpactSet => Construct(0xabf0c);
            public static FormLink<IImpactDataSetGetter> MAGAbsorbBlueImpactSet => Construct(0xabf0b);
            public static FormLink<IImpactDataSetGetter> MAGAbsorbRedImpactSet => Construct(0xabf01);
            public static FormLink<IImpactDataSetGetter> FXMeleeBiteMediumImpactSet => Construct(0xa956f);
            public static FormLink<IImpactDataSetGetter> NPCSprigganFootWalkRImpactSet => Construct(0xa9205);
            public static FormLink<IImpactDataSetGetter> NPCSprigganFootWalkLImpactSet => Construct(0xa9204);
            public static FormLink<IImpactDataSetGetter> PHYBodyMetalSmallImpactSet => Construct(0x9644b);
            public static FormLink<IImpactDataSetGetter> FXMeleeMetalImpactLargeFleshImpactSet => Construct(0x92c92);
            public static FormLink<IImpactDataSetGetter> PHYBodyMetalLargeImpactSet => Construct(0x9150f);
            public static FormLink<IImpactDataSetGetter> MAGFrostBarrierImpactSet => Construct(0x8f3f6);
            public static FormLink<IImpactDataSetGetter> MAGFlamesBarrierImpactSet => Construct(0x8f3f0);
            public static FormLink<IImpactDataSetGetter> NPCBearFootBackWalkImpactSet => Construct(0x8ad57);
            public static FormLink<IImpactDataSetGetter> NPCBearFootFrontWalkImpactSet => Construct(0x8ad56);
            public static FormLink<IImpactDataSetGetter> PHYBodyDragon => Construct(0x60dbf);
            public static FormLink<IImpactDataSetGetter> PHYBodySmallImpactSet => Construct(0x5a28e);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepJumpUpImpact => Construct(0x5a288);
            public static FormLink<IImpactDataSetGetter> PHYBodyMedium => Construct(0x5a286);
            public static FormLink<IImpactDataSetGetter> PHYBoulderMediumImpactSet => Construct(0x876b9);
            public static FormLink<IImpactDataSetGetter> PHYBoulderLargeImpactSet => Construct(0x876b7);
            public static FormLink<IImpactDataSetGetter> NPCMammothFootWalkBackImpactSet => Construct(0x87594);
            public static FormLink<IImpactDataSetGetter> NPCMammothFootWalkFrontImpactSet => Construct(0x87593);
            public static FormLink<IImpactDataSetGetter> NPCDwarvenCenturionFootWalkRImpactSet => Construct(0x86ef4);
            public static FormLink<IImpactDataSetGetter> NPCDwarvenCenturionFootWalkLImpactSet => Construct(0x86ef3);
            public static FormLink<IImpactDataSetGetter> NPCDwarvenSpiderFootWalkRImpactSet => Construct(0x7a73c);
            public static FormLink<IImpactDataSetGetter> NPCDwarvenSpiderFootWalkLImpactSet => Construct(0x7a73b);
            public static FormLink<IImpactDataSetGetter> NPCElkFootWalkFrontImpactSet => Construct(0x78f1d);
            public static FormLink<IImpactDataSetGetter> NPCElkFootWalkBackImpactSet => Construct(0x78f1c);
            public static FormLink<IImpactDataSetGetter> NPCHorseFootSprintFrontImpactSet => Construct(0x786e6);
            public static FormLink<IImpactDataSetGetter> NPCHorseFootSprintBackImpactSet => Construct(0x786e5);
            public static FormLink<IImpactDataSetGetter> MAGIllusionNegImpactSet => Construct(0x74798);
            public static FormLink<IImpactDataSetGetter> MAGIllusionImpactSet => Construct(0x73320);
            public static FormLink<IImpactDataSetGetter> MAGRuneShockImpactSet => Construct(0x665b9);
            public static FormLink<IImpactDataSetGetter> NPCHorseFootWalkBackImpactSet => Construct(0x5f71d);
            public static FormLink<IImpactDataSetGetter> NPCHorseFootWalkFrontImpactSet => Construct(0x5f71c);
            public static FormLink<IImpactDataSetGetter> NPCCharusFootWalkBackImpactSet => Construct(0x44017);
            public static FormLink<IImpactDataSetGetter> NPCCharusFootWalkFrontImpactSet => Construct(0x44016);
            public static FormLink<IImpactDataSetGetter> NPCFalmerFootWalkRImpactSet => Construct(0x44008);
            public static FormLink<IImpactDataSetGetter> NPCFalmerFootWalkLImpactSet => Construct(0x44007);
            public static FormLink<IImpactDataSetGetter> MAGRuneFrostImpactSet => Construct(0x3af15);
            public static FormLink<IImpactDataSetGetter> FXMeleeBiteSmallImpactSet => Construct(0x24066);
            public static FormLink<IImpactDataSetGetter> PHYCoinImpactSet => Construct(0x2133f);
            public static FormLink<IImpactDataSetGetter> MAGRuneFireImpactSet => Construct(0x6051e);
            public static FormLink<IImpactDataSetGetter> NPCIceWraithFootWalkImpactSet => Construct(0x5de21);
            public static FormLink<IImpactDataSetGetter> NPCAtronachFrostFootWalkLImpactSet => Construct(0x5dd83);
            public static FormLink<IImpactDataSetGetter> NPCAtronachFrostFootWalkRImpactSet => Construct(0x5dd7c);
            public static FormLink<IImpactDataSetGetter> MAGShock02ImpactSet => Construct(0x59ed9);
            public static FormLink<IImpactDataSetGetter> NPCGiantFootDistantRImpactSet => Construct(0x318e2);
            public static FormLink<IImpactDataSetGetter> NPCGiantFootDistantLImpactSet => Construct(0x318de);
            public static FormLink<IImpactDataSetGetter> FXDragonLandingImpactSet => Construct(0x2bd39);
            public static FormLink<IImpactDataSetGetter> PHYBottleSmallImpactSet => Construct(0x51788);
            public static FormLink<IImpactDataSetGetter> PHYBowsStavesImpactSet => Construct(0x50dbd);
            public static FormLink<IImpactDataSetGetter> PHYPotsPansImpactSet => Construct(0x50af9);
            public static FormLink<IImpactDataSetGetter> NPCDogFootFrontWalkImpactSet => Construct(0x4e86b);
            public static FormLink<IImpactDataSetGetter> NPCDogFootBackWalkImpactSet => Construct(0x4e86a);
            public static FormLink<IImpactDataSetGetter> NPCCowFootFrontWalkImpactSet => Construct(0x4e20c);
            public static FormLink<IImpactDataSetGetter> NPCCowFootBackWalkImpactSet => Construct(0x4e20b);
            public static FormLink<IImpactDataSetGetter> PHYMaterialArrowImpactData => Construct(0x4d2ba);
            public static FormLink<IImpactDataSetGetter> MAGTurnUnlImpactSet => Construct(0x4c6da);
            public static FormLink<IImpactDataSetGetter> PHYMaterialCeramicMediumImpactSet => Construct(0x2fd65);
            public static FormLink<IImpactDataSetGetter> PHYOrganicSmallImpactSet => Construct(0x28d3d);
            public static FormLink<IImpactDataSetGetter> PHYMaterialAxe1HandImpactSet => Construct(0x1a352);
            public static FormLink<IImpactDataSetGetter> MAGFrostIceStorm01ImpactSet => Construct(0x49b64);
            public static FormLink<IImpactDataSetGetter> PHYGenericWoodMediumImpactSet => Construct(0x46029);
            public static FormLink<IImpactDataSetGetter> MAGSpiderSpitImpactSet => Construct(0x46008);
            public static FormLink<IImpactDataSetGetter> PHYBottleImpactSet => Construct(0x44baf);
            public static FormLink<IImpactDataSetGetter> PHYGenericWoodLightImpactSet => Construct(0x43db9);
            public static FormLink<IImpactDataSetGetter> MAGLightSpellImpactSet => Construct(0x3fa5a);
            public static FormLink<IImpactDataSetGetter> FXDragonTailstompImpactSet => Construct(0x3f819);
            public static FormLink<IImpactDataSetGetter> NPCTrollFootBackWalkImpactSet => Construct(0x17cae);
            public static FormLink<IImpactDataSetGetter> NPCTrollFootFrontWalkImpactSet => Construct(0x17cad);
            public static FormLink<IImpactDataSetGetter> VOCShoutPush01ImpactSet => Construct(0x15c7b);
            public static FormLink<IImpactDataSetGetter> NPCSpiderFrostbiteFootWalkRImpactSet => Construct(0x1547f);
            public static FormLink<IImpactDataSetGetter> NPCSpiderFrostbiteFootWalkLImpactSet => Construct(0x1547e);
            public static FormLink<IImpactDataSetGetter> PHYMaterialArmorLightImpactSet => Construct(0x388fa);
            public static FormLink<IImpactDataSetGetter> PHYMaterialArmorHeavyImpactSet => Construct(0x388f9);
            public static FormLink<IImpactDataSetGetter> PHYBasketImpactSet => Construct(0x363af);
            public static FormLink<IImpactDataSetGetter> PHYMaterialShieldLightImpactSet => Construct(0x363ab);
            public static FormLink<IImpactDataSetGetter> PHYMaterialShieldHeavyImpactSet => Construct(0x363aa);
            public static FormLink<IImpactDataSetGetter> MAGConjure01ImpactSet => Construct(0x3a1e9);
            public static FormLink<IImpactDataSetGetter> PHYMaterialBlade1HandImpactSet => Construct(0x39e0d);
            public static FormLink<IImpactDataSetGetter> MAGShock01ImpactSet => Construct(0x38b05);
            public static FormLink<IImpactDataSetGetter> WPNzAxeLargeImpactSet => Construct(0x36a5b);
            public static FormLink<IImpactDataSetGetter> FXMeleeClawSmall => Construct(0x35b35);
            public static FormLink<IImpactDataSetGetter> FXMeleeDraugrImpactSet => Construct(0x34930);
            public static FormLink<IImpactDataSetGetter> MAGFrostBolt01ImpactSet => Construct(0x32da7);
            public static FormLink<IImpactDataSetGetter> NPCGiantFootWalkRImpactSet => Construct(0x2ee38);
            public static FormLink<IImpactDataSetGetter> NPCGiantFootWalkLImpactSet => Construct(0x2ee35);
            public static FormLink<IImpactDataSetGetter> MAGFlames01ImpactSet => Construct(0x26113);
            public static FormLink<IImpactDataSetGetter> MAGDragonFireImpactSet => Construct(0x20de1);
            public static FormLink<IImpactDataSetGetter> NPCDragonFootWalkRImpactSet => Construct(0x1cb25);
            public static FormLink<IImpactDataSetGetter> NPCDragonFootWalkLImpactSet => Construct(0x1cb24);
            public static FormLink<IImpactDataSetGetter> NPCDraugrFootWalkRImpactSet => Construct(0x1aeba);
            public static FormLink<IImpactDataSetGetter> NPCDraugrFootWalkLImpactSet => Construct(0x1aeb9);
            public static FormLink<IImpactDataSetGetter> FXDragonTakeoffImpactSet => Construct(0x19a01);
            public static FormLink<IImpactDataSetGetter> MAGFrost01ImpactSet => Construct(0x18a2e);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepSneakRImpactSet => Construct(0x2dd89);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepWalkRImpactset => Construct(0x2dd88);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepRunRImpactSet => Construct(0x2dd87);
            public static FormLink<IImpactDataSetGetter> FSTSprintArmorLightRImpactSet => Construct(0x23a74);
            public static FormLink<IImpactDataSetGetter> FSTSprintArmorLightLImpactSet => Construct(0x23a73);
            public static FormLink<IImpactDataSetGetter> FSTSprintArmorHeavyRImpactSet => Construct(0x23a72);
            public static FormLink<IImpactDataSetGetter> FSTSprintArmorHeavyLImpactSet => Construct(0x23a71);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepSprintRImpactSet => Construct(0x225a4);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepSprintLImpactSet => Construct(0x225a1);
            public static FormLink<IImpactDataSetGetter> FSTWalkArmorLightRImpactSet => Construct(0x21481);
            public static FormLink<IImpactDataSetGetter> FSTWalkArmorLightLImpactSet => Construct(0x21480);
            public static FormLink<IImpactDataSetGetter> FSTWalkArmorHeavyRImpactSet => Construct(0x2147f);
            public static FormLink<IImpactDataSetGetter> FSTWalkArmorHeavyLImpactSet => Construct(0x2147e);
            public static FormLink<IImpactDataSetGetter> FSTRunArmorHeavyRImpactSet => Construct(0x2147d);
            public static FormLink<IImpactDataSetGetter> FSTRunArmorHeavyLImpactSet => Construct(0x2147c);
            public static FormLink<IImpactDataSetGetter> FSTRunArmorLightRImpactSet => Construct(0x2147b);
            public static FormLink<IImpactDataSetGetter> FSTRunArmorLightLImpactSet => Construct(0x2147a);
            public static FormLink<IImpactDataSetGetter> FSTWalkBarefootRImpactSet => Construct(0x21465);
            public static FormLink<IImpactDataSetGetter> FSTWalkBarefootLImpactSet => Construct(0x21464);
            public static FormLink<IImpactDataSetGetter> BloodSprayImpactSetRed => Construct(0x1f82a);
            public static FormLink<IImpactDataSetGetter> FXMeleeClawMedium => Construct(0x1f272);
            public static FormLink<IImpactDataSetGetter> NPCSabreCatFootBackWalk => Construct(0x1f26d);
            public static FormLink<IImpactDataSetGetter> NPCSkeeverFootBackWalk => Construct(0x1f268);
            public static FormLink<IImpactDataSetGetter> NPCSkeeverFootFrontWalk => Construct(0x1f267);
            public static FormLink<IImpactDataSetGetter> NPCSabreCatFootFrontWalk => Construct(0x1f263);
            public static FormLink<IImpactDataSetGetter> MAGFirebolt01ImpactSet => Construct(0x1c2af);
            public static FormLink<IImpactDataSetGetter> WPNBlockBowImpactSet => Construct(0x193cb);
            public static FormLink<IImpactDataSetGetter> WPNBlockBlunt1HandImpactSet => Construct(0x193ca);
            public static FormLink<IImpactDataSetGetter> WPNBlockAxeImpactSet => Construct(0x193c9);
            public static FormLink<IImpactDataSetGetter> WPNBashAxeImpactSet => Construct(0x193c8);
            public static FormLink<IImpactDataSetGetter> WPNBashBluntImpactSet => Construct(0x193c7);
            public static FormLink<IImpactDataSetGetter> WPNBashBowImpactSet => Construct(0x193c6);
            public static FormLink<IImpactDataSetGetter> WPNzArrowImpactSet => Construct(0x193b9);
            public static FormLink<IImpactDataSetGetter> WPNzAxeImpactSet => Construct(0x193b8);
            public static FormLink<IImpactDataSetGetter> WPNzBluntImpactSet => Construct(0x193b7);
            public static FormLink<IImpactDataSetGetter> WPNBlockBlade1HandImpactSet => Construct(0x189fd);
            public static FormLink<IImpactDataSetGetter> TRPDartImpactSet => Construct(0x189e8);
            public static FormLink<IImpactDataSetGetter> WPNBashBladeImpactSet => Construct(0x183ff);
            public static FormLink<IImpactDataSetGetter> WPNBashShieldHeavyImpactSet => Construct(0x183fe);
            public static FormLink<IImpactDataSetGetter> WPNBashShieldLightImpactSet => Construct(0x183fb);
            public static FormLink<IImpactDataSetGetter> WPNzBlade1HandImpactSet => Construct(0x13cac);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepJumpDownImpact => Construct(0x12f0e);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepSneakLImpactSet => Construct(0x12f0d);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepRunLImpactSet => Construct(0x12f0c);
            public static FormLink<IImpactDataSetGetter> DefaultFootstepWalkLImpactset => Construct(0x12f0b);
        }
    }
}
