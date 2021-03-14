using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Flora
        {
            private static FormLink<IFloraGetter> Construct(uint id) => new FormLink<IFloraGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFloraGetter> DeadFXSalmon02 => Construct(0x10c3b5);
            public static FormLink<IFloraGetter> DeadFXSalmon01 => Construct(0x10c3b4);
            public static FormLink<IFloraGetter> TreeReachTreeStump01MoraTapinella => Construct(0x108ee2);
            public static FormLink<IFloraGetter> FXAmbWaterSalmon01A => Construct(0x108e38);
            public static FormLink<IFloraGetter> FXAmbWaterSalmon01B => Construct(0x108e37);
            public static FormLink<IFloraGetter> FXAmbWaterSalmon02A => Construct(0x108e36);
            public static FormLink<IFloraGetter> FXAmbWaterSalmon02B => Construct(0x108e35);
            public static FormLink<IFloraGetter> ChickenNest => Construct(0x1062d1);
            public static FormLink<IFloraGetter> ChaurusEggSac03 => Construct(0x1016a3);
            public static FormLink<IFloraGetter> ChaurusEggSac02 => Construct(0x1016a2);
            public static FormLink<IFloraGetter> ChaurusEggSac01 => Construct(0x1016a1);
            public static FormLink<IFloraGetter> FloraMushroom06SmallDirt01 => Construct(0xf675f);
            public static FormLink<IFloraGetter> DeadSalmon02NoNail => Construct(0xf5ecb);
            public static FormLink<IFloraGetter> DeadSalmon01NoNail => Construct(0xf5eca);
            public static FormLink<IFloraGetter> FloraMushroom02SmallDirt01 => Construct(0xf3e57);
            public static FormLink<IFloraGetter> TreePineForestHollow01BMoraTapinella => Construct(0xece9a);
            public static FormLink<IFloraGetter> TreePineForestLog01MoraTapinella => Construct(0xece21);
            public static FormLink<IFloraGetter> FloraMushroom06SmallReachDirt01 => Construct(0xeca60);
            public static FormLink<IFloraGetter> FloraMushroom06ReachDirt01 => Construct(0xeca5f);
            public static FormLink<IFloraGetter> FloraMushroom05SmallReachDirt01 => Construct(0xeca5e);
            public static FormLink<IFloraGetter> FloraMushroom05ReachDirt01 => Construct(0xeca5d);
            public static FormLink<IFloraGetter> FloraMushroom04SmallReachDirt01 => Construct(0xeca5c);
            public static FormLink<IFloraGetter> FloraMushroom04ReachDirt01 => Construct(0xeca5b);
            public static FormLink<IFloraGetter> FloraMushroom03SmallReachDirt01 => Construct(0xeca5a);
            public static FormLink<IFloraGetter> FloraMushroom03ReachDirt01 => Construct(0xeca59);
            public static FormLink<IFloraGetter> FloraMushroom02SmallReachDirt01 => Construct(0xeca58);
            public static FormLink<IFloraGetter> FloraMushroom02ReachDirt01 => Construct(0xeca57);
            public static FormLink<IFloraGetter> FloraMushroom01SmallReachDirt01 => Construct(0xeca56);
            public static FormLink<IFloraGetter> FloraMushroom01ReachDirt01 => Construct(0xeca55);
            public static FormLink<IFloraGetter> TreePineForestStump02BMoraTapinella => Construct(0xec876);
            public static FormLink<IFloraGetter> TreePineForestStump02AMoraTapinella => Construct(0xec875);
            public static FormLink<IFloraGetter> TreePineForestStump01MoraTapinella => Construct(0xec7e7);
            public static FormLink<IFloraGetter> FloraMushroom01FallForestDirt01 => Construct(0xe644b);
            public static FormLink<IFloraGetter> FloraMushroom03SmallFallForestGrass => Construct(0xdd683);
            public static FormLink<IFloraGetter> FloraMushroom02SmallFallForestDirt => Construct(0xdd679);
            public static FormLink<IFloraGetter> FloraMushroom02FallForestDirt => Construct(0xdd676);
            public static FormLink<IFloraGetter> TGCoinPurseSmallNEW => Construct(0xd8e8c);
            public static FormLink<IFloraGetter> TGCoinPurseMediumNEW => Construct(0xd8e8b);
            public static FormLink<IFloraGetter> TGCoinPurseLargeNEW => Construct(0xd8e8a);
            public static FormLink<IFloraGetter> CoinPurseLarge => Construct(0xd8e80);
            public static FormLink<IFloraGetter> CoinPurseMedium => Construct(0xd8e7f);
            public static FormLink<IFloraGetter> CoinPurseSmall => Construct(0xd790c);
            public static FormLink<IFloraGetter> ClamLarge01 => Construct(0x85f83);
            public static FormLink<IFloraGetter> ClamThin01 => Construct(0x85f82);
            public static FormLink<IFloraGetter> Clam01 => Construct(0x85f80);
            public static FormLink<IFloraGetter> BirdsNest02 => Construct(0x23cff);
            public static FormLink<IFloraGetter> FloraMushroom02Dirt01 => Construct(0xdb6bc);
            public static FormLink<IFloraGetter> FloraMushroom03Dirt01 => Construct(0xdb68b);
            public static FormLink<IFloraGetter> FloraMushroom05Dirt01 => Construct(0xce84c);
            public static FormLink<IFloraGetter> FloraMushroom06Small => Construct(0x4da1f);
            public static FormLink<IFloraGetter> FloraMushroom06 => Construct(0x4da0c);
            public static FormLink<IFloraGetter> FloraMushroom05Small => Construct(0x4da0b);
            public static FormLink<IFloraGetter> FloraMushroom05 => Construct(0x4da0a);
            public static FormLink<IFloraGetter> FloraMushroom04Small => Construct(0x4da09);
            public static FormLink<IFloraGetter> FloraMushroom04 => Construct(0x4da08);
            public static FormLink<IFloraGetter> FloraMushroom03Small => Construct(0x4da07);
            public static FormLink<IFloraGetter> FloraMushroom03 => Construct(0x4da06);
            public static FormLink<IFloraGetter> FloraMushroom02Small => Construct(0x4da05);
            public static FormLink<IFloraGetter> FloraMushroom02 => Construct(0x4da04);
            public static FormLink<IFloraGetter> FloraMushroom01Small => Construct(0x4da03);
            public static FormLink<IFloraGetter> FloraMushroom01 => Construct(0x4d9ff);
            public static FormLink<IFloraGetter> FloraCreepClusterRock => Construct(0xb202c);
            public static FormLink<IFloraGetter> FloraCreepCluster => Construct(0xb03af);
            public static FormLink<IFloraGetter> dunSleepingTreeCampSpigot => Construct(0xaed89);
            public static FormLink<IFloraGetter> GlowingMushroomSingle => Construct(0x9748b);
            public static FormLink<IFloraGetter> GlowingMushroomCluster => Construct(0x7ee00);
            public static FormLink<IFloraGetter> NordicBarnacleCluster01 => Construct(0x7edf6);
            public static FormLink<IFloraGetter> MammothCheese01 => Construct(0x7edf0);
            public static FormLink<IFloraGetter> BirdsNest => Construct(0x7e8c9);
            public static FormLink<IFloraGetter> SlaughterfishEggNest01 => Construct(0x7e8c6);
            public static FormLink<IFloraGetter> FloraGiantLichen => Construct(0x7e8c2);
            public static FormLink<IFloraGetter> FloraSwampFungalPod01 => Construct(0x7e8b8);
            public static FormLink<IFloraGetter> CharredSkeever03 => Construct(0x775fe);
            public static FormLink<IFloraGetter> TreeAspenLog01ScalyPholiota => Construct(0x70e42);
            public static FormLink<IFloraGetter> TreeAspenStump01ScalyPholiota => Construct(0x6f94d);
            public static FormLink<IFloraGetter> GiantSkewer01CharredSkeever02 => Construct(0x52189);
            public static FormLink<IFloraGetter> GiantSkewer01CharredSkeever01 => Construct(0x52185);
            public static FormLink<IFloraGetter> DeadSalmon01 => Construct(0x176cd);
            public static FormLink<IFloraGetter> DeadSalmon02 => Construct(0x176b2);
            public static FormLink<IFloraGetter> HangingRabbit01 => Construct(0x38b0f);
            public static FormLink<IFloraGetter> HangingRabbit02 => Construct(0x38b0e);
            public static FormLink<IFloraGetter> HangingPheasant01 => Construct(0x38b0d);
            public static FormLink<IFloraGetter> HangingPheasant02 => Construct(0x38b0c);
            public static FormLink<IFloraGetter> HangingGarlicBraid => Construct(0x34d30);
            public static FormLink<IFloraGetter> HangingElvesEar01 => Construct(0x34d2d);
            public static FormLink<IFloraGetter> HangingFrostMirriam => Construct(0x34d2c);
        }
    }
}
