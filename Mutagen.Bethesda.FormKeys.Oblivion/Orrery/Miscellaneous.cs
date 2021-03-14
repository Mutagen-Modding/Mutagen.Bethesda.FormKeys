using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Miscellaneous
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<IMiscellaneousGetter> Construct(uint id) => new FormLink<IMiscellaneousGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMiscellaneousGetter> DLCOrreryDwarvenCoherer => Construct(0x11bee5);
            public static FormLink<IMiscellaneousGetter> DLCOrreryDwarvenTube => Construct(0x11bee6);
            public static FormLink<IMiscellaneousGetter> DLCOrreryDwarvenCylinder => Construct(0x11bee7);
            public static FormLink<IMiscellaneousGetter> DLCOrreryDwarvenCog1 => Construct(0x11bee8);
            public static FormLink<IMiscellaneousGetter> DLCOrreryDwarvenCog2 => Construct(0x11bee9);
        }
    }
}
