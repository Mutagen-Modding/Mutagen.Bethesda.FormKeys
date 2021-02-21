using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Outfit
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IOutfitGetter> Construct(uint id) => new FormLink<IOutfitGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IOutfitGetter> ChildOutfit05 => Construct(0xc4d);
            public static FormLink<IOutfitGetter> ChildOutfit04 => Construct(0xc4c);
            public static FormLink<IOutfitGetter> BYOHPlayerHousecarlOutfitFalkreath => Construct(0x5214);
        }
    }
}
