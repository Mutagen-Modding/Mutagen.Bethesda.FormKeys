namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Ingredient
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHHawkEgg01 => ModKey.MakeFormKey(0xf1cc);
            public static FormKey BYOHSalmonRoe01 => ModKey.MakeFormKey(0x3545);
        }
    }
}
