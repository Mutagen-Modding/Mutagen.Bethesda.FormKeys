namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Armor
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey ClothesChild05 => ModKey.MakeFormKey(0xc740);
            public static FormKey ClothesChild04 => ModKey.MakeFormKey(0xc73e);
        }
    }
}
