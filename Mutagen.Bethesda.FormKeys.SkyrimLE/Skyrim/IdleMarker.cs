using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class IdleMarker
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IIdleMarkerGetter> Construct(uint id) => new FormLink<IIdleMarkerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIdleMarkerGetter> TG00IdleSellMarker => Construct(0x173b7);
            public static FormLink<IIdleMarkerGetter> DogLayingDownIdleMarker => Construct(0x10f801);
            public static FormLink<IIdleMarkerGetter> BearSleepIdle => Construct(0x10de3a);
            public static FormLink<IIdleMarkerGetter> RiftenBolliFisheryIdleMarker => Construct(0x10cd33);
            public static FormLink<IIdleMarkerGetter> RiftenIndarynMeaderyIdleMarker => Construct(0x10cc26);
            public static FormLink<IIdleMarkerGetter> TenseIdleMarker => Construct(0x10bed8);
            public static FormLink<IIdleMarkerGetter> StudyMarker => Construct(0x106a6e);
            public static FormLink<IIdleMarkerGetter> DBSoupServeIdleMarker => Construct(0x104805);
            public static FormLink<IIdleMarkerGetter> DBStudyIdleMarker => Construct(0x104804);
            public static FormLink<IIdleMarkerGetter> DBStudydleMarker => Construct(0x104803);
            public static FormLink<IIdleMarkerGetter> DBExamineIdleMarker => Construct(0x104802);
            public static FormLink<IIdleMarkerGetter> MQ201HoldingDrinkTrayIdleMarker => Construct(0x1036f8);
            public static FormLink<IIdleMarkerGetter> CrossedArmsIdleMarker => Construct(0x101995);
            public static FormLink<IIdleMarkerGetter> SearchingBodyIdleMarker => Construct(0x101588);
            public static FormLink<IIdleMarkerGetter> SearchingTableandChestIdleMarker => Construct(0x10082e);
            public static FormLink<IIdleMarkerGetter> ChickenFeedingMarker => Construct(0xfa6e4);
            public static FormLink<IIdleMarkerGetter> DrinkPotionIdleMarker => Construct(0xf9966);
            public static FormLink<IIdleMarkerGetter> MulushIdleMarker => Construct(0xf993d);
            public static FormLink<IIdleMarkerGetter> CleanWeaponIdleMarker => Construct(0xf9663);
            public static FormLink<IIdleMarkerGetter> ComeThisWay => Construct(0xf6ee8);
            public static FormLink<IIdleMarkerGetter> GreybeardWordTeach => Construct(0xf6ee5);
            public static FormLink<IIdleMarkerGetter> BlowHornImperial => Construct(0xf6ee0);
            public static FormLink<IIdleMarkerGetter> BlowHornStormcloak => Construct(0xf6edf);
            public static FormLink<IIdleMarkerGetter> MQ206FelldirMarker => Construct(0xf3aa2);
            public static FormLink<IIdleMarkerGetter> T02AscendMaleMarker => Construct(0xf3a9d);
            public static FormLink<IIdleMarkerGetter> T02AscendFemaleMarker => Construct(0xf3a9b);
            public static FormLink<IIdleMarkerGetter> DwemerExtractorMarker => Construct(0xf3a96);
            public static FormLink<IIdleMarkerGetter> WarmHandsCrouchIdleMarker => Construct(0xe8645);
            public static FormLink<IIdleMarkerGetter> WarmHandsStandIdleMarker => Construct(0xe8644);
            public static FormLink<IIdleMarkerGetter> SearchBodyMarker => Construct(0xefc65);
            public static FormLink<IIdleMarkerGetter> AstridIdleMarker => Construct(0xec25b);
            public static FormLink<IIdleMarkerGetter> WritingLedgerIdleMarker => Construct(0xeb5c5);
            public static FormLink<IIdleMarkerGetter> FalmerPatrolMarker => Construct(0xd6f07);
            public static FormLink<IIdleMarkerGetter> BigWoodPileIdleMarker => Construct(0xd2c2f);
            public static FormLink<IIdleMarkerGetter> GerdurTableIdleMarker => Construct(0xd2c2d);
            public static FormLink<IIdleMarkerGetter> E3demoBanditIdleMarker => Construct(0xcbfb9);
            public static FormLink<IIdleMarkerGetter> WipeBrowIdleMarker => Construct(0xb81fa);
            public static FormLink<IIdleMarkerGetter> MS14LaeletteAtGrave => Construct(0xad7b3);
            public static FormLink<IIdleMarkerGetter> BookReadingIdleMarker => Construct(0x7872b);
            public static FormLink<IIdleMarkerGetter> GetAttentionIdleMarker => Construct(0x6ff16);
            public static FormLink<IIdleMarkerGetter> SearchingChestIdleMarker => Construct(0x6feff);
            public static FormLink<IIdleMarkerGetter> SearchingTableIdleMarker => Construct(0x6fefe);
            public static FormLink<IIdleMarkerGetter> AlchemyLabIdleMarker => Construct(0x64af4);
            public static FormLink<IIdleMarkerGetter> DA13AfflictedPrayIdleMarker => Construct(0x64704);
            public static FormLink<IIdleMarkerGetter> PrayerIdleMarker => Construct(0x5ef7a);
            public static FormLink<IIdleMarkerGetter> LookFarOnceOnlyMarker => Construct(0x45d85);
            public static FormLink<IIdleMarkerGetter> DA08NelkirPatrolIdleMarker => Construct(0x23584);
            public static FormLink<IIdleMarkerGetter> Wounded03IdleMarker => Construct(0xe5955);
            public static FormLink<IIdleMarkerGetter> PointFar02Marker => Construct(0xe4871);
            public static FormLink<IIdleMarkerGetter> PointFarMarker => Construct(0xe4870);
            public static FormLink<IIdleMarkerGetter> dunCGHadvarCExploreIdle => Construct(0xdb90b);
            public static FormLink<IIdleMarkerGetter> dunCGHadvarCDoorIdle => Construct(0xdb90a);
            public static FormLink<IIdleMarkerGetter> LockPickIdleMarker => Construct(0xced9b);
            public static FormLink<IIdleMarkerGetter> SkeeverSniffMarker => Construct(0xc196c);
            public static FormLink<IIdleMarkerGetter> BrowseIdleMarker => Construct(0xa2bbf);
            public static FormLink<IIdleMarkerGetter> IdleFarmingMarker => Construct(0x8f17b);
            public static FormLink<IIdleMarkerGetter> PickaxeTableMarker => Construct(0x5e813);
            public static FormLink<IIdleMarkerGetter> LookFarMarker => Construct(0x16c95);
            public static FormLink<IIdleMarkerGetter> EmptyIdleMarker => Construct(0x99d1b);
            public static FormLink<IIdleMarkerGetter> CaptiveIdleMarker => Construct(0x8c1a5);
            public static FormLink<IIdleMarkerGetter> WoundedIdleMarker => Construct(0x72a86);
            public static FormLink<IIdleMarkerGetter> DB07ArnbjornInjuredMarker => Construct(0x6a3e0);
            public static FormLink<IIdleMarkerGetter> WarmHandsIdleMarker => Construct(0x4240b);
            public static FormLink<IIdleMarkerGetter> DBAventusAretinoRitualMarker => Construct(0x2e3fd);
            public static FormLink<IIdleMarkerGetter> DB02CaptiveIdleMarker => Construct(0x2e3f4);
            public static FormLink<IIdleMarkerGetter> animalLayingDownIdleMarker => Construct(0xb70f5);
            public static FormLink<IIdleMarkerGetter> LightSconceWithTorchIdleMarker => Construct(0xae314);
            public static FormLink<IIdleMarkerGetter> GiantRootingIdleMarker => Construct(0xa34ef);
            public static FormLink<IIdleMarkerGetter> TavernDrinkingMarker => Construct(0x97539);
            public static FormLink<IIdleMarkerGetter> PlayDrumMarker => Construct(0x97538);
            public static FormLink<IIdleMarkerGetter> PlayFluteMarker => Construct(0x97537);
            public static FormLink<IIdleMarkerGetter> PlayLuteMarker => Construct(0x97536);
            public static FormLink<IIdleMarkerGetter> ChoppingIdleMarker => Construct(0x8b832);
            public static FormLink<IIdleMarkerGetter> DrunkIdleMarker => Construct(0x8b82e);
            public static FormLink<IIdleMarkerGetter> FlowersIdleMarker => Construct(0x8b82c);
            public static FormLink<IIdleMarkerGetter> CowEatingIdleMarker => Construct(0x68451);
            public static FormLink<IIdleMarkerGetter> SweepIdleMarker => Construct(0x64106);
            public static FormLink<IIdleMarkerGetter> DraugrPatrolMarker => Construct(0x3bbe8);
            public static FormLink<IIdleMarkerGetter> sabreCatIdleMarker => Construct(0x263b2);
            public static FormLink<IIdleMarkerGetter> TestSandboxIdleMarker => Construct(0x1c28e);
            public static FormLink<IIdleMarkerGetter> PatrolIdleMarker => Construct(0x140bd);
        }
    }
}
