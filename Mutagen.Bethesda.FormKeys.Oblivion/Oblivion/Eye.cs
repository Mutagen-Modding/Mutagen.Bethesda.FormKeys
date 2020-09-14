namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Eye
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            public static FormKey eyeOrdered => ModKey.MakeFormKey(0x5fa43);
            public static FormKey EyeGoldenSaint => ModKey.MakeFormKey(0x54bba);
            public static FormKey eyeDarkSeducer => ModKey.MakeFormKey(0x54bb9);
            public static FormKey eyeReanimate => ModKey.MakeFormKey(0x1a);
            public static FormKey eyeArgonian => ModKey.MakeFormKey(0x3e91e);
            public static FormKey eyeVampire => ModKey.MakeFormKey(0x3b379);
            public static FormKey eyeKhajiit => ModKey.MakeFormKey(0x375c8);
            public static FormKey eyeDremora => ModKey.MakeFormKey(0x342c1);
            public static FormKey eyeOrc => ModKey.MakeFormKey(0x2730a);
            public static FormKey eyeGreen => ModKey.MakeFormKey(0x27309);
            public static FormKey eyeDefault => ModKey.MakeFormKey(0x27308);
            public static FormKey eyeDarkElf => ModKey.MakeFormKey(0x27307);
            public static FormKey eyeBrown => ModKey.MakeFormKey(0x27306);
        }
    }
}
