using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IContainerGetter> LairVileCrateRectangle => Construct(0x3197);
            public static FormLink<IContainerGetter> DeepscornChestVendorRowley => Construct(0x65ad);
            public static FormLink<IContainerGetter> DeepscornChestVendorRowleyAddons => Construct(0x65af);
            public static FormLink<IContainerGetter> LairVileCrateOther => Construct(0x3198);
            public static FormLink<IContainerGetter> LairVileBarrellfood => Construct(0x3199);
            public static FormLink<IContainerGetter> LairVileMinionChest => Construct(0x7e5f);
            public static FormLink<IContainerGetter> LairVileMinionFootlocker => Construct(0x319a);
            public static FormLink<IContainerGetter> LairVileDesk => Construct(0x319c);
            public static FormLink<IContainerGetter> LairVileDresser => Construct(0x319d);
            public static FormLink<IContainerGetter> LairVileCupboardFood => Construct(0x319e);
            public static FormLink<IContainerGetter> LairVileCupboardFoodUpper => Construct(0x319f);
            public static FormLink<IContainerGetter> LairVileCupboardFoodUpperDrinks => Construct(0x31a0);
            public static FormLink<IContainerGetter> LairVileArmoire => Construct(0x60b3);
            public static FormLink<IContainerGetter> LairVileSaltRock03 => Construct(0x208a);
            public static FormLink<IContainerGetter> LairVileSaltRock01 => Construct(0x1b86);
            public static FormLink<IContainerGetter> LairVileSaltRock02 => Construct(0x2087);
            public static FormLink<IContainerGetter> LairVileCrateSquare => Construct(0x3196);
            public static FormLink<IContainerGetter> LairVileEvisceratorCase => Construct(0x60c5);
            public static FormLink<IContainerGetter> LairVileHiddenBag01 => Construct(0x14cdb);
            public static FormLink<IContainerGetter> LairVileHiddenBag02 => Construct(0x14cdd);
            public static FormLink<IContainerGetter> LairVileHiddenBag03 => Construct(0x14cdf);
            public static FormLink<IContainerGetter> LairVileHiddenBag04 => Construct(0x14ce1);
            public static FormLink<IContainerGetter> LairVilePoisonSupply => Construct(0x14ce9);
        }
    }
}
