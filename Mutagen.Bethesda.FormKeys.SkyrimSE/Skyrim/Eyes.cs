namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Eyes
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey EyeKhajiitMale => ModKey.MakeFormKey(0x81ba6);
            public static FormKey EyeArgonianFemale => ModKey.MakeFormKey(0x69ce1);
            public static FormKey EyeArgonianMale => ModKey.MakeFormKey(0x69cdf);
            public static FormKey EyeWoodElf => ModKey.MakeFormKey(0x3f203);
            public static FormKey EyeHighElf => ModKey.MakeFormKey(0x3f202);
            public static FormKey EyeDarkElf => ModKey.MakeFormKey(0x1938f);
            public static FormKey eyebrown => ModKey.MakeFormKey(0x135bd);
            public static FormKey blue => ModKey.MakeFormKey(0xa65);
        }
    }
}
