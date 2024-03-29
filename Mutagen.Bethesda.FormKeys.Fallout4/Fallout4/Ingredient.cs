// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class Ingredient
    {
        private static FormLink<IIngredientGetter> Construct(uint id) => new FormLink<IIngredientGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IIngredientGetter> CopperPipe => Construct(0x1d7fc);
    }
}
