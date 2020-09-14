namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            public static FormKey DL9IronVein01 => ModKey.MakeFormKey(0x14d7);
            public static FormKey DL9HeartChest => ModKey.MakeFormKey(0x1af3);
            public static FormKey DL9OutdoorHutch => ModKey.MakeFormKey(0x217b);
            public static FormKey DL9Knapsack => ModKey.MakeFormKey(0x157d);
            public static FormKey DL9DrinkCupboard => ModKey.MakeFormKey(0x218b);
            public static FormKey DL9FoodBarrel => ModKey.MakeFormKey(0x1b2c);
            public static FormKey DL9IronVein02 => ModKey.MakeFormKey(0x14d1);
        }
    }
}
