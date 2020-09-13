namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Climate
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC2ApocryphaClimateNew => ModKey.MakeFormKey(0x34cfc);
            public static FormKey DLC2ApocryphaClimate => ModKey.MakeFormKey(0x1c48e);
        }
    }
}
