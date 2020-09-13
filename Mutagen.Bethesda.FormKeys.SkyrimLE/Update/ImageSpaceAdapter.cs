namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class ImageSpaceAdapter
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey VATSImodDOFFAR => ModKey.MakeFormKey(0x931);
            public static FormKey VATSImodDOFClose => ModKey.MakeFormKey(0x8cd);
        }
    }
}
