using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Light
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILightGetter> DLCOrreryDomeBaseLight => Construct(0x1243b3);
            public static FormLink<ILightGetter> DLCOrreryPanelLight => Construct(0x1243b5);
            public static FormLink<ILightGetter> DLCOrreryConsoleLight => Construct(0x1243b7);
            public static FormLink<ILightGetter> DLCOrreryDomeLight => Construct(0x1243b9);
            public static FormLink<ILightGetter> DLCOrrerySpotLight => Construct(0x1243c1);
            public static FormLink<ILightGetter> DLCOrreryWallLight01 => Construct(0x1283b8);
        }
    }
}
