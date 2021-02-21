using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class MagicEffect
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IMagicEffectGetter> Construct(uint id) => new FormLink<IMagicEffectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMagicEffectGetter> MS12WhitePhialEffect => Construct(0x9d6);
            public static FormLink<IMagicEffectGetter> EnchSummonStormThrall => Construct(0x845);
            public static FormLink<IMagicEffectGetter> EnchSummonFrostThrall => Construct(0x844);
            public static FormLink<IMagicEffectGetter> EnchSummonFlameThrall => Construct(0x843);
            public static FormLink<IMagicEffectGetter> EnchSummonStormAtronach => Construct(0x842);
            public static FormLink<IMagicEffectGetter> EnchSummonFrostAtronach => Construct(0x841);
            public static FormLink<IMagicEffectGetter> EnchSummonFlameAtronach => Construct(0x840);
        }
    }
}
