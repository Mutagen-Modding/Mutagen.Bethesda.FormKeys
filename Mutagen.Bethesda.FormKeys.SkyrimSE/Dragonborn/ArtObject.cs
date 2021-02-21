using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class ArtObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IArtObjectGetter> Construct(uint id) => new FormLink<IArtObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArtObjectGetter> DLC2DragonAspectBurst => Construct(0x3d58e);
            public static FormLink<IArtObjectGetter> DLC2ApocryphaHealTargetFX => Construct(0x3d3bd);
            public static FormLink<IArtObjectGetter> BoundDaggerEnchEffects => Construct(0x3d37a);
            public static FormLink<IArtObjectGetter> DLC2MiraakAbsorbManO => Construct(0x3d308);
            public static FormLink<IArtObjectGetter> DLC2MiraakAbsorbO => Construct(0x3d307);
            public static FormLink<IArtObjectGetter> DLC2MiraakStreakO => Construct(0x3d21d);
            public static FormLink<IArtObjectGetter> DLC2BenthicLurkerWhipDustSnowO => Construct(0x3ceff);
            public static FormLink<IArtObjectGetter> DLC2BenthicTenticleStompO => Construct(0x3cefd);
            public static FormLink<IArtObjectGetter> DLC2ApocryphaCastingFX => Construct(0x3cd85);
            public static FormLink<IArtObjectGetter> DLC2MorasGraspFloorArtO => Construct(0x3a298);
            public static FormLink<IArtObjectGetter> DLC2TelMithrynTeleportTargetFX => Construct(0x39fba);
            public static FormLink<IArtObjectGetter> DLC2MiraakSwordTentaclesO => Construct(0x397f5);
            public static FormLink<IArtObjectGetter> DLC2BallistaCenturionParticlesO => Construct(0x397ea);
            public static FormLink<IArtObjectGetter> DLC2SummonKarstaagTargetFX => Construct(0x3925f);
            public static FormLink<IArtObjectGetter> DLC2TenticleBookAttachO => Construct(0x3843c);
            public static FormLink<IArtObjectGetter> DLC2AshSpawnParticlesO => Construct(0x32fea);
            public static FormLink<IArtObjectGetter> DLC2BookTentacleTrimO => Construct(0x323f0);
            public static FormLink<IArtObjectGetter> DLC2MiraakSelfAttachFXMQ01 => Construct(0x317d5);
            public static FormLink<IArtObjectGetter> DLC2AshSpawnSmokeFX => Construct(0x2c29f);
            public static FormLink<IArtObjectGetter> DLC2Ashspawn01HandEffects => Construct(0x2c299);
            public static FormLink<IArtObjectGetter> DLC2BenthicLurkerWhipDustO => Construct(0x2b0fe);
            public static FormLink<IArtObjectGetter> DLC2BenthicTenticleHandRightO => Construct(0x2ad06);
            public static FormLink<IArtObjectGetter> DLC2BenthicTenticleHandLeftO => Construct(0x2ad05);
            public static FormLink<IArtObjectGetter> DLC2BenthicLurkerTenticleMouthO => Construct(0x2ad03);
            public static FormLink<IArtObjectGetter> DLC2ApocryphaRewardCastingFX => Construct(0x29a24);
            public static FormLink<IArtObjectGetter> DLC2dunInstrumentsObj => Construct(0x29696);
            public static FormLink<IArtObjectGetter> DLC2BurntSprigganParticlesO => Construct(0x29681);
            public static FormLink<IArtObjectGetter> DLC2MiraakTeleportReturnTargetFX => Construct(0x28b38);
            public static FormLink<IArtObjectGetter> DLC2AshGuardianSmokeCloakObject => Construct(0x27e2f);
            public static FormLink<IArtObjectGetter> DLC2FXWhirlWindHandEffects => Construct(0x27c30);
            public static FormLink<IArtObjectGetter> DLC2AshGuardianFXEffect => Construct(0x27bfd);
            public static FormLink<IArtObjectGetter> DLC2AshCasting => Construct(0x27bf7);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderPackmuleCastingArt => Construct(0x274a3);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderOilCastingArt => Construct(0x2749b);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderGlowingCastingArt => Construct(0x27492);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderGlowingActorFX => Construct(0x27481);
            public static FormLink<IArtObjectGetter> dlc2DBDragonBreathCastBodyFX => Construct(0x265a7);
            public static FormLink<IArtObjectGetter> DLC2MiraakTeleportTargetFX => Construct(0x25e11);
            public static FormLink<IArtObjectGetter> DLC2WhirlWindFXCloak01 => Construct(0x2502b);
            public static FormLink<IArtObjectGetter> DLC2HMDaedraHandEffects => Construct(0x24fbe);
            public static FormLink<IArtObjectGetter> DLC2HMDaedraFXMouth01 => Construct(0x24fbd);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderShockDeadCastingArt => Construct(0x20967);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderShockCloakCastingArt => Construct(0x20966);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderShockCastingArt => Construct(0x20965);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderFrostDeadCastingArt => Construct(0x206d6);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderFrostCloakCastingArt => Construct(0x206d5);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderFrostCastingArt => Construct(0x206d4);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderPoisonCloakCastingArt => Construct(0x200ca);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderFireCloakCastingArt => Construct(0x1ff41);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderZombieCastingArt => Construct(0x195e7);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderFireDeadCastingArt => Construct(0x195e5);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderFireCastingArt => Construct(0x195e4);
            public static FormLink<IArtObjectGetter> DLC02VolcAshFXCameraAttachAsh01_object => Construct(0x18473);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderFaceGrabObject => Construct(0x16e16);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderPoisonDeadCastingArt => Construct(0x145d1);
            public static FormLink<IArtObjectGetter> DLC2ExpSpiderPoisonCastingArt => Construct(0x1448a);
        }
    }
}
