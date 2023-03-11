// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class MagicEffect
    {
        private static FormLink<IMagicEffectGetter> Construct(uint id) => new FormLink<IMagicEffectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMagicEffectGetter> DLC01Bot_ReduceRadHealthMax => Construct(0x2e48);
        public static FormLink<IMagicEffectGetter> DLC01Bot_ReduceHealth => Construct(0x2e46);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyResistEnergy => Construct(0x2db1);
        public static FormLink<IMagicEffectGetter> DLC01SmokeBombHazardEffect => Construct(0x2d62);
        public static FormLink<IMagicEffectGetter> DLC01RestoreHealthRepairKit => Construct(0x2acd);
        public static FormLink<IMagicEffectGetter> DLC01BotFrenzyEffect => Construct(0x2a9e);
        public static FormLink<IMagicEffectGetter> DLC01Bot_Unstable_ExplodeHeadEffect => Construct(0x2a9d);
        public static FormLink<IMagicEffectGetter> DLC01Bot_Unstable_FrenzyEffect => Construct(0x2a9c);
        public static FormLink<IMagicEffectGetter> DLC01Bot_Unstable_ExplodeEffect => Construct(0x2a57);
        public static FormLink<IMagicEffectGetter> DLC01Bot_CommonArmorEffect_Unstable => Construct(0x29c8);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_PerceptionConditionEffect => Construct(0x29b4);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyExplosionLimbConditionEffect => Construct(0x29a3);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyLimbConditionEffect => Construct(0x2986);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyMesmetronEffect => Construct(0x2980);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_MesmetronEffect => Construct(0x297d);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyAssaultronHeadLaserEffect => Construct(0x2968);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_AssaultronHeadLaserEffect => Construct(0x2965);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_LeftAttackConditionEffect => Construct(0x2711);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_AV_BurnDamageEffect => Construct(0x26e8);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_AV_StaggerEffect => Construct(0x12a2);
        public static FormLink<IMagicEffectGetter> DLC01Bot_KnockdownEffect => Construct(0x12a1);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_AV_KnockdownEffect => Construct(0x129e);
        public static FormLink<IMagicEffectGetter> DLC01Bot_EnergyDamageEffect => Construct(0x1295);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_AV_EnergyDamageEffect => Construct(0x1294);
        public static FormLink<IMagicEffectGetter> DLC01Bot_CommonArmorEffect => Construct(0x128d);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_AV_RadsDamageEffect => Construct(0x128a);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_AV_PoisonDamageEffect => Construct(0x1288);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_AV_BleedDamageEffect => Construct(0x1255);
        public static FormLink<IMagicEffectGetter> DLC01BotReduceMeleeDamage => Construct(0x1253);
        public static FormLink<IMagicEffectGetter> DLC01BotReconScopeEffect => Construct(0x124d);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_ReconEffect => Construct(0x124b);
        public static FormLink<IMagicEffectGetter> DLC01EnchWeapSelfDamageRadsEffect => Construct(0x1153);
        public static FormLink<IMagicEffectGetter> DLC01DamageRads => Construct(0x1151);
        public static FormLink<IMagicEffectGetter> DLC01abTurretSpotlightRaceEffect => Construct(0xcda);
        public static FormLink<IMagicEffectGetter> DLC01BotReduceCarryWeight => Construct(0x980);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyRadHealthMax => Construct(0x97f);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyResistDamage => Construct(0x97e);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyMeleeDmgEffect => Construct(0x97b);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyHealth => Construct(0x97a);
        public static FormLink<IMagicEffectGetter> DLC01Bot_FortifyCarryWeightEffect => Construct(0x979);
        public static FormLink<IMagicEffectGetter> DLC01SelfDestructOrderEffect => Construct(0x96d);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_RemoveNoCrippleEffect => Construct(0x96b);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_AV_ConditionRateEffect => Construct(0x968);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_HackEffect => Construct(0x1137e);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_LockpickEffect => Construct(0x1137d);
        public static FormLink<IMagicEffectGetter> DLC01RobobrainGhostEffectPlayerFlash => Construct(0x1106e);
        public static FormLink<IMagicEffectGetter> DLC01LvlMechProtectronPod_AbRaceProtectronEffect => Construct(0x10f2a);
        public static FormLink<IMagicEffectGetter> DLC01abSentryOverheatFX => Construct(0x10bbc);
        public static FormLink<IMagicEffectGetter> DLC01abMrHandyRaceEffect => Construct(0x10308);
        public static FormLink<IMagicEffectGetter> FireHazardLightEffectNoFlames => Construct(0x10221);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_Bleep_A_Effect => Construct(0xf6e4);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_SentryEffect => Construct(0xf6e1);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_AssaultronEffect => Construct(0xf6de);
        public static FormLink<IMagicEffectGetter> DLC01RadiationCloakHostileOnly => Construct(0xf662);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_MaleProcessedEffect => Construct(0xf417);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_MaleEffect => Construct(0xf416);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_FemaleProcessedEffect => Construct(0xf415);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_FemaleEffect => Construct(0xf414);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_Bleep_C_Effect => Construct(0xf413);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Voice_Bleep_B_Effect => Construct(0xf410);
        public static FormLink<IMagicEffectGetter> DLC01abAssaultronHeadFX => Construct(0xe9fe);
        public static FormLink<IMagicEffectGetter> DLC01abRobobrainRaceEffect => Construct(0xb851);
        public static FormLink<IMagicEffectGetter> DLC01AssaultronHeadTrapEffect => Construct(0xb812);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Trashbot_CoreVFXEffect => Construct(0xaedb);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Trashbot_LeftArmVFXEffect => Construct(0x9a67);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Trashbot_RightArmVFXEffect => Construct(0x9a66);
        public static FormLink<IMagicEffectGetter> DLC01LairENT_DeconArchHazardRobotShockEffect => Construct(0x8b22);
        public static FormLink<IMagicEffectGetter> DLC01LairENT_DeconArchHazardDeconEffect => Construct(0x8b21);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_SentryRightShoulderFatManEffect => Construct(0x8006);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_SentryLeftShoulderFatManEffect => Construct(0x8004);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_SentryRightLaserGatlingEffect => Construct(0x7fff);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_SentryLeftLaserGatlingEffect => Construct(0x7ffe);
        public static FormLink<IMagicEffectGetter> DLC01Bot_Unstable_abSentryShoulderLeftClusterFX_NOSCRIPT => Construct(0x7b51);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_SentryLeftShoulderFrenzyGasEffect => Construct(0x7b4e);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_SentryRightShoulderFrenzyGasEffect => Construct(0x7b4c);
        public static FormLink<IMagicEffectGetter> DLC01_Unstable_SentryFrenzyGasExplosionEffect => Construct(0x7b49);
        public static FormLink<IMagicEffectGetter> DLC01_Unstable_SentryExplosiveMinigunExplosionDamageEnchEffect => Construct(0x7b36);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_SentryRightExplosiveMinigunEffect => Construct(0x7b25);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable_SentryLeftExplosiveMinigunEffect => Construct(0x7b23);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Unstable__EffectTEMPLATE => Construct(0x797f);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_StealthSpellEffect => Construct(0x73e9);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_ShieldSpellEffect => Construct(0x73e7);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_RadiationSpellEffect => Construct(0x73e5);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_HealSpellEffect => Construct(0x708e);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_EMPSpellEffect => Construct(0x708d);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_DetectionSpellEffect => Construct(0x708b);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_StealthEffect => Construct(0x7089);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_ShieldEffect => Construct(0x7088);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_RadiationEffect => Construct(0x7087);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_HealEffect => Construct(0x7086);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_EMPEffect => Construct(0x7085);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_Cloak_DetectionEffect => Construct(0x7084);
        public static FormLink<IMagicEffectGetter> DLC01Bot_Torso_Misc_Cloak => Construct(0x707d);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_SetScale125Effect => Construct(0x4dfd);
        public static FormLink<IMagicEffectGetter> DLC01AbReduceActorSpeedMult => Construct(0x3e65);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_csRoboBrainEffect => Construct(0x3e18);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_csSentryEffect => Construct(0x3e16);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_csProtectronEffect => Construct(0x3e14);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_csMrHandyEffect => Construct(0x3e12);
        public static FormLink<IMagicEffectGetter> DLC01EnchBot_csAssaultronEffect => Construct(0x3e10);
        public static FormLink<IMagicEffectGetter> DLC01TrackSystem_TrapElectricArcEffect => Construct(0x2767);
        public static FormLink<IMagicEffectGetter> DLC01MBattle_EnchBot_TrashbotPerkEffect => Construct(0x21c0);
        public static FormLink<IMagicEffectGetter> DLC01DamageResistBotShield => Construct(0x2190);
        public static FormLink<IMagicEffectGetter> DLC01abAssaultronHeadFXshield => Construct(0x218d);
        public static FormLink<IMagicEffectGetter> DLC01_EyebotSelfDestructEffect => Construct(0x210a);
        public static FormLink<IMagicEffectGetter> DLC01_SparksCloakHazardEffect => Construct(0x2104);
        public static FormLink<IMagicEffectGetter> DLC01_SparksCloakEffect => Construct(0x2101);
        public static FormLink<IMagicEffectGetter> DLC01LightningHazardEffect => Construct(0xfeb);
    }
}