namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class MagicEffect
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey MS12WhitePhialEffect => ModKey.MakeFormKey(0x9d6);
            public static FormKey EnchSummonStormThrall => ModKey.MakeFormKey(0x845);
            public static FormKey EnchSummonFrostThrall => ModKey.MakeFormKey(0x844);
            public static FormKey EnchSummonFlameThrall => ModKey.MakeFormKey(0x843);
            public static FormKey EnchSummonStormAtronach => ModKey.MakeFormKey(0x842);
            public static FormKey EnchSummonFrostAtronach => ModKey.MakeFormKey(0x841);
            public static FormKey EnchSummonFlameAtronach => ModKey.MakeFormKey(0x840);
        }
    }
}
