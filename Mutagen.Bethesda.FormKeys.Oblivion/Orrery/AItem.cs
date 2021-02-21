using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<IAItemGetter> Construct(uint id) => new FormLink<IAItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAItemGetter> DLCOrreryBanditNote => Construct(0x11c3d2);
            public static FormLink<IAItemGetter> DLCOrreryNote => Construct(0x11b9fd);
            public static FormLink<IAItemGetter> DLCOrreryDomeBaseLight => Construct(0x1243b3);
            public static FormLink<IAItemGetter> DLCOrreryPanelLight => Construct(0x1243b5);
            public static FormLink<IAItemGetter> DLCOrreryConsoleLight => Construct(0x1243b7);
            public static FormLink<IAItemGetter> DLCOrreryDomeLight => Construct(0x1243b9);
            public static FormLink<IAItemGetter> DLCOrrerySpotLight => Construct(0x1243c1);
            public static FormLink<IAItemGetter> DLCOrreryWallLight01 => Construct(0x1283b8);
            public static FormLink<IAItemGetter> DLCOrreryDwarvenCoherer => Construct(0x11bee5);
            public static FormLink<IAItemGetter> DLCOrreryDwarvenTube => Construct(0x11bee6);
            public static FormLink<IAItemGetter> DLCOrreryDwarvenCylinder => Construct(0x11bee7);
            public static FormLink<IAItemGetter> DLCOrreryDwarvenCog1 => Construct(0x11bee8);
            public static FormLink<IAItemGetter> DLCOrreryDwarvenCog2 => Construct(0x11bee9);
            public static FormLink<IAItemGetter> DLCOrreryGoldReward => Construct(0x123015);
        }
    }
}
