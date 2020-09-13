namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Ammunition
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC2DwarvenBallistaBolt => ModKey.MakeFormKey(0x339a1);
            public static FormKey DLC2NordicArrow => ModKey.MakeFormKey(0x2623b);
            public static FormKey DLC2StalhrimArrow => ModKey.MakeFormKey(0x26239);
            public static FormKey DLC2BloodskalAmmo => ModKey.MakeFormKey(0x1aecf);
            public static FormKey DLC2RieklingSpearThrown => ModKey.MakeFormKey(0x17720);
        }
    }
}
