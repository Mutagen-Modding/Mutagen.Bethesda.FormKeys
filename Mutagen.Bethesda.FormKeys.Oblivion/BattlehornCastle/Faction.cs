namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Faction
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey DLCBattlehornCastleFaction => ModKey.MakeFormKey(0xb09e);
            public static FormKey DLCBattlehornSparringFaction => ModKey.MakeFormKey(0xbb21);
            public static FormKey DLCBattlehornCastleKnightFaction => ModKey.MakeFormKey(0xcf3c);
            public static FormKey DLCBattlehornCaptainFaction => ModKey.MakeFormKey(0xd43f);
        }
    }
}
