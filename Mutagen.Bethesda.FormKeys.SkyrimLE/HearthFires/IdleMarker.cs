namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class IdleMarker
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey IdleChildPlayDirtMarker => ModKey.MakeFormKey(0xd835);
            public static FormKey IdleChildPlayDollMarker => ModKey.MakeFormKey(0xd82d);
            public static FormKey BYOHUrchin_AlesanChickenFeedingMarker => ModKey.MakeFormKey(0x3f64);
            public static FormKey SweepPatrolMarker => ModKey.MakeFormKey(0x3f31);
        }
    }
}
