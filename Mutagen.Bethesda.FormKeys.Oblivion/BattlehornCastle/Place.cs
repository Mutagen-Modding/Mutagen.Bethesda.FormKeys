using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IPlaceGetter> Construct(uint id) => new FormLink<IPlaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlaceGetter> BattlehornCastleTowerS => Construct(0x12ec7);
            public static FormLink<IPlaceGetter> BattlehornCastleGreatHall => Construct(0x1197);
            public static FormLink<IPlaceGetter> BattlehornCastleTowerN => Construct(0x12e16);
            public static FormLink<IPlaceGetter> BattlehornCastleMasterBedroom => Construct(0x4e10);
            public static FormLink<IPlaceGetter> BattlehornCastleGatehouse => Construct(0x133ca);
            public static FormLink<IPlaceGetter> BattlehornCastleBasement => Construct(0x131f);
            public static FormLink<IPlaceGetter> BattlehornCastleBlacksmithHouse => Construct(0x868e);
            public static FormLink<IPlaceGetter> BattlehornCastleForgottenPassage => Construct(0x605c);
            public static FormLink<IPlaceGetter> BattlehornCastle => Construct(0xb0ad);
            public static FormLink<IPlaceGetter> BattlehornCastleEastWing => Construct(0x125b);
        }
    }
}
