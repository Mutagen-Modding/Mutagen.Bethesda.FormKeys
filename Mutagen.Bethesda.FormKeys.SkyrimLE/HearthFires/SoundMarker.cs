using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class SoundMarker
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<ISoundMarkerGetter> Construct(uint id) => new FormLink<ISoundMarkerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundMarkerGetter> OBJMineClay => Construct(0xba4);
        }
    }
}
