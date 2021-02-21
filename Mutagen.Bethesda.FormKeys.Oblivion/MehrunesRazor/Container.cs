using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IContainerGetter> DL9IronVein01 => Construct(0x14d7);
            public static FormLink<IContainerGetter> DL9HeartChest => Construct(0x1af3);
            public static FormLink<IContainerGetter> DL9OutdoorHutch => Construct(0x217b);
            public static FormLink<IContainerGetter> DL9Knapsack => Construct(0x157d);
            public static FormLink<IContainerGetter> DL9DrinkCupboard => Construct(0x218b);
            public static FormLink<IContainerGetter> DL9FoodBarrel => Construct(0x1b2c);
            public static FormLink<IContainerGetter> DL9IronVein02 => Construct(0x14d1);
        }
    }
}
