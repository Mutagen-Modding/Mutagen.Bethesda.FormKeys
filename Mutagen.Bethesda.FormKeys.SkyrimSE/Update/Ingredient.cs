using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Ingredient
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IIngredientGetter> Construct(uint id) => new FormLink<IIngredientGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIngredientGetter> ccBGS_RootThornHookIngredient => Construct(0x306f);
            public static FormLink<IIngredientGetter> ccBGS_RootScreamingMawIngredient => Construct(0x306e);
            public static FormLink<IIngredientGetter> ccBGS_RootRotScaleIngredient => Construct(0x306d);
        }
    }
}
