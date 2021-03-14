using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Book
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> DLCBattlehornJournal => Construct(0x142ef);
            public static FormLink<IBookGetter> DLCBattlehornMerchantList => Construct(0x147d7);
            public static FormLink<IBookGetter> DLCBattlehornLibraryReceipt => Construct(0xb098);
            public static FormLink<IBookGetter> DLCBattlehornForgeReceipt => Construct(0xb0ac);
            public static FormLink<IBookGetter> DLCBattlehornMenAtArmsReceipt => Construct(0xd42b);
            public static FormLink<IBookGetter> DLCBattlehornBookWineRecipes => Construct(0xbb0d);
            public static FormLink<IBookGetter> DLCBattlehornCaptainReceipt => Construct(0xd42e);
            public static FormLink<IBookGetter> DLCBattlehornDiningReceipt => Construct(0xb099);
            public static FormLink<IBookGetter> DLCBattlehornForgeMessage => Construct(0xd433);
            public static FormLink<IBookGetter> DLCBattlehornKitchenReceipt => Construct(0xb09a);
            public static FormLink<IBookGetter> DLCBattlehornWineCellarReceipt => Construct(0xb09c);
            public static FormLink<IBookGetter> DLCBattlehornTrainingRoomReceipt => Construct(0xb09d);
            public static FormLink<IBookGetter> DLCBattlehornChronicle => Construct(0xb08c);
            public static FormLink<IBookGetter> DLCBattlehornBookTaxIngreds => Construct(0x11f12);
            public static FormLink<IBookGetter> DLCBattlehornLichNote => Construct(0x11f42);
            public static FormLink<IBookGetter> DLCBattlehornTrophyHallReceipt => Construct(0xb0a1);
            public static FormLink<IBookGetter> DLCBattlehornBedroomAreaReceipt => Construct(0xb097);
        }
    }
}
