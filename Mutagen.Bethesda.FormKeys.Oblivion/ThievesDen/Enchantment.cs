using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Enchantment
        {
            private static FormLink<IEnchantmentGetter> Construct(uint id) => new FormLink<IEnchantmentGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorSilenced5 => Construct(0xbf53);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorSilenced6 => Construct(0xbf55);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorSilenced10 => Construct(0xbf57);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorBullseye2 => Construct(0xbf67);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorBullseye3 => Construct(0xbf68);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorBullseye4 => Construct(0xbf6a);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorBullseye5 => Construct(0xbf6c);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorBullseye6 => Construct(0xbf6e);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorBullseye10 => Construct(0xbf70);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorSilenced2 => Construct(0x83a5);
            public static FormLink<IEnchantmentGetter> DLC06ScrollWeakenLockNovice => Construct(0x83a4);
            public static FormLink<IEnchantmentGetter> DLC06EnchantmentKnockdown => Construct(0xba40);
            public static FormLink<IEnchantmentGetter> DLC06EnchantmentBlindness => Construct(0xba46);
            public static FormLink<IEnchantmentGetter> DLC06EnchantmentVenegence1 => Construct(0xba48);
            public static FormLink<IEnchantmentGetter> DLC06EnchantmentVenegence2 => Construct(0xba49);
            public static FormLink<IEnchantmentGetter> DLC06EnchantmentVenegence3 => Construct(0xba4b);
            public static FormLink<IEnchantmentGetter> DLC06EnWeapDamageFatigue50 => Construct(0xba4d);
            public static FormLink<IEnchantmentGetter> DLC06EnWeapDamageFatigue100 => Construct(0xba4f);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorSilenced3 => Construct(0xbf50);
            public static FormLink<IEnchantmentGetter> DLC06EnchArmorSilenced4 => Construct(0xbf51);
        }
    }
}
