namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Worldspace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC2SolstheimWorld => ModKey.MakeFormKey(0x800);
            public static FormKey DLC2ApocryphaWorld => ModKey.MakeFormKey(0x1c0b2);
        }
    }
}
