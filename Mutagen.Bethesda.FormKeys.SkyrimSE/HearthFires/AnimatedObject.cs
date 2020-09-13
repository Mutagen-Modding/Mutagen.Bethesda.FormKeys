namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class AnimatedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey AnimObjectDoll => ModKey.MakeFormKey(0x16a4f);
            public static FormKey AnimObjectWoodScrap => ModKey.MakeFormKey(0x14352);
            public static FormKey AnimObjectDrawBlade => ModKey.MakeFormKey(0xa256);
            public static FormKey AnimObjectBreadPeel => ModKey.MakeFormKey(0x2843);
            public static FormKey AnimObjectDumplingRight => ModKey.MakeFormKey(0x2842);
            public static FormKey AnimObjectDumplingLeft => ModKey.MakeFormKey(0x2841);
        }
    }
}
