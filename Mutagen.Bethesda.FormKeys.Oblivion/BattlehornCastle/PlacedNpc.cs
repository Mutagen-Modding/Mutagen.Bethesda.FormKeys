namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey DLCBhornKnightRef => ModKey.MakeFormKey(0xca2c);
            public static FormKey DLCBattlehornKnight2REF => ModKey.MakeFormKey(0xca3f);
            public static FormKey NilphasOmellianRef => ModKey.MakeFormKey(0xb094);
            public static FormKey ShagrolgroUzugREF => ModKey.MakeFormKey(0xc008);
            public static FormKey TalanRef => ModKey.MakeFormKey(0xb0b0);
            public static FormKey NielsREF => ModKey.MakeFormKey(0xc517);
            public static FormKey MelisiDarenRef => ModKey.MakeFormKey(0xb0b3);
            public static FormKey DLCBattlehornLordKelvynREF => ModKey.MakeFormKey(0x1341b);
            public static FormKey DLCBattlehornMarauderMissileREF => ModKey.MakeFormKey(0x13425);
            public static FormKey DLCBattlehornMarauderMeleeREF => ModKey.MakeFormKey(0x13424);
            public static FormKey DLCBattlehornMarauderBossREF => ModKey.MakeFormKey(0x13423);
        }
    }
}
