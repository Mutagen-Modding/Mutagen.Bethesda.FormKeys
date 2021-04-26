// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Enchantment
        {
            private static FormLink<IEnchantmentGetter> Construct(uint id) => new FormLink<IEnchantmentGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEnchantmentGetter> FrostcragEnAppRingEnch => Construct(0x5e37);
        }
    }
}
