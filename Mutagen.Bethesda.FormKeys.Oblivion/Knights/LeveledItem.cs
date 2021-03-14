using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class LeveledItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            private static FormLink<ILeveledItemGetter> Construct(uint id) => new FormLink<ILeveledItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledItemGetter> NDLL0LootGems25 => Construct(0xfc2);
            public static FormLink<ILeveledItemGetter> NDUmarilSwordReward100 => Construct(0xfc3);
            public static FormLink<ILeveledItemGetter> NDLL0AuroranWeapon100 => Construct(0xfc4);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorLightCuirass => Construct(0xfc5);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorLightHelmet => Construct(0xfc6);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorLightGreaves => Construct(0xfc7);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorLightGauntlets => Construct(0xfc8);
            public static FormLink<ILeveledItemGetter> NDLL0WeaponMaceLvl100 => Construct(0xfc9);
            public static FormLink<ILeveledItemGetter> NDLL0WeaponSwordLvl100 => Construct(0xfca);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorHeavyShield => Construct(0xfcb);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorHeavyHelmet => Construct(0xfcc);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorHeavyGreaves => Construct(0xfcd);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorHeavyGauntlets => Construct(0xfce);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorHeavyCuirass => Construct(0xfcf);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorHeavyBoots => Construct(0xfd0);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorLightShield => Construct(0xfd1);
            public static FormLink<ILeveledItemGetter> NDLL0ArmorLightBoots => Construct(0xfd2);
        }
    }
}
