using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class Eyes
        {
            private static FormLink<IEyesGetter> Construct(uint id) => new FormLink<IEyesGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEyesGetter> EyeKhajiitMale => Construct(0x81ba6);
            public static FormLink<IEyesGetter> EyeArgonianFemale => Construct(0x69ce1);
            public static FormLink<IEyesGetter> EyeArgonianMale => Construct(0x69cdf);
            public static FormLink<IEyesGetter> EyeWoodElf => Construct(0x3f203);
            public static FormLink<IEyesGetter> EyeHighElf => Construct(0x3f202);
            public static FormLink<IEyesGetter> EyeDarkElf => Construct(0x1938f);
            public static FormLink<IEyesGetter> eyebrown => Construct(0x135bd);
            public static FormLink<IEyesGetter> blue => Construct(0xa65);
        }
    }
}
