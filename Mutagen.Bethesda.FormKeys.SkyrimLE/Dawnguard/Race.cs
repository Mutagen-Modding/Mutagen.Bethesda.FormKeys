using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Race
        {
            private static FormLink<IRaceGetter> Construct(uint id) => new FormLink<IRaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRaceGetter> DLC1HuskyBareCompanionRace => Construct(0x122b7);
            public static FormLink<IRaceGetter> DLC1GargoyleVariantBossRace => Construct(0x10d00);
            public static FormLink<IRaceGetter> DLC1NordRace => Construct(0xe88a);
            public static FormLink<IRaceGetter> DLC1DeathHoundCompanionRace => Construct(0x3d02);
            public static FormLink<IRaceGetter> DLC1HuskyArmoredCompanionRace => Construct(0x3d01);
            public static FormLink<IRaceGetter> DLC1SoulCairnSoulWispRace => Construct(0x2ae0);
            public static FormLink<IRaceGetter> FalmerFrozenVampRace => Construct(0x1aacc);
            public static FormLink<IRaceGetter> DLC1BlackSkeletonRace => Construct(0x19fd3);
            public static FormLink<IRaceGetter> DLC1GargoyleVariantGreenRace => Construct(0x19d86);
            public static FormLink<IRaceGetter> DLC1HuskyBareRace => Construct(0x18b36);
            public static FormLink<IRaceGetter> DLC1HuskyArmoredRace => Construct(0x18b33);
            public static FormLink<IRaceGetter> DLC1LD_ForgemasterRace => Construct(0x15c34);
            public static FormLink<IRaceGetter> DLC1_BF_ChaurusRace => Construct(0x15136);
            public static FormLink<IRaceGetter> SprigganEarthMotherRace => Construct(0x13b77);
            public static FormLink<IRaceGetter> DLC1TrollRaceArmored => Construct(0x117f5);
            public static FormLink<IRaceGetter> DLC1TrollFrostRaceArmored => Construct(0x117f4);
            public static FormLink<IRaceGetter> DLC1UndeadDragonRace => Construct(0x117de);
            public static FormLink<IRaceGetter> DLC1SabreCatGlowRace => Construct(0xd0b6);
            public static FormLink<IRaceGetter> DLC1DeerGlowRace => Construct(0xd0b2);
            public static FormLink<IRaceGetter> DLC1DeathHoundRace => Construct(0xc5f0);
            public static FormLink<IRaceGetter> DLC01SoulCairnBonemanRace => Construct(0xa94b);
            public static FormLink<IRaceGetter> DLC1GargoyleRace => Construct(0xa2c6);
            public static FormLink<IRaceGetter> DLC1SoulCairnSkeletonArmorRace => Construct(0x894d);
            public static FormLink<IRaceGetter> DLC1SoulCairnKeeperRace => Construct(0x7af3);
            public static FormLink<IRaceGetter> DLC1SoulCairnSkeletonNecroRace => Construct(0x6afa);
            public static FormLink<IRaceGetter> DLC1ChaurusHunterRace => Construct(0x51fb);
            public static FormLink<IRaceGetter> TestRace => Construct(0x4d31);
            public static FormLink<IRaceGetter> testDraugrRace => Construct(0x483b);
            public static FormLink<IRaceGetter> SnowElfRace => Construct(0x377d);
            public static FormLink<IRaceGetter> DLC1VampireBeastRace => Construct(0x283a);
            public static FormLink<IRaceGetter> SkeletonArmorRace => Construct(0x23e2);
        }
    }
}
