using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Book
        {
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> FrostcragLibraryAreaReceipt => Construct(0xd5e);
            public static FormLink<IBookGetter> FrostcragApparatusReceipt => Construct(0xd5f);
            public static FormLink<IBookGetter> FrostcragSpireMemoirs => Construct(0xd56);
            public static FormLink<IBookGetter> FrostcragSpireDeed => Construct(0xd52);
            public static FormLink<IBookGetter> FrostcragBedroomAreaReceipt => Construct(0xd5a);
            public static FormLink<IBookGetter> FrostcragVaultAreaReceipt => Construct(0xd5d);
        }
    }
}
