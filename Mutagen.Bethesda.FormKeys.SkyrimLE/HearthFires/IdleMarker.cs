using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class IdleMarker
        {
            private static FormLink<IIdleMarkerGetter> Construct(uint id) => new FormLink<IIdleMarkerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIdleMarkerGetter> IdleChildPlayDirtMarker => Construct(0xd835);
            public static FormLink<IIdleMarkerGetter> IdleChildPlayDollMarker => Construct(0xd82d);
            public static FormLink<IIdleMarkerGetter> BYOHUrchin_AlesanChickenFeedingMarker => Construct(0x3f64);
            public static FormLink<IIdleMarkerGetter> SweepPatrolMarker => Construct(0x3f31);
        }
    }
}
