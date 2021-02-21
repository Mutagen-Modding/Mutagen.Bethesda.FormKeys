using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IANpcSpawnGetter> Construct(uint id) => new FormLink<IANpcSpawnGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IANpcSpawnGetter> DLCBattlehornMaid => Construct(0xd441);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornCook => Construct(0xd44b);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornKnight4 => Construct(0xca44);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornBlacksmith => Construct(0xc516);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornTrainer => Construct(0xb09f);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornKnight1 => Construct(0xca2b);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornTaxidermist => Construct(0xb0a0);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornLordKelvyn => Construct(0x13417);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornKnightDead => Construct(0x1341d);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornMarauderBoss => Construct(0x13427);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornMarauderMelee => Construct(0x13428);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornMarauderMage => Construct(0x13429);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornMarauderMissile => Construct(0x1342a);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornCaptainReplacement => Construct(0xd42d);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornVintner => Construct(0xb09b);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornKnight2 => Construct(0xca3e);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornCaptain => Construct(0xca40);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornMerchant => Construct(0xb08e);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornKnight3 => Construct(0xca43);
            public static FormLink<IANpcSpawnGetter> DogBattlehorn => Construct(0xc513);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornSkeleton => Construct(0xe824);
            public static FormLink<IANpcSpawnGetter> DLCBattlehornLich => Construct(0xe337);
        }
    }
}
