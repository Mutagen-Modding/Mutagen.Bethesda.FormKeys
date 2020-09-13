namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Ingredient
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ccBGS_RootThornHookIngredient => ModKey.MakeFormKey(0x306f);
            public static FormKey ccBGS_RootScreamingMawIngredient => ModKey.MakeFormKey(0x306e);
            public static FormKey ccBGS_RootRotScaleIngredient => ModKey.MakeFormKey(0x306d);
        }
    }
}
