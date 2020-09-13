namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class ConstructibleObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey RecipeArmorImperialShieldLight => ModKey.MakeFormKey(0x9d3);
            public static FormKey RecipeArmorImperialHelmetLight => ModKey.MakeFormKey(0x9d2);
            public static FormKey RecipeArmorImperialGauntletsLight => ModKey.MakeFormKey(0x9d1);
            public static FormKey RecipeArmorImperialBootsLight => ModKey.MakeFormKey(0x9d0);
            public static FormKey RecipeArmorImperialCuirassLight => ModKey.MakeFormKey(0x9cf);
        }
    }
}
