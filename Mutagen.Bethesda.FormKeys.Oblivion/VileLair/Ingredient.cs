using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Ingredient
        {
            private static FormLink<IIngredientGetter> Construct(uint id) => new FormLink<IIngredientGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIngredientGetter> LairVileSalts => Construct(0x1372);
            public static FormLink<IIngredientGetter> LairVileChokeberry => Construct(0x9bfe);
        }
    }
}
