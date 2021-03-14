using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Ammunition
        {
            private static FormLink<IAmmunitionGetter> Construct(uint id) => new FormLink<IAmmunitionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAmmunitionGetter> DLC2DwarvenBallistaBolt => Construct(0x339a1);
            public static FormLink<IAmmunitionGetter> DLC2NordicArrow => Construct(0x2623b);
            public static FormLink<IAmmunitionGetter> DLC2StalhrimArrow => Construct(0x26239);
            public static FormLink<IAmmunitionGetter> DLC2BloodskalAmmo => Construct(0x1aecf);
            public static FormLink<IAmmunitionGetter> DLC2RieklingSpearThrown => Construct(0x17720);
        }
    }
}
