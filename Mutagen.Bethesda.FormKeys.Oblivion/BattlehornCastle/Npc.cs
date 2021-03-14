using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Npc
        {
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> DLCBattlehornMaid => Construct(0xd441);
            public static FormLink<INpcGetter> DLCBattlehornCook => Construct(0xd44b);
            public static FormLink<INpcGetter> DLCBattlehornKnight4 => Construct(0xca44);
            public static FormLink<INpcGetter> DLCBattlehornBlacksmith => Construct(0xc516);
            public static FormLink<INpcGetter> DLCBattlehornTrainer => Construct(0xb09f);
            public static FormLink<INpcGetter> DLCBattlehornKnight1 => Construct(0xca2b);
            public static FormLink<INpcGetter> DLCBattlehornTaxidermist => Construct(0xb0a0);
            public static FormLink<INpcGetter> DLCBattlehornLordKelvyn => Construct(0x13417);
            public static FormLink<INpcGetter> DLCBattlehornKnightDead => Construct(0x1341d);
            public static FormLink<INpcGetter> DLCBattlehornMarauderBoss => Construct(0x13427);
            public static FormLink<INpcGetter> DLCBattlehornMarauderMelee => Construct(0x13428);
            public static FormLink<INpcGetter> DLCBattlehornMarauderMage => Construct(0x13429);
            public static FormLink<INpcGetter> DLCBattlehornMarauderMissile => Construct(0x1342a);
            public static FormLink<INpcGetter> DLCBattlehornCaptainReplacement => Construct(0xd42d);
            public static FormLink<INpcGetter> DLCBattlehornVintner => Construct(0xb09b);
            public static FormLink<INpcGetter> DLCBattlehornKnight2 => Construct(0xca3e);
            public static FormLink<INpcGetter> DLCBattlehornCaptain => Construct(0xca40);
            public static FormLink<INpcGetter> DLCBattlehornMerchant => Construct(0xb08e);
            public static FormLink<INpcGetter> DLCBattlehornKnight3 => Construct(0xca43);
        }
    }
}
