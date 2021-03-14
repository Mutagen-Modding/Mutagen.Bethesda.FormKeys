using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class IdleMarker
        {
            private static FormLink<IIdleMarkerGetter> Construct(uint id) => new FormLink<IIdleMarkerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIdleMarkerGetter> DLC2AshHopperSleepMarker => Construct(0x34ee8);
            public static FormLink<IIdleMarkerGetter> DLC2SeekerIdleMarker => Construct(0x2a629);
        }
    }
}
