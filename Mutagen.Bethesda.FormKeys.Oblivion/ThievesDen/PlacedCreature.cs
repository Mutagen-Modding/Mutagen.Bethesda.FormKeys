using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class PlacedCreature
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IPlacedCreatureGetter> Construct(uint id) => new FormLink<IPlacedCreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedCreatureGetter> DLC06PirateSkeleton06 => Construct(0x13dc0);
            public static FormLink<IPlacedCreatureGetter> DLC06PirateSkeleton05 => Construct(0x13dbf);
            public static FormLink<IPlacedCreatureGetter> DLC06PirateSkeleton04 => Construct(0x13dbe);
            public static FormLink<IPlacedCreatureGetter> DLC06PirateSkeleton02 => Construct(0x13dbc);
            public static FormLink<IPlacedCreatureGetter> DLC06PirateSkeleton03 => Construct(0x13dbd);
            public static FormLink<IPlacedCreatureGetter> DLC06PirateSkeleton01 => Construct(0x13dbb);
            public static FormLink<IPlacedCreatureGetter> DLC06PirateCaptain => Construct(0x178bb);
        }
    }
}
