using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IContainerGetter> BYOHHouseVendorChestSmall => Construct(0xc44);
            public static FormLink<IContainerGetter> BYOHHouseVendorChest => Construct(0x80e);
            public static FormLink<IContainerGetter> BYOHBYOHApiary => Construct(0x12a54);
            public static FormLink<IContainerGetter> BYOHHouseBarrelFish01_NoRespawn => Construct(0xd90d);
            public static FormLink<IContainerGetter> BYOHHouseUpperEndTable01 => Construct(0x9b89);
            public static FormLink<IContainerGetter> BYOHHouseStrongBox => Construct(0x9868);
            public static FormLink<IContainerGetter> BYOHHouseNobleChestDrawers01 => Construct(0x837e);
            public static FormLink<IContainerGetter> BYOHHouseNobleCupboard02 => Construct(0x837d);
            public static FormLink<IContainerGetter> BYOHHouseNobleWardrobe01 => Construct(0x837c);
            public static FormLink<IContainerGetter> BYOHHouseUpperEndTable02 => Construct(0x837b);
            public static FormLink<IContainerGetter> BYOHHouseNobleCupboard01 => Construct(0x837a);
            public static FormLink<IContainerGetter> BYOHHouseNobleNightTable01 => Construct(0x8379);
            public static FormLink<IContainerGetter> BYOHHouseUpperWardrobe01 => Construct(0x8378);
            public static FormLink<IContainerGetter> BYOHHouseUpperCupboard01 => Construct(0x8377);
            public static FormLink<IContainerGetter> BYOHHouseKnapsack => Construct(0x8376);
            public static FormLink<IContainerGetter> BYOHHouseNobleChestDrawers02 => Construct(0x8375);
            public static FormLink<IContainerGetter> BYOHHouseSatchel => Construct(0x8374);
            public static FormLink<IContainerGetter> BYOHHouseUpperDresser01 => Construct(0x8373);
            public static FormLink<IContainerGetter> BYOHHouseNobleChest01 => Construct(0x8372);
            public static FormLink<IContainerGetter> BYOHHouseUpperChest => Construct(0x8370);
            public static FormLink<IContainerGetter> BYOHPlanterContainer => Construct(0x8241);
            public static FormLink<IContainerGetter> BYOHHouseSafewithLockPlayer => Construct(0x59d1);
            public static FormLink<IContainerGetter> TreasSatchelEMPTY => Construct(0x4111);
            public static FormLink<IContainerGetter> BYOHUrchin_SofieChest => Construct(0x4038);
            public static FormLink<IContainerGetter> BYOHHouseCraftingChest => Construct(0x3055);
        }
    }
}
