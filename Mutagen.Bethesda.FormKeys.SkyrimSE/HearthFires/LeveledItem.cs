using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class LeveledItem
        {
            private static FormLink<ILeveledItemGetter> Construct(uint id) => new FormLink<ILeveledItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledItemGetter> BYOHLItemInnRuralDrinkNewWines => Construct(0xbbf);
            public static FormLink<ILeveledItemGetter> BYOHLItemFoodFlourSmall => Construct(0xbb3);
            public static FormLink<ILeveledItemGetter> BYOHLItemFoodFlour75 => Construct(0xbb2);
            public static FormLink<ILeveledItemGetter> BYOHLItemFoodFlour => Construct(0xbb1);
            public static FormLink<ILeveledItemGetter> BYOHRelationshipAdoptionLItemChildrensClothesAny75 => Construct(0x916);
            public static FormLink<ILeveledItemGetter> BYOHLItemKhajiitCaravans => Construct(0x915);
            public static FormLink<ILeveledItemGetter> BYOHLItemStraw75 => Construct(0x80d);
            public static FormLink<ILeveledItemGetter> BYOHLItemGlass75 => Construct(0x80c);
            public static FormLink<ILeveledItemGetter> BYOHRelationshipAdoptionLItemChildrensClothesAny100 => Construct(0xd82a);
            public static FormLink<ILeveledItemGetter> BYOHRelationshipAdoptionLItemChildrensClothes05 => Construct(0xd829);
            public static FormLink<ILeveledItemGetter> BYOHRelationshipAdoptionLItemChildrensClothes04 => Construct(0xd828);
            public static FormLink<ILeveledItemGetter> BYOHRelationshipAdoptionLItemChildrensClothes03 => Construct(0xd827);
            public static FormLink<ILeveledItemGetter> BYOHRelationshipAdoptionLItemChildrensClothes02 => Construct(0xd826);
            public static FormLink<ILeveledItemGetter> BYOHRelationshipAdoptionLItemChildrensClothes01 => Construct(0xd825);
            public static FormLink<ILeveledItemGetter> BYOHHouseTestItems => Construct(0xd17e);
            public static FormLink<ILeveledItemGetter> BYOHLItemHornGoat50 => Construct(0x9567);
            public static FormLink<ILeveledItemGetter> BYOHAdoptionUrchinsSofieFlowersCommon => Construct(0x4036);
            public static FormLink<ILeveledItemGetter> BYOHAdoptionUrchinsSofieFlowersRare => Construct(0x4035);
        }
    }
}
