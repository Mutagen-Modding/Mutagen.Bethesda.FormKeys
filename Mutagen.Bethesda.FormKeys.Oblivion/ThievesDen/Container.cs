namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            public static FormKey DLC06SupplierChest => ModKey.MakeFormKey(0x74cd);
            public static FormKey DLC06FletcherChest => ModKey.MakeFormKey(0x79c4);
            public static FormKey DLC06SecurityChest => ModKey.MakeFormKey(0x79c6);
            public static FormKey DLC06FenceChest => ModKey.MakeFormKey(0x74cf);
            public static FormKey DLC06ChestCaptainsQuarters => ModKey.MakeFormKey(0xce30);
            public static FormKey DLC06TrainerChest => ModKey.MakeFormKey(0x348d);
            public static FormKey DLC06StealthChest => ModKey.MakeFormKey(0x8d8c);
            public static FormKey DLC06FirstMateChest => ModKey.MakeFormKey(0x8d8e);
            public static FormKey DLCChestOfDrawers => ModKey.MakeFormKey(0x1a4ef);
            public static FormKey DLCCupboardFoodUpperDrinks => ModKey.MakeFormKey(0x1a4f0);
        }
    }
}
