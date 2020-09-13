namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class IdleMarker
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1VQ07IdleMarker => ModKey.MakeFormKey(0x12241);
            public static FormKey DLC1FalmerSquatIdleMarker => ModKey.MakeFormKey(0x180e0);
        }
    }
}
