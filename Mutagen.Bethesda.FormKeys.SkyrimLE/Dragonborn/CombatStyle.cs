using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class CombatStyle
        {
            private static FormLink<ICombatStyleGetter> Construct(uint id) => new FormLink<ICombatStyleGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICombatStyleGetter> DLC2TameDragonCSPlayerRiding => Construct(0x3cd43);
            public static FormLink<ICombatStyleGetter> DLC2csSeeker => Construct(0x3c6a5);
            public static FormLink<ICombatStyleGetter> DLC2csMiraakStaff => Construct(0x39a7e);
            public static FormLink<ICombatStyleGetter> DLC2csMiraakAntiAir => Construct(0x39a7d);
            public static FormLink<ICombatStyleGetter> DLC2MerilarRendasCS => Construct(0x395cb);
            public static FormLink<ICombatStyleGetter> DLC2dunHaknirCS => Construct(0x37fec);
            public static FormLink<ICombatStyleGetter> DLC2csNetch => Construct(0x34c03);
            public static FormLink<ICombatStyleGetter> DLC2dunKolbjorn_csDraugrMissile => Construct(0x338e2);
            public static FormLink<ICombatStyleGetter> DLC2csDwarvenBallista => Construct(0x33257);
            public static FormLink<ICombatStyleGetter> DLC2csAshSpawnMelee03 => Construct(0x322ba);
            public static FormLink<ICombatStyleGetter> DLC2csAshSpawnMelee02 => Construct(0x322b9);
            public static FormLink<ICombatStyleGetter> DLC2csAshSpawnMelee01 => Construct(0x322b8);
            public static FormLink<ICombatStyleGetter> DLC2FreaCombatStyle => Construct(0x2bf15);
            public static FormLink<ICombatStyleGetter> DLC2csSprigganBurnt => Construct(0x2a6d4);
            public static FormLink<ICombatStyleGetter> DLC2csInstruments => Construct(0x29f03);
            public static FormLink<ICombatStyleGetter> DLC2csVendilSeverin => Construct(0x292aa);
            public static FormLink<ICombatStyleGetter> DLC2csKarstaag => Construct(0x28248);
            public static FormLink<ICombatStyleGetter> dlc2DBAncientDragonbornCS => Construct(0x265b0);
            public static FormLink<ICombatStyleGetter> DLC2KagrumezcsDwarvenSphere => Construct(0x260a4);
            public static FormLink<ICombatStyleGetter> DLC2TameDragonCSExtraLanding => Construct(0x24ca9);
            public static FormLink<ICombatStyleGetter> DLC2csMiraakMelee => Construct(0x23f65);
            public static FormLink<ICombatStyleGetter> DLC2csMiraakMagic => Construct(0x23f64);
            public static FormLink<ICombatStyleGetter> DLC2csAshHopper => Construct(0x202c8);
            public static FormLink<ICombatStyleGetter> DLC2MQ06DragonCSNoLanding => Construct(0x1fe84);
            public static FormLink<ICombatStyleGetter> dlc2SpectralDragonCS => Construct(0x1f996);
            public static FormLink<ICombatStyleGetter> DLC2csBenthicLurker => Construct(0x1e113);
            public static FormLink<ICombatStyleGetter> DLC2csRieklingMissile01 => Construct(0x1d9c8);
            public static FormLink<ICombatStyleGetter> DLC2csRieklingMelee01 => Construct(0x1d9c7);
            public static FormLink<ICombatStyleGetter> DLC2csTestMelMis => Construct(0x1839e);
            public static FormLink<ICombatStyleGetter> DLC2dunKolbjornRalisCS => Construct(0x179c8);
            public static FormLink<ICombatStyleGetter> DLC2ExpSpiderMeleeCS => Construct(0x14488);
            public static FormLink<ICombatStyleGetter> DLC2ExpSpiderRangedCS => Construct(0x14448);
        }
    }
}
