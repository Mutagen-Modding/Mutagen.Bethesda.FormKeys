// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Activator
        {
            private static FormLink<IActivatorGetter> Construct(uint id) => new FormLink<IActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActivatorGetter> ccBGS_ARSarcophagusTopAnim01 => Construct(0x3222);
            public static FormLink<IActivatorGetter> ccBGS_ARSecretDoor01 => Construct(0x3221);
            public static FormLink<IActivatorGetter> ccBGS_ARTrapLongSpikes01 => Construct(0x3208);
            public static FormLink<IActivatorGetter> ccBGS_ARFXTwinkleLights01 => Construct(0x3207);
            public static FormLink<IActivatorGetter> ccBGS_ARTrigPressurePlate01 => Construct(0x3206);
            public static FormLink<IActivatorGetter> ccBGS_ARFloorSmasher01 => Construct(0x3205);
            public static FormLink<IActivatorGetter> ccBGS_ARTrapBridgeBlade01 => Construct(0x3204);
            public static FormLink<IActivatorGetter> ccBGS_ARSwitch01 => Construct(0x3158);
            public static FormLink<IActivatorGetter> ccBGS_ARGate01 => Construct(0x3157);
            public static FormLink<IActivatorGetter> ccBGS_ARButton01 => Construct(0x3156);
            public static FormLink<IActivatorGetter> ccBGS_RootScreamingMawActivator => Construct(0x3090);
            public static FormLink<IActivatorGetter> ccBGS_RootThornHookActivator => Construct(0x308f);
            public static FormLink<IActivatorGetter> ccBGS_FlameStalkActivator01 => Construct(0x308e);
            public static FormLink<IActivatorGetter> ccBGS_FlameStalkActivator02 => Construct(0x308d);
            public static FormLink<IActivatorGetter> ccBGS_RootRotScaleActivator => Construct(0x308c);
            public static FormLink<IActivatorGetter> Patch1_8DLC1DoorFix => Construct(0x9a0);
            public static FormLink<IActivatorGetter> WEDL06LetrushCleanupTrigger => Construct(0x99d);
            public static FormLink<IActivatorGetter> TG09DoorOverrideFixTrigger => Construct(0x80e);
            public static FormLink<IActivatorGetter> dunDA14PortalDisableTrigger => Construct(0x80c);
            public static FormLink<IActivatorGetter> C05RepairTrigger => Construct(0x800);
        }
    }
}
