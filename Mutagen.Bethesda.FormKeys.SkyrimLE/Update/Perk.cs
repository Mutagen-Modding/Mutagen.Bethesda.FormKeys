namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Perk
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey MS04AncientKnowledge => ModKey.MakeFormKey(0x9d4);
        }
    }
}
