namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Outfit
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey ChildOutfit05 => ModKey.MakeFormKey(0xc4d);
            public static FormKey ChildOutfit04 => ModKey.MakeFormKey(0xc4c);
            public static FormKey BYOHPlayerHousecarlOutfitFalkreath => ModKey.MakeFormKey(0x5214);
        }
    }
}
