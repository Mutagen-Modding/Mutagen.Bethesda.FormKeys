using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Enchantment
        {
            private static FormLink<IEnchantmentGetter> Construct(uint id) => new FormLink<IEnchantmentGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEnchantmentGetter> LairVileEnEviscerator05 => Construct(0xb972);
            public static FormLink<IEnchantmentGetter> LairVileEnEviscerator10 => Construct(0xb974);
            public static FormLink<IEnchantmentGetter> LairVileEnEviscerator15 => Construct(0xb976);
            public static FormLink<IEnchantmentGetter> LairVileEnEviscerator20 => Construct(0xb978);
            public static FormLink<IEnchantmentGetter> LairVileEnEviscerator25 => Construct(0xb97a);
            public static FormLink<IEnchantmentGetter> LairVileEnEviscerator30 => Construct(0xb97c);
            public static FormLink<IEnchantmentGetter> LairVileEnRaimentScar01 => Construct(0xbe6b);
            public static FormLink<IEnchantmentGetter> LairVileEnRaimentScar05 => Construct(0xbe6c);
            public static FormLink<IEnchantmentGetter> LairVileEnRaimentScar10 => Construct(0xbe6f);
            public static FormLink<IEnchantmentGetter> LairVileEnRaimentScar15 => Construct(0xbe71);
            public static FormLink<IEnchantmentGetter> LairVileEnRaimentScar20 => Construct(0xbe73);
            public static FormLink<IEnchantmentGetter> LairVileEnRaimentScar25 => Construct(0xbe75);
            public static FormLink<IEnchantmentGetter> LairVileEnEviscerator01 => Construct(0xb970);
        }
    }
}
