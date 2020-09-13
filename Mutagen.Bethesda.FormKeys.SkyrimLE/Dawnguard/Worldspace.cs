namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Worldspace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC01FalmerValley => ModKey.MakeFormKey(0xbb5);
            public static FormKey DLC01SoulCairn => ModKey.MakeFormKey(0x1408);
            public static FormKey DLC1HunterHQWorld => ModKey.MakeFormKey(0x1db8);
            public static FormKey DLC1ForebearsHoldout => ModKey.MakeFormKey(0x2f64);
            public static FormKey TestMeganWorld => ModKey.MakeFormKey(0x42c2);
            public static FormKey DLC1AncestorsGladeWorld => ModKey.MakeFormKey(0x48c7);
            public static FormKey DLC1DarkfallPassageWorld => ModKey.MakeFormKey(0x4bea);
            public static FormKey DLC01Boneyard => ModKey.MakeFormKey(0x528d);
            public static FormKey DLC1VampireCastleCourtyard => ModKey.MakeFormKey(0x7202);
        }
    }
}
