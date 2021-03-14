using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class SoundMarker
        {
            private static FormLink<ISoundMarkerGetter> Construct(uint id) => new FormLink<ISoundMarkerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundMarkerGetter> OBJMineClay => Construct(0xba4);
        }
    }
}
