using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Faction
        {
            private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFactionGetter> DLC1VampireFeedNoCrimeFaction => Construct(0x14cbd);
            public static FormLink<IFactionGetter> DLC1MothPriestCrimeFaction => Construct(0x14b5b);
            public static FormLink<IFactionGetter> DLC1GunmarFaction => Construct(0x14638);
            public static FormLink<IFactionGetter> DLC1WE01AttackPlayerFaction => Construct(0x145c3);
            public static FormLink<IFactionGetter> DLC1VampireSeductionBoostFaction => Construct(0x1459e);
            public static FormLink<IFactionGetter> DLC1_BF_BossFightFaction => Construct(0x13814);
            public static FormLink<IFactionGetter> DLC1LD_AetherialStaffBusyFaction => Construct(0x1380f);
            public static FormLink<IFactionGetter> DLC1SeranaCrimeFaction => Construct(0x137ba);
            public static FormLink<IFactionGetter> DLC1VQDoorBlockerFaction => Construct(0x12eab);
            public static FormLink<IFactionGetter> DLC1TutorialFaction => Construct(0x12d13);
            public static FormLink<IFactionGetter> DLC1VQ08HunterSiegeFaction => Construct(0x12cd7);
            public static FormLink<IFactionGetter> DLC1VQ08VampireSiegeFaction => Construct(0x12c2e);
            public static FormLink<IFactionGetter> DLC1VampireCastleDoorFaction => Construct(0x123e6);
            public static FormLink<IFactionGetter> DLC1VQ02LockedDoorFaction => Construct(0x11e2e);
            public static FormLink<IFactionGetter> DLC1WE08SpecialCombatFaction => Construct(0x11be3);
            public static FormLink<IFactionGetter> DLC1UndeadGuardianFaction => Construct(0x11be2);
            public static FormLink<IFactionGetter> DLC1DawnguardExteriorGuardFaction => Construct(0x10ec1);
            public static FormLink<IFactionGetter> DLC1dunHarkonBattleEnemyFaction => Construct(0xfc7e);
            public static FormLink<IFactionGetter> DLC1dunHarkonBattleAllyFaction => Construct(0xe65d);
            public static FormLink<IFactionGetter> DLC1VQ01ChatterFaction => Construct(0xd921);
            public static FormLink<IFactionGetter> DLC1VQ03FightFaction => Construct(0x4246);
            public static FormLink<IFactionGetter> DLC1HireableDogFaction => Construct(0x1aa75);
            public static FormLink<IFactionGetter> DLC1VQ01DraugrFaction => Construct(0x1a52c);
            public static FormLink<IFactionGetter> SoulCairnSummonedBonemenFaction => Construct(0x19c5b);
            public static FormLink<IFactionGetter> DLC1DexionThrall => Construct(0x19818);
            public static FormLink<IFactionGetter> DLC1VampireCompanionFaction => Construct(0x18c4f);
            public static FormLink<IFactionGetter> DLC1VQ01CaptiveFaction => Construct(0x18819);
            public static FormLink<IFactionGetter> DLC1VQ01PuzzleRoomVampireFaction => Construct(0x18818);
            public static FormLink<IFactionGetter> DLC1SeranaFaction => Construct(0x183a5);
            public static FormLink<IFactionGetter> DLC1VampireCrimeFaction => Construct(0x17f71);
            public static FormLink<IFactionGetter> DLC1VQ03InnkeepersFaction => Construct(0x17a07);
            public static FormLink<IFactionGetter> DLC1FerrySystemFaction => Construct(0x16849);
            public static FormLink<IFactionGetter> DLC1GeleborFaction => Construct(0x1681b);
            public static FormLink<IFactionGetter> DLC1ThrallFaction => Construct(0x162f7);
            public static FormLink<IFactionGetter> SoulCairnSpecialFaction => Construct(0x1603e);
            public static FormLink<IFactionGetter> DLC1RadiantDisguisedFollowPlayerFaction => Construct(0x15758);
            public static FormLink<IFactionGetter> DLC1RadiantDisguisedVampireFactionAdvisor => Construct(0x15755);
            public static FormLink<IFactionGetter> DLC1RadiantDisguisedVampireFactionPilgrim => Construct(0x15754);
            public static FormLink<IFactionGetter> DLC1RadiantDisguisedVampireFactionMerchant => Construct(0x15753);
            public static FormLink<IFactionGetter> DLC1RadiantDisguisedHunterFactionPilgrim => Construct(0x15752);
            public static FormLink<IFactionGetter> DLC1RadiantDisguisedHunterFactionMerchant => Construct(0x15751);
            public static FormLink<IFactionGetter> DLC1RadiantDisguisedVampireFactionBard => Construct(0x15750);
            public static FormLink<IFactionGetter> DLC1RadiantDisguisedHunterFactionBard => Construct(0x1574f);
            public static FormLink<IFactionGetter> SoulCairnSoulFaction => Construct(0x150b0);
            public static FormLink<IFactionGetter> DLC1_WESC09Faction => Construct(0x14bfa);
            public static FormLink<IFactionGetter> DLC1LD_KatriaFaction => Construct(0x146c0);
            public static FormLink<IFactionGetter> DLC1RV07CoffinOwnerFaction => Construct(0x14351);
            public static FormLink<IFactionGetter> DLC1TurningIntoVampireFaction => Construct(0x142e7);
            public static FormLink<IFactionGetter> DLC1PotentialVampireFaction => Construct(0x142e6);
            public static FormLink<IFactionGetter> DLC1DawnguardFaction => Construct(0x14217);
            public static FormLink<IFactionGetter> DLC1HunterBaseIntroBearFaction => Construct(0x13cf6);
            public static FormLink<IFactionGetter> DLC1dunRedwaterDenMerchant => Construct(0x1393f);
            public static FormLink<IFactionGetter> DLC1RuunvaldFaction => Construct(0x135bd);
            public static FormLink<IFactionGetter> DLC1WEJS06EnemiesFaction => Construct(0x127ef);
            public static FormLink<IFactionGetter> DLC1ServicesRonthil => Construct(0x1047f);
            public static FormLink<IFactionGetter> DLC1ServicesHestla => Construct(0x1047e);
            public static FormLink<IFactionGetter> DLC1ServicesFeran => Construct(0x1047d);
            public static FormLink<IFactionGetter> DLC1ServicesFlorentius => Construct(0xf82d);
            public static FormLink<IFactionGetter> DLC1ServicesGunmar => Construct(0xf827);
            public static FormLink<IFactionGetter> DLC1ServicesSorineJurard => Construct(0xf1a7);
            public static FormLink<IFactionGetter> DLC1RadiantQuestgiverTopicFaction => Construct(0xc3cc);
            public static FormLink<IFactionGetter> DLC1RV07ThankFaction => Construct(0xb544);
            public static FormLink<IFactionGetter> DLC1PriestEscortVampires => Construct(0x7f51);
            public static FormLink<IFactionGetter> DLC1dunRedwaterDenFaction => Construct(0x8e1e);
            public static FormLink<IFactionGetter> DLC1PriestCampVigilants => Construct(0x8876);
            public static FormLink<IFactionGetter> DLC1PriestEscortVigilants => Construct(0x8875);
            public static FormLink<IFactionGetter> DLC1MothPriestFaction => Construct(0x8874);
            public static FormLink<IFactionGetter> DLC1DurnehviirEnemyFaction => Construct(0x83a6);
            public static FormLink<IFactionGetter> DLC1DurnehviirFaction => Construct(0x83a5);
            public static FormLink<IFactionGetter> DLC1ValericaEnemyFaction => Construct(0x83a3);
            public static FormLink<IFactionGetter> DLC1ValericaFaction => Construct(0x83a2);
            public static FormLink<IFactionGetter> DLC1RadiantVampireBanditNecroAllys => Construct(0x7c41);
            public static FormLink<IFactionGetter> SoulCairnFaction => Construct(0x7a66);
            public static FormLink<IFactionGetter> DLC1PlayerVampireLordFaction => Construct(0x71d3);
            public static FormLink<IFactionGetter> DLC1VampireIntroEnemyFaction => Construct(0x5e37);
            public static FormLink<IFactionGetter> DLC1PlayerTurnedVampire => Construct(0x588d);
            public static FormLink<IFactionGetter> DLC1RV01TargetFaction => Construct(0x4c2d);
            public static FormLink<IFactionGetter> DLC1RadiantQuestGiver => Construct(0x4c27);
            public static FormLink<IFactionGetter> DLC1VampireFaction => Construct(0x3376);
            public static FormLink<IFactionGetter> DLC1HunterFaction => Construct(0x3375);
        }
    }
}
