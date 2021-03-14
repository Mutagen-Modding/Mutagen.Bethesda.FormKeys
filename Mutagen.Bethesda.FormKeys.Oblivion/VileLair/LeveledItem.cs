using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class LeveledItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<ILeveledItemGetter> Construct(uint id) => new FormLink<ILeveledItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledItemGetter> LairVileRaimentLvl100 => Construct(0xc35d);
            public static FormLink<ILeveledItemGetter> LairVileRewardsGoldLeveledList => Construct(0x7e63);
            public static FormLink<ILeveledItemGetter> LairVileModifiedLL2LootJewelryMagic100 => Construct(0x14ce3);
            public static FormLink<ILeveledItemGetter> LairVileEvisceratorLvl100 => Construct(0x60c2);
        }
    }
}
