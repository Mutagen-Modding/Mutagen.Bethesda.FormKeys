namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey DLCOrreryBanditNote => ModKey.MakeFormKey(0x11c3d2);
            public static FormKey DLCOrreryNote => ModKey.MakeFormKey(0x11b9fd);
            public static FormKey DLCOrreryDomeBaseLight => ModKey.MakeFormKey(0x1243b3);
            public static FormKey DLCOrreryPanelLight => ModKey.MakeFormKey(0x1243b5);
            public static FormKey DLCOrreryConsoleLight => ModKey.MakeFormKey(0x1243b7);
            public static FormKey DLCOrreryDomeLight => ModKey.MakeFormKey(0x1243b9);
            public static FormKey DLCOrrerySpotLight => ModKey.MakeFormKey(0x1243c1);
            public static FormKey DLCOrreryWallLight01 => ModKey.MakeFormKey(0x1283b8);
            public static FormKey DLCOrreryDwarvenCoherer => ModKey.MakeFormKey(0x11bee5);
            public static FormKey DLCOrreryDwarvenTube => ModKey.MakeFormKey(0x11bee6);
            public static FormKey DLCOrreryDwarvenCylinder => ModKey.MakeFormKey(0x11bee7);
            public static FormKey DLCOrreryDwarvenCog1 => ModKey.MakeFormKey(0x11bee8);
            public static FormKey DLCOrreryDwarvenCog2 => ModKey.MakeFormKey(0x11bee9);
            public static FormKey DLCOrreryGoldReward => ModKey.MakeFormKey(0x123015);
        }
    }
}
