namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class IdleMarker
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC2AshHopperSleepMarker => ModKey.MakeFormKey(0x34ee8);
            public static FormKey DLC2SeekerIdleMarker => ModKey.MakeFormKey(0x2a629);
        }
    }
}
