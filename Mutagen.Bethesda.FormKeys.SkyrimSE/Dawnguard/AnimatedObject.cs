namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class AnimatedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey AnimObjectWoodScrap => ModKey.MakeFormKey(0x13795);
            public static FormKey AnimObjectDrawBlade => ModKey.MakeFormKey(0x13794);
            public static FormKey AnimObjectVampireMeat => ModKey.MakeFormKey(0x11e1e);
            public static FormKey AnimObjectSilverPitcher => ModKey.MakeFormKey(0xa255);
        }
    }
}
