using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IContainerGetter> BattlehornCrateClutterMiddle01 => Construct(0x7771);
            public static FormLink<IContainerGetter> BattlehornChestClutterMiddle01 => Construct(0x7772);
            public static FormLink<IContainerGetter> BattlehornChestJewelryMiddle01 => Construct(0x7773);
            public static FormLink<IContainerGetter> BattlehornCrateClutterMiddle03 => Construct(0x7774);
            public static FormLink<IContainerGetter> BattlehornChestHouseArmoryLower01 => Construct(0x7775);
            public static FormLink<IContainerGetter> BattlehornChestSpecial01 => Construct(0x11f2e);
            public static FormLink<IContainerGetter> BattlehornDrawerClutterUpperClothing02 => Construct(0x776a);
            public static FormLink<IContainerGetter> BattlehornCupboardClothingUpper => Construct(0x776b);
            public static FormLink<IContainerGetter> BattlehornDrawerClutterUpper03 => Construct(0x776c);
            public static FormLink<IContainerGetter> BattlehornCupboardFoodUpper => Construct(0x776d);
            public static FormLink<IContainerGetter> BattlehornAddons => Construct(0xb096);
            public static FormLink<IContainerGetter> BattlehornChestHouseHealingUpper01 => Construct(0x776e);
            public static FormLink<IContainerGetter> BattlehornCrateClutterMiddle02 => Construct(0x776f);
            public static FormLink<IContainerGetter> BattlehornBarrelClutterMiddle01 => Construct(0x7770);
            public static FormLink<IContainerGetter> DLCBattlehornLichChest => Construct(0xe33c);
        }
    }
}
