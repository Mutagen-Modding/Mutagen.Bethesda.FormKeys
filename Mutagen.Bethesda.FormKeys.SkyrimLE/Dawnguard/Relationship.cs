namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Relationship
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1DurnehviirPlayer => ModKey.MakeFormKey(0xc71b);
        }
    }
}
