using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class LeveledItem
        {
            private static FormLink<ILeveledItemGetter> Construct(uint id) => new FormLink<ILeveledItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledItemGetter> DLC06VendorStealthGauntlets => Construct(0xbf66);
            public static FormLink<ILeveledItemGetter> DLC06VendorSupplierPotions3 => Construct(0x83b7);
            public static FormLink<ILeveledItemGetter> DLC06VendorSecurityPotions3 => Construct(0x7eb8);
            public static FormLink<ILeveledItemGetter> DLC06VendorStealthBoots => Construct(0x7eb9);
            public static FormLink<ILeveledItemGetter> DLC06VendorFletcherMagicArrows => Construct(0x7eba);
            public static FormLink<ILeveledItemGetter> DLC06SkeletonWeapons => Construct(0x13dc2);
            public static FormLink<ILeveledItemGetter> DLC06VendorSecurityScrolls1 => Construct(0x7ebb);
            public static FormLink<ILeveledItemGetter> DLC06VendorSecurityScrolls5 => Construct(0x7ebc);
            public static FormLink<ILeveledItemGetter> DLC06VendorSecurityScrolls2 => Construct(0x79c8);
            public static FormLink<ILeveledItemGetter> DLC06VendorFletcher => Construct(0x79c2);
            public static FormLink<ILeveledItemGetter> DLC06VendorSecurityScrolls3 => Construct(0x7eb6);
            public static FormLink<ILeveledItemGetter> DLC06VendorSecurityScrolls4 => Construct(0x7eb7);
            public static FormLink<ILeveledItemGetter> DLC06VendorSupplierPotions1 => Construct(0x83b5);
            public static FormLink<ILeveledItemGetter> DLC06VendorSupplierPotions2 => Construct(0x83b6);
        }
    }
}
