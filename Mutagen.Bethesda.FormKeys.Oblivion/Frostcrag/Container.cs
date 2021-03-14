using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Container
        {
            private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IContainerGetter> CounterMiddle02ClutterMagesGuildFrostCrag => Construct(0x5d6f);
            public static FormLink<IContainerGetter> CrateClutterMiddle03FC => Construct(0x353b);
            public static FormLink<IContainerGetter> CrateClutterMiddle05FC => Construct(0x353c);
            public static FormLink<IContainerGetter> VendorMysticEmporiumAurelinwae => Construct(0x124c);
            public static FormLink<IContainerGetter> DLCFrostcragChestJewelryUpper01 => Construct(0x5e34);
            public static FormLink<IContainerGetter> FrostcragSpireAddons => Construct(0x124e);
            public static FormLink<IContainerGetter> FrostcragTestContainer => Construct(0xd48);
        }
    }
}
