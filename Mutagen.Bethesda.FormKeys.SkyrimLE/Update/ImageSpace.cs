namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class ImageSpace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey UnderwaterImageSpace => ModKey.MakeFormKey(0x946);
        }
    }
}
