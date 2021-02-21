using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Enchantment
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IEnchantmentGetter> Construct(uint id) => new FormLink<IEnchantmentGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEnchantmentGetter> FrostcragEnAppRingEnch => Construct(0x5e37);
        }
    }
}
