using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Message
        {
            private static FormLink<IMessageGetter> Construct(uint id) => new FormLink<IMessageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMessageGetter> DLC1ReflexesReadyMessage => Construct(0x14cf4);
            public static FormLink<IMessageGetter> DLC1ReflexesWaitMessage => Construct(0x14cf3);
            public static FormLink<IMessageGetter> DLC1MistformWaitMessage => Construct(0x14cb6);
            public static FormLink<IMessageGetter> DLC1MistformReadyMessage => Construct(0x14cb5);
            public static FormLink<IMessageGetter> DLC1VampireTutorialRevert => Construct(0x14756);
            public static FormLink<IMessageGetter> PortalGemPlaceMessageToParagonPlatform => Construct(0x12fe2);
            public static FormLink<IMessageGetter> PortalGemPlaceMessageToInnerSanctum => Construct(0x12fe1);
            public static FormLink<IMessageGetter> PortalGemPlaceMessageToForgottenValeOverlook => Construct(0x12fe0);
            public static FormLink<IMessageGetter> PortalGemPlaceMessageToForgottenValeForest => Construct(0x12fdf);
            public static FormLink<IMessageGetter> PortalGemPlaceMessageToDarkfallGrotto => Construct(0x12fde);
            public static FormLink<IMessageGetter> PortalGemPlaceMessageToGlacialCrevice => Construct(0x12fdd);
            public static FormLink<IMessageGetter> DLC1VQ07BasinCombatMessage => Construct(0x12913);
            public static FormLink<IMessageGetter> DLC1_BF_TravelToNameMessage => Construct(0x12448);
            public static FormLink<IMessageGetter> DLC1VampTutorialRecapPerks => Construct(0x11ee1);
            public static FormLink<IMessageGetter> DLC1VampTutorialRecapLand => Construct(0x11ee0);
            public static FormLink<IMessageGetter> DLC1VampireTutorialPerks => Construct(0x11edf);
            public static FormLink<IMessageGetter> DLC1PortalMessageWSValleyStart => Construct(0x11aa2);
            public static FormLink<IMessageGetter> DLC1PortalMessageWSDarkfallCave => Construct(0x11aa1);
            public static FormLink<IMessageGetter> DLC1PortalMessageWSDarkfallPassage => Construct(0x11aa0);
            public static FormLink<IMessageGetter> DLC1PortalMessageWSTemple => Construct(0x11a9f);
            public static FormLink<IMessageGetter> DLC1PortalMessageWS00 => Construct(0x11a9e);
            public static FormLink<IMessageGetter> DLC1PortalMessageWS04 => Construct(0x11a9d);
            public static FormLink<IMessageGetter> DLC1PortalMessageWS03 => Construct(0x11a9c);
            public static FormLink<IMessageGetter> DLC1PortalMessageWS02 => Construct(0x11a9b);
            public static FormLink<IMessageGetter> DLC1PortalMessageWS01 => Construct(0x11a9a);
            public static FormLink<IMessageGetter> DLC1BatsReadyMessage => Construct(0x119ea);
            public static FormLink<IMessageGetter> DLC1BatsWaitMessage => Construct(0x119b0);
            public static FormLink<IMessageGetter> DLC1AltarAurielMsg => Construct(0x1139d);
            public static FormLink<IMessageGetter> DLC1VampireTutorialFavorites => Construct(0x10f8c);
            public static FormLink<IMessageGetter> HelpVampirism => Construct(0x10d83);
            public static FormLink<IMessageGetter> DLC1TrapCrossbowNeededMessage => Construct(0x10d82);
            public static FormLink<IMessageGetter> DLC1VQ01PuzzleRoomVampireBossName => Construct(0xfc10);
            public static FormLink<IMessageGetter> DLC1NoNameAlias => Construct(0xd653);
            public static FormLink<IMessageGetter> DLC1RadiantVampireLordTxtReplace => Construct(0x420b);
            public static FormLink<IMessageGetter> DLC1VQ03BarrierMessage => Construct(0x3d7e);
            public static FormLink<IMessageGetter> DLC01lightningRodPromptBox => Construct(0x2924);
            public static FormLink<IMessageGetter> DLC01SoulCairnFissureMessageFailure => Construct(0x2846);
            public static FormLink<IMessageGetter> DLC01SoulCairnFissureMessageSuccess => Construct(0x2845);
            public static FormLink<IMessageGetter> DLC1LD_BthalftForgeFailMessage02 => Construct(0x1aa21);
            public static FormLink<IMessageGetter> DLC1LD_BthalftForgeFailMessage01 => Construct(0x1aa20);
            public static FormLink<IMessageGetter> DLC1VampireTutorialLand => Construct(0x1a41a);
            public static FormLink<IMessageGetter> DLC1VampireTutorialTransform => Construct(0x1a419);
            public static FormLink<IMessageGetter> PortalGemPlaceMessageToUnknown => Construct(0x19ad4);
            public static FormLink<IMessageGetter> PortalGemPlaceMessageDENIED => Construct(0x19ac0);
            public static FormLink<IMessageGetter> PortalGemPlaceMessage => Construct(0x19abf);
            public static FormLink<IMessageGetter> DLC1_WESC_VigilantVampireHunterNameDUPLICATE001 => Construct(0x1993f);
            public static FormLink<IMessageGetter> DLC1VampLordMeleeMode => Construct(0x191eb);
            public static FormLink<IMessageGetter> DLC1VampLordTransform => Construct(0x191ea);
            public static FormLink<IMessageGetter> CharGenJumpDUPLICATE001 => Construct(0x191e9);
            public static FormLink<IMessageGetter> DLC1TrollFollowerDismissedMsg => Construct(0x1881a);
            public static FormLink<IMessageGetter> dlc1VQ01nothingHappenedMSG => Construct(0x17771);
            public static FormLink<IMessageGetter> DLC1dunRedwaterDenCageVampireName1 => Construct(0x16364);
            public static FormLink<IMessageGetter> DLC1WerewolfPerkEarned => Construct(0x1571d);
            public static FormLink<IMessageGetter> DLC1VampirePerkEarned => Construct(0x1571c);
            public static FormLink<IMessageGetter> DLC1LD_BthalftValveFailMessage => Construct(0x15404);
            public static FormLink<IMessageGetter> DLC1LD_PedestalFailCombatMessage => Construct(0x14f1e);
            public static FormLink<IMessageGetter> DLC1dunRedwaterDenBossName => Construct(0x14c82);
            public static FormLink<IMessageGetter> DLC1dunRedwaterDenVHQBloodMessage => Construct(0x149ac);
            public static FormLink<IMessageGetter> DLC1dunRedwaterDenTaintedBloodMessage => Construct(0x149ab);
            public static FormLink<IMessageGetter> DLC1VCMoondialNoTileMessage => Construct(0x1171c);
            public static FormLink<IMessageGetter> DLC1VQ01WontBudge => Construct(0xf7f1);
            public static FormLink<IMessageGetter> DLC1VQ04BowlNotRightMessage => Construct(0xd3f1);
            public static FormLink<IMessageGetter> DLC1VQ04IngredientTooMuchMessage => Construct(0xd3f0);
            public static FormLink<IMessageGetter> DLC1VCBalcony2 => Construct(0xd168);
            public static FormLink<IMessageGetter> DLC1VCBalcony1 => Construct(0xd167);
            public static FormLink<IMessageGetter> DLC1LD_PedestalFailMessage => Construct(0xd00c);
            public static FormLink<IMessageGetter> DLC1VCShip2 => Construct(0xbde0);
            public static FormLink<IMessageGetter> DLC1VCShip1 => Construct(0xbddf);
            public static FormLink<IMessageGetter> DLC1ShovelFailureMessage => Construct(0xb699);
            public static FormLink<IMessageGetter> DLC1SeranaCloakingMessage => Construct(0xb67d);
            public static FormLink<IMessageGetter> DLC1LD_ShardName => Construct(0xb643);
            public static FormLink<IMessageGetter> DLC1FeedPointsMsg => Construct(0xa26f);
            public static FormLink<IMessageGetter> DLC1BloodPointsMsg => Construct(0xa26d);
            public static FormLink<IMessageGetter> DLC1dunRedwaterDenLookoutName => Construct(0x98e7);
            public static FormLink<IMessageGetter> DLC1dunRedwaterDenAttendantName2 => Construct(0x98dd);
            public static FormLink<IMessageGetter> DLC1dunRedwaterDenAttendantName1 => Construct(0x98dc);
            public static FormLink<IMessageGetter> DLC1dunRedwaterDenBouncerName => Construct(0x98db);
            public static FormLink<IMessageGetter> DLC1NightPowerShrineMessage => Construct(0x9407);
            public static FormLink<IMessageGetter> DLC1BloodMagicShrineMessage => Construct(0x9406);
            public static FormLink<IMessageGetter> DLC1VQ06TreeMessage => Construct(0x905a);
            public static FormLink<IMessageGetter> DLC1VQ06KnifeMessage => Construct(0x9059);
            public static FormLink<IMessageGetter> DLC1VQ06TempMessage => Construct(0x9052);
            public static FormLink<IMessageGetter> DLC1VampireSleepMsg => Construct(0x8e3c);
            public static FormLink<IMessageGetter> DLC1PlayerVampireFeedMessage => Construct(0x71d4);
            public static FormLink<IMessageGetter> DLC1PlayerVampireExpirationWarning => Construct(0x71d1);
            public static FormLink<IMessageGetter> DLC1VQ04DoorBounceMessage => Construct(0x3c5d);
            public static FormLink<IMessageGetter> DLC1VQ04BowlFullMessage => Construct(0x3c58);
            public static FormLink<IMessageGetter> DLC1_WESC06_NonDawnguardName => Construct(0x350a);
            public static FormLink<IMessageGetter> DLC1_WESC02_VigilantName => Construct(0x34f4);
        }
    }
}
