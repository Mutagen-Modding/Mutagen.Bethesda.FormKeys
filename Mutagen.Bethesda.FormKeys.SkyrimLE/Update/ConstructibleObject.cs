using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class ConstructibleObject
        {
            private static FormLink<IConstructibleObjectGetter> Construct(uint id) => new FormLink<IConstructibleObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IConstructibleObjectGetter> RecipeArmorImperialShieldLight => Construct(0x9d3);
            public static FormLink<IConstructibleObjectGetter> RecipeArmorImperialHelmetLight => Construct(0x9d2);
            public static FormLink<IConstructibleObjectGetter> RecipeArmorImperialGauntletsLight => Construct(0x9d1);
            public static FormLink<IConstructibleObjectGetter> RecipeArmorImperialBootsLight => Construct(0x9d0);
            public static FormLink<IConstructibleObjectGetter> RecipeArmorImperialCuirassLight => Construct(0x9cf);
        }
    }
}
