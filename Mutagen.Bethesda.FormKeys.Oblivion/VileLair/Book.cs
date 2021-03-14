using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Book
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> DeepscornCellReceipt => Construct(0x46b3);
            public static FormLink<IBookGetter> DeepscornVenomgrowthReceipt => Construct(0x4b9c);
            public static FormLink<IBookGetter> LairVileVampireManifesto => Construct(0x5093);
            public static FormLink<IBookGetter> LairVileOpusculusLamae => Construct(0x5095);
            public static FormLink<IBookGetter> DeepscornHollowJournal => Construct(0x46ac);
            public static FormLink<IBookGetter> DeepscornBedroomReceipt => Construct(0x46ae);
            public static FormLink<IBookGetter> DeepscornDiningReceipt => Construct(0x46af);
            public static FormLink<IBookGetter> DeepscornStudyReceipt => Construct(0x46b0);
            public static FormLink<IBookGetter> DeepscornStorageReceipt => Construct(0x46b1);
            public static FormLink<IBookGetter> DeepscornHollowNote => Construct(0xdc0a);
            public static FormLink<IBookGetter> DeepscornMinionReceipt => Construct(0x46b2);
        }
    }
}
