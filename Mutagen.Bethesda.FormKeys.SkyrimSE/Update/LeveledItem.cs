namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class LeveledItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ccFFBSSE002_LItemCrossbows => ModKey.MakeFormKey(0x3055);
            public static FormKey cc_ShiveringIsleIngredients => ModKey.MakeFormKey(0x2fda);
            public static FormKey LLI_Vendor_SpecialItems => ModKey.MakeFormKey(0x2f94);
        }
    }
}
