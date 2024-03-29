﻿using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class ActorValueInformation
    {
        public static FormLink<IActorValueInformationGetter> Aggression => Construct(0x2BC);
        public static FormLink<IActorValueInformationGetter> Confidence => Construct(0x2BD);
        public static FormLink<IActorValueInformationGetter> Energy => Construct(0x2BE);
        public static FormLink<IActorValueInformationGetter> Morality => Construct(0x2BF);
        public static FormLink<IActorValueInformationGetter> Assistance => Construct(0x2C1);
        public static FormLink<IActorValueInformationGetter> AttackConditionAlt1 => Construct(0x2CA);
        public static FormLink<IActorValueInformationGetter> AttackConditionAlt2 => Construct(0x2CB);
        public static FormLink<IActorValueInformationGetter> RotationSpeedCondition => Construct(0x2CE);
        public static FormLink<IActorValueInformationGetter> AttackConditionAlt3 => Construct(0x2CF);
        public static FormLink<IActorValueInformationGetter> WorkshopPowerConnection => Construct(0x2D0);
        public static FormLink<IActorValueInformationGetter> WorkshopID => Construct(0x2D1);
        public static FormLink<IActorValueInformationGetter> AnimationMult => Construct(0x2D2);
        public static FormLink<IActorValueInformationGetter> WeapReloadSpeedMult => Construct(0x2D3);
        public static FormLink<IActorValueInformationGetter> UnusedStamina => Construct(0x2D6);
        public static FormLink<IActorValueInformationGetter> ActionPointsRate => Construct(0x2D8);
        public static FormLink<IActorValueInformationGetter> ConditionRate => Construct(0x2D9);
        public static FormLink<IActorValueInformationGetter> RadsRate => Construct(0x2DB);
        public static FormLink<IActorValueInformationGetter> CritChance => Construct(0x2DD);
        public static FormLink<IActorValueInformationGetter> MeleeDamage => Construct(0x2DE);
        public static FormLink<IActorValueInformationGetter> Mass => Construct(0x2E0);
        public static FormLink<IActorValueInformationGetter> VoiceRate => Construct(0x2E2);
        public static FormLink<IActorValueInformationGetter> MagicResist => Construct(0x2E8);
        public static FormLink<IActorValueInformationGetter> Suspicious => Construct(0x2EC);
        public static FormLink<IActorValueInformationGetter> BloodyMess => Construct(0x2ED);
        public static FormLink<IActorValueInformationGetter> RadHealthMax => Construct(0x2EE);
        public static FormLink<IActorValueInformationGetter> PowerArmorHeadCondition => Construct(0x2EF);
        public static FormLink<IActorValueInformationGetter> PowerArmorTorsoCondition => Construct(0x2F0);
        public static FormLink<IActorValueInformationGetter> PowerArmorLeftArmCondition => Construct(0x2F1);
        public static FormLink<IActorValueInformationGetter> Paralysis => Construct(0x2F2);
        public static FormLink<IActorValueInformationGetter> NightEye => Construct(0x2F4);
        public static FormLink<IActorValueInformationGetter> DetectLifeRange => Construct(0x2F5);
        public static FormLink<IActorValueInformationGetter> WaterWalking => Construct(0x2F7);
        public static FormLink<IActorValueInformationGetter> Fame => Construct(0x2F9);
        public static FormLink<IActorValueInformationGetter> Infamy => Construct(0x2FA);
        public static FormLink<IActorValueInformationGetter> JumpingBonus => Construct(0x2FB);
        public static FormLink<IActorValueInformationGetter> WardPower => Construct(0x2FC);
        public static FormLink<IActorValueInformationGetter> RightItemCharge => Construct(0x2FD);
        public static FormLink<IActorValueInformationGetter> ArmorPerks => Construct(0x2FE);
        public static FormLink<IActorValueInformationGetter> ShieldPerks => Construct(0x2FF);
        public static FormLink<IActorValueInformationGetter> WardDeflection => Construct(0x300);
        public static FormLink<IActorValueInformationGetter> Variable01 => Construct(0x301);
        public static FormLink<IActorValueInformationGetter> Variable02 => Construct(0x302);
        public static FormLink<IActorValueInformationGetter> Variable03 => Construct(0x303);
        public static FormLink<IActorValueInformationGetter> Variable04 => Construct(0x304);
        public static FormLink<IActorValueInformationGetter> Variable05 => Construct(0x305);
        public static FormLink<IActorValueInformationGetter> Variable06 => Construct(0x306);
        public static FormLink<IActorValueInformationGetter> Variable07 => Construct(0x307);
        public static FormLink<IActorValueInformationGetter> Variable08 => Construct(0x308);
        public static FormLink<IActorValueInformationGetter> Variable09 => Construct(0x309);
        public static FormLink<IActorValueInformationGetter> Variable10 => Construct(0x30A);
        public static FormLink<IActorValueInformationGetter> BowSpeedBonus => Construct(0x30B);
        public static FormLink<IActorValueInformationGetter> FavorActive => Construct(0x30C);
        public static FormLink<IActorValueInformationGetter> FavorsPerDay => Construct(0x30D);
        public static FormLink<IActorValueInformationGetter> FavorsPerDayTimer => Construct(0x30E);
        public static FormLink<IActorValueInformationGetter> LeftItemCharge => Construct(0x30F);
        public static FormLink<IActorValueInformationGetter> AbsorbChance => Construct(0x310);
        public static FormLink<IActorValueInformationGetter> Blindness => Construct(0x311);
        public static FormLink<IActorValueInformationGetter> weaponSpeedMult => Construct(0x312);
        public static FormLink<IActorValueInformationGetter> ShoutRecoveryMult => Construct(0x313);
        public static FormLink<IActorValueInformationGetter> BowStaggerBonus => Construct(0x314);
        public static FormLink<IActorValueInformationGetter> Telekinesis => Construct(0x315);
        public static FormLink<IActorValueInformationGetter> FavorPointsBonus => Construct(0x316);
        public static FormLink<IActorValueInformationGetter> LastBribedIntimidated => Construct(0x317);
        public static FormLink<IActorValueInformationGetter> LastFlattered => Construct(0x318);
        public static FormLink<IActorValueInformationGetter> MovementNoiseMult => Construct(0x319);
        public static FormLink<IActorValueInformationGetter> BypassVendorStolenCheck => Construct(0x31A);
        public static FormLink<IActorValueInformationGetter> BypassVendorKeywordCheck => Construct(0x31B);
        public static FormLink<IActorValueInformationGetter> WaitingForPlayer => Construct(0x31C);
        public static FormLink<IActorValueInformationGetter> SkillMagAV01 => Construct(0x31D);
        public static FormLink<IActorValueInformationGetter> SkillMagAV02 => Construct(0x31E);
        public static FormLink<IActorValueInformationGetter> SkillMagAV03 => Construct(0x31F);
        public static FormLink<IActorValueInformationGetter> SkillMagAV04 => Construct(0x320);
        public static FormLink<IActorValueInformationGetter> SkillMagAV05 => Construct(0x321);
        public static FormLink<IActorValueInformationGetter> SkillMagAV06 => Construct(0x322);
        public static FormLink<IActorValueInformationGetter> SkillMagAV07 => Construct(0x323);
        public static FormLink<IActorValueInformationGetter> SkillMagAV08 => Construct(0x324);
        public static FormLink<IActorValueInformationGetter> SkillMagAV09 => Construct(0x325);
        public static FormLink<IActorValueInformationGetter> SkillMagAV10 => Construct(0x326);
        public static FormLink<IActorValueInformationGetter> SkillMagAV11 => Construct(0x327);
        public static FormLink<IActorValueInformationGetter> SkillMagAV12 => Construct(0x328);
        public static FormLink<IActorValueInformationGetter> SkillMagAV13 => Construct(0x329);
        public static FormLink<IActorValueInformationGetter> SkillMagAV14 => Construct(0x32A);
        public static FormLink<IActorValueInformationGetter> SkillMagAV15 => Construct(0x32B);
        public static FormLink<IActorValueInformationGetter> KARMA => Construct(0x32C);
        public static FormLink<IActorValueInformationGetter> Deafness => Construct(0x32D);
        public static FormLink<IActorValueInformationGetter> PowerGenerated => Construct(0x32E);
        public static FormLink<IActorValueInformationGetter> PowerRadiation => Construct(0x32F);
        public static FormLink<IActorValueInformationGetter> PowerRequired => Construct(0x330);
        public static FormLink<IActorValueInformationGetter> Food => Construct(0x331);
        public static FormLink<IActorValueInformationGetter> Water => Construct(0x332);
        public static FormLink<IActorValueInformationGetter> Bed => Construct(0x334);
        public static FormLink<IActorValueInformationGetter> Happiness => Construct(0x335);
        public static FormLink<IActorValueInformationGetter> Artillery => Construct(0x336);
        public static FormLink<IActorValueInformationGetter> WorkshopItemOverlap => Construct(0x337);
        public static FormLink<IActorValueInformationGetter> LogicOperation => Construct(0x338);
        public static FormLink<IActorValueInformationGetter> WorkshopItemClampDirection => Construct(0x339);
        public static FormLink<IActorValueInformationGetter> WorkshopItemZOffset => Construct(0x33A);
        public static FormLink<IActorValueInformationGetter> WorkshopActorWounded => Construct(0x33B);
        public static FormLink<IActorValueInformationGetter> WorkshopPlayerOwned => Construct(0x33C);
        public static FormLink<IActorValueInformationGetter> WorkshopStackableItem => Construct(0x33D);
        public static FormLink<IActorValueInformationGetter> WorkshopSnapPointRadius => Construct(0x33E);
        public static FormLink<IActorValueInformationGetter> WorkshopAnythingIsGround => Construct(0x33F);
        public static FormLink<IActorValueInformationGetter> IgnorePlayerWhileFrenzied => Construct(0x340);
        public static FormLink<IActorValueInformationGetter> leftWeaponSpeedMult => Construct(0x341);
        public static FormLink<IActorValueInformationGetter> DragonSouls => Construct(0x342);
        public static FormLink<IActorValueInformationGetter> CombatHealthRegenMult => Construct(0x343);
        public static FormLink<IActorValueInformationGetter> FollowerDistance => Construct(0x345);
        public static FormLink<IActorValueInformationGetter> FollowerStance => Construct(0x346);
        public static FormLink<IActorValueInformationGetter> FollowerStanceAllowCombatOverride => Construct(0x347);
        public static FormLink<IActorValueInformationGetter> WorkshopCurrentTriangles => Construct(0x348);
        public static FormLink<IActorValueInformationGetter> WorkshopMaxTriangles => Construct(0x349);
        public static FormLink<IActorValueInformationGetter> WorkshopCurrentDraws => Construct(0x34A);
        public static FormLink<IActorValueInformationGetter> WorkshopMaxDraws => Construct(0x34B);
        public static FormLink<IActorValueInformationGetter> WorkshopIgnoreSimpleIntersections => Construct(0x34D);
        public static FormLink<IActorValueInformationGetter> WorkshopAllowUnsupportedStacking => Construct(0x34E);
        public static FormLink<IActorValueInformationGetter> Fatigue => Construct(0x34F);
        public static FormLink<IActorValueInformationGetter> FatigueAPMax => Construct(0x350);
        public static FormLink<IActorValueInformationGetter> FatigueRate => Construct(0x351);
        public static FormLink<IActorValueInformationGetter> FatigueRateMult => Construct(0x352);
        public static FormLink<IActorValueInformationGetter> LogicOutput => Construct(0x353);
        public static FormLink<IActorValueInformationGetter> WorkshopSnapTransmitsPower => Construct(0x354);
        public static FormLink<IActorValueInformationGetter> RadsRateMult => Construct(0x355);
        public static FormLink<IActorValueInformationGetter> DragonRend => Construct(0x356);
        public static FormLink<IActorValueInformationGetter> AttackDamageMult => Construct(0x357);
        public static FormLink<IActorValueInformationGetter> ActionPointsRateMult => Construct(0x359);
        public static FormLink<IActorValueInformationGetter> ConditionRateMult => Construct(0x35A);
        public static FormLink<IActorValueInformationGetter> PowerArmorBattery => Construct(0x35C);
        public static FormLink<IActorValueInformationGetter> PowerArmorRightArmCondition => Construct(0x35D);
        public static FormLink<IActorValueInformationGetter> PowerArmorLeftLegCondition => Construct(0x35E);
        public static FormLink<IActorValueInformationGetter> ReflectDamage => Construct(0x35F);
        public static FormLink<IActorValueInformationGetter> CraftingAbilityGeneral => Construct(0x360);
        public static FormLink<IActorValueInformationGetter> CraftingAbilityExplosives => Construct(0x361);
        public static FormLink<IActorValueInformationGetter> CraftingAbilityGuns => Construct(0x362);
        public static FormLink<IActorValueInformationGetter> CraftingAbilityMechanics => Construct(0x363);
        public static FormLink<IActorValueInformationGetter> CraftingAbilityMedicine => Construct(0x364);
        public static FormLink<IActorValueInformationGetter> CraftingAbilityMelee => Construct(0x365);
        public static FormLink<IActorValueInformationGetter> CraftingAbilityScience => Construct(0x366);
        public static FormLink<IActorValueInformationGetter> CraftingAbilitySurvival => Construct(0x367);
        public static FormLink<IActorValueInformationGetter> ComponentUsageMultChemical => Construct(0x368);
        public static FormLink<IActorValueInformationGetter> ComponentUsageMultMetallic => Construct(0x369);
        public static FormLink<IActorValueInformationGetter> ComponentUsageMultOrganic => Construct(0x36A);
        public static FormLink<IActorValueInformationGetter> ComponentUsageMultTechnical => Construct(0x36B);
        public static FormLink<IActorValueInformationGetter> AvailableCondition1 => Construct(0x373);
        public static FormLink<IActorValueInformationGetter> AvailableCondition2 => Construct(0x374);
        public static FormLink<IActorValueInformationGetter> OneHandedWeapons => Construct(0x376);
        public static FormLink<IActorValueInformationGetter> TwoHandedWeapons => Construct(0x377);
        public static FormLink<IActorValueInformationGetter> Marksman => Construct(0x378);
        public static FormLink<IActorValueInformationGetter> Block => Construct(0x379);
        public static FormLink<IActorValueInformationGetter> Smithing => Construct(0x37A);
        public static FormLink<IActorValueInformationGetter> HeavyArmor => Construct(0x37B);
        public static FormLink<IActorValueInformationGetter> LightArmor => Construct(0x37C);
        public static FormLink<IActorValueInformationGetter> PickPocket => Construct(0x37D);
        public static FormLink<IActorValueInformationGetter> Lockpicking => Construct(0x37E);
        public static FormLink<IActorValueInformationGetter> Sneak => Construct(0x37F);
        public static FormLink<IActorValueInformationGetter> Alchemy => Construct(0x380);
        public static FormLink<IActorValueInformationGetter> Speechcraft => Construct(0x381);
        public static FormLink<IActorValueInformationGetter> Alteration => Construct(0x382);
        public static FormLink<IActorValueInformationGetter> Conjuration => Construct(0x383);
        public static FormLink<IActorValueInformationGetter> Destruction => Construct(0x384);
        public static FormLink<IActorValueInformationGetter> Illusion => Construct(0x385);
        public static FormLink<IActorValueInformationGetter> Restoration => Construct(0x386);
        public static FormLink<IActorValueInformationGetter> Enchanting => Construct(0x387);
        public static FormLink<IActorValueInformationGetter> PowerArmorRightLegCondition => Construct(0x388);
        public static FormLink<IActorValueInformationGetter> VANSPerk => Construct(0x389);
    }
}