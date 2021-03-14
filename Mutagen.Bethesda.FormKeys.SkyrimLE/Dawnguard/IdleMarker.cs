using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class IdleMarker
        {
            private static FormLink<IIdleMarkerGetter> Construct(uint id) => new FormLink<IIdleMarkerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIdleMarkerGetter> DLC1VQ07IdleMarker => Construct(0x12241);
            public static FormLink<IIdleMarkerGetter> DLC1FalmerSquatIdleMarker => Construct(0x180e0);
        }
    }
}
