using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Eye
        {
            private static FormLink<IEyeGetter> Construct(uint id) => new FormLink<IEyeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEyeGetter> eyeOrdered => Construct(0x5fa43);
            public static FormLink<IEyeGetter> EyeGoldenSaint => Construct(0x54bba);
            public static FormLink<IEyeGetter> eyeDarkSeducer => Construct(0x54bb9);
            public static FormLink<IEyeGetter> eyeReanimate => Construct(0x1a);
            public static FormLink<IEyeGetter> eyeArgonian => Construct(0x3e91e);
            public static FormLink<IEyeGetter> eyeVampire => Construct(0x3b379);
            public static FormLink<IEyeGetter> eyeKhajiit => Construct(0x375c8);
            public static FormLink<IEyeGetter> eyeDremora => Construct(0x342c1);
            public static FormLink<IEyeGetter> eyeOrc => Construct(0x2730a);
            public static FormLink<IEyeGetter> eyeGreen => Construct(0x27309);
            public static FormLink<IEyeGetter> eyeDefault => Construct(0x27308);
            public static FormLink<IEyeGetter> eyeDarkElf => Construct(0x27307);
            public static FormLink<IEyeGetter> eyeBrown => Construct(0x27306);
        }
    }
}
