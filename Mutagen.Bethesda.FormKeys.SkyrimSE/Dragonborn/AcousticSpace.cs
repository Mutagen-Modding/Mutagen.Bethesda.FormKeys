namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class AcousticSpace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey IntDLC2ApocryphaBookPOI => ModKey.MakeFormKey(0x39e50);
            public static FormKey IntDLC2TelMithrynDry => ModKey.MakeFormKey(0x39751);
            public static FormKey IntDLC2TelMithryn => ModKey.MakeFormKey(0x3974d);
        }
    }
}
