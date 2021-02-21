using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IAItemGetter> Construct(uint id) => new FormLink<IAItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAItemGetter> DLCBattlehornShieldOfTrueHorn => Construct(0x97d3);
            public static FormLink<IAItemGetter> DLCBattlehornShieldReward01 => Construct(0x11f17);
            public static FormLink<IAItemGetter> DLCBattlehornShieldReward05 => Construct(0x11f19);
            public static FormLink<IAItemGetter> DLCBattlehornShieldReward10 => Construct(0x11f1a);
            public static FormLink<IAItemGetter> DLCBattlehornShieldReward15 => Construct(0x11f1b);
            public static FormLink<IAItemGetter> DLCBattlehornShieldReward20 => Construct(0x11f1c);
            public static FormLink<IAItemGetter> DLCBattlehornShieldofLight => Construct(0x156c9);
            public static FormLink<IAItemGetter> DLCBattlehornShieldReward25 => Construct(0x11f1d);
            public static FormLink<IAItemGetter> DLCBattlehornShieldReward30 => Construct(0x11f1e);
            public static FormLink<IAItemGetter> DLCBattlehornJournal => Construct(0x142ef);
            public static FormLink<IAItemGetter> DLCBattlehornMerchantList => Construct(0x147d7);
            public static FormLink<IAItemGetter> DLCBattlehornLibraryReceipt => Construct(0xb098);
            public static FormLink<IAItemGetter> DLCBattlehornForgeReceipt => Construct(0xb0ac);
            public static FormLink<IAItemGetter> DLCBattlehornMenAtArmsReceipt => Construct(0xd42b);
            public static FormLink<IAItemGetter> DLCBattlehornBookWineRecipes => Construct(0xbb0d);
            public static FormLink<IAItemGetter> DLCBattlehornCaptainReceipt => Construct(0xd42e);
            public static FormLink<IAItemGetter> DLCBattlehornDiningReceipt => Construct(0xb099);
            public static FormLink<IAItemGetter> DLCBattlehornForgeMessage => Construct(0xd433);
            public static FormLink<IAItemGetter> DLCBattlehornKitchenReceipt => Construct(0xb09a);
            public static FormLink<IAItemGetter> DLCBattlehornWineCellarReceipt => Construct(0xb09c);
            public static FormLink<IAItemGetter> DLCBattlehornTrainingRoomReceipt => Construct(0xb09d);
            public static FormLink<IAItemGetter> DLCBattlehornChronicle => Construct(0xb08c);
            public static FormLink<IAItemGetter> DLCBattlehornBookTaxIngreds => Construct(0x11f12);
            public static FormLink<IAItemGetter> DLCBattlehornLichNote => Construct(0x11f42);
            public static FormLink<IAItemGetter> DLCBattlehornTrophyHallReceipt => Construct(0xb0a1);
            public static FormLink<IAItemGetter> DLCBattlehornBedroomAreaReceipt => Construct(0xb097);
            public static FormLink<IAItemGetter> DLCBattlehornDragonsword04 => Construct(0x147ef);
            public static FormLink<IAItemGetter> DLCBattlehornDragonsword05 => Construct(0x147f0);
            public static FormLink<IAItemGetter> DLCBattlehornDragonsword06 => Construct(0x147f1);
            public static FormLink<IAItemGetter> BattlehornSparringDagger => Construct(0xbb20);
            public static FormLink<IAItemGetter> DLCBattlehornDragonsword01 => Construct(0x12e13);
            public static FormLink<IAItemGetter> BattlehornSparringWarhammer => Construct(0xbb1e);
            public static FormLink<IAItemGetter> BattlehornSparringWarAxe => Construct(0xbb1f);
            public static FormLink<IAItemGetter> DLCBattlehornDragonsword02 => Construct(0x147ec);
            public static FormLink<IAItemGetter> DLCBattlehornDragonsword03 => Construct(0x147ee);
            public static FormLink<IAItemGetter> DLCBattlehornLichKey => Construct(0xe339);
            public static FormLink<IAItemGetter> DrinkArgonianBloodwine => Construct(0xa6a8);
            public static FormLink<IAItemGetter> DrinkNumbskinMead => Construct(0xa6a9);
            public static FormLink<IAItemGetter> DrinkJulianosFirebelly => Construct(0xa6ab);
            public static FormLink<IAItemGetter> DrinkSparklingHoneydew => Construct(0xa6ad);
            public static FormLink<IAItemGetter> DrinkStumblefootsReserve => Construct(0xa6af);
            public static FormLink<IAItemGetter> DrinkFrostdewBlanc => Construct(0xa6a2);
            public static FormLink<IAItemGetter> DrinkColovianBattleCry => Construct(0xa6a5);
            public static FormLink<IAItemGetter> DLCBattlehornDragonswordLL => Construct(0x12e14);
            public static FormLink<IAItemGetter> DLCBattlehornShieldRewardLeveled => Construct(0x11f2d);
        }
    }
}
