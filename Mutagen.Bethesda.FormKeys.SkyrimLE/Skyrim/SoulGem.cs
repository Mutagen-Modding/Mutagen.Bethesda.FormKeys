namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class SoulGem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey FFRiften14SoulGem => ModKey.MakeFormKey(0x43e26);
            public static FormKey WhiterunSoulGem => ModKey.MakeFormKey(0x94e40);
            public static FormKey DummySoulGem => ModKey.MakeFormKey(0x6a0c2);
            public static FormKey DA01SoulGemBlackStar => ModKey.MakeFormKey(0x63b29);
            public static FormKey DA01SoulGemAzurasStar => ModKey.MakeFormKey(0x63b27);
            public static FormKey SoulGemBlackFilled => ModKey.MakeFormKey(0x2e504);
            public static FormKey SoulGemBlack => ModKey.MakeFormKey(0x2e500);
            public static FormKey SoulGemGrandFilled => ModKey.MakeFormKey(0x2e4ff);
            public static FormKey SoulGemGrand => ModKey.MakeFormKey(0x2e4fc);
            public static FormKey SoulGemGreaterFilled => ModKey.MakeFormKey(0x2e4fb);
            public static FormKey SoulGemGreater => ModKey.MakeFormKey(0x2e4f4);
            public static FormKey SoulGemCommonFilled => ModKey.MakeFormKey(0x2e4f3);
            public static FormKey SoulGemCommon => ModKey.MakeFormKey(0x2e4e6);
            public static FormKey SoulGemLesserFilled => ModKey.MakeFormKey(0x2e4e5);
            public static FormKey SoulGemLesser => ModKey.MakeFormKey(0x2e4e4);
            public static FormKey SoulGemPettyFilled => ModKey.MakeFormKey(0x2e4e3);
            public static FormKey SoulGemPetty => ModKey.MakeFormKey(0x2e4e2);
        }
    }
}
