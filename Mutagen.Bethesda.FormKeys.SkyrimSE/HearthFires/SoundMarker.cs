namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class SoundMarker
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey OBJMineClay => ModKey.MakeFormKey(0xba4);
        }
    }
}
