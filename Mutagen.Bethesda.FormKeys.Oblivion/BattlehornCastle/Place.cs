namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey BattlehornCastleTowerS => ModKey.MakeFormKey(0x12ec7);
            public static FormKey BattlehornCastleGreatHall => ModKey.MakeFormKey(0x1197);
            public static FormKey BattlehornCastleTowerN => ModKey.MakeFormKey(0x12e16);
            public static FormKey BattlehornCastleMasterBedroom => ModKey.MakeFormKey(0x4e10);
            public static FormKey BattlehornCastleGatehouse => ModKey.MakeFormKey(0x133ca);
            public static FormKey BattlehornCastleBasement => ModKey.MakeFormKey(0x131f);
            public static FormKey BattlehornCastleBlacksmithHouse => ModKey.MakeFormKey(0x868e);
            public static FormKey BattlehornCastleForgottenPassage => ModKey.MakeFormKey(0x605c);
            public static FormKey BattlehornCastle => ModKey.MakeFormKey(0xb0ad);
            public static FormKey BattlehornCastleEastWing => ModKey.MakeFormKey(0x125b);
        }
    }
}
