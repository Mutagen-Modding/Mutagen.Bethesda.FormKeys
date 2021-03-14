using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Enchantment
        {
            private static FormLink<IEnchantmentGetter> Construct(uint id) => new FormLink<IEnchantmentGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEnchantmentGetter> DLCBattlehornShieldRewardEnch25 => Construct(0x11f29);
            public static FormLink<IEnchantmentGetter> DLCBattlehornShieldRewardEnch30 => Construct(0x11f2b);
            public static FormLink<IEnchantmentGetter> DLCBattlehornShieldRewardEnch01 => Construct(0x11f1f);
            public static FormLink<IEnchantmentGetter> DLCBattlehornShieldRewardEnch05 => Construct(0x11f20);
            public static FormLink<IEnchantmentGetter> DLCBattlehornDragonswordEnch1 => Construct(0x147db);
            public static FormLink<IEnchantmentGetter> DLCBattlehornDragonswordEnch2 => Construct(0x147e3);
            public static FormLink<IEnchantmentGetter> DLCBattlehornDragonswordEnch3 => Construct(0x147e5);
            public static FormLink<IEnchantmentGetter> DLCBattlehornDragonswordEnch4 => Construct(0x147e6);
            public static FormLink<IEnchantmentGetter> DLCBattlehornDragonswordEnch5 => Construct(0x147e7);
            public static FormLink<IEnchantmentGetter> DLCBattlehornShieldRewardEnch10 => Construct(0x11f23);
            public static FormLink<IEnchantmentGetter> DLCBattlehornDragonswordEnch6 => Construct(0x147f2);
            public static FormLink<IEnchantmentGetter> DLCBattlehornShieldRewardEnch15 => Construct(0x11f25);
            public static FormLink<IEnchantmentGetter> DLCBattlehornShieldRewardEnch20 => Construct(0x11f27);
        }
    }
}
