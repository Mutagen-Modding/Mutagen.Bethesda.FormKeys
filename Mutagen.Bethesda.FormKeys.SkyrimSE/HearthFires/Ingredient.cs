using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Ingredient
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IIngredientGetter> Construct(uint id) => new FormLink<IIngredientGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIngredientGetter> BYOHHawkEgg01 => Construct(0xf1cc);
            public static FormLink<IIngredientGetter> BYOHSalmonRoe01 => Construct(0x3545);
        }
    }
}
