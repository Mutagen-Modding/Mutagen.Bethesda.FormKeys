using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Book
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> BYOHHouseBanditAttack2Note => Construct(0x8ae);
            public static FormLink<IBookGetter> BYOHHouseJarlIntroLetter => Construct(0x16130);
            public static FormLink<IBookGetter> BYOHHouseGuide => Construct(0x15d59);
            public static FormLink<IBookGetter> BYOHHouse3Deed => Construct(0x157a1);
            public static FormLink<IBookGetter> BYOHHouse2Deed => Construct(0x157a0);
            public static FormLink<IBookGetter> BYOHHouse1Deed => Construct(0x1579f);
            public static FormLink<IBookGetter> BYOHHouseJarlFriendLetter2 => Construct(0x10bef);
            public static FormLink<IBookGetter> BYOHAdoptionConstanceLetter => Construct(0x3f7c);
            public static FormLink<IBookGetter> BYOHAdoptionStewardCourierNote => Construct(0x3f78);
            public static FormLink<IBookGetter> BYOHHouseJarlFriendLetter => Construct(0x30a1);
        }
    }
}
