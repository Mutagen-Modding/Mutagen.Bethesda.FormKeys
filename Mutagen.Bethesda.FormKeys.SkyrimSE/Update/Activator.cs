namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Activator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ccBGS_RootScreamingMawActivator => ModKey.MakeFormKey(0x3090);
            public static FormKey ccBGS_RootThornHookActivator => ModKey.MakeFormKey(0x308f);
            public static FormKey ccBGS_FlameStalkActivator01 => ModKey.MakeFormKey(0x308e);
            public static FormKey ccBGS_FlameStalkActivator02 => ModKey.MakeFormKey(0x308d);
            public static FormKey ccBGS_RootRotScaleActivator => ModKey.MakeFormKey(0x308c);
            public static FormKey Patch1_8DLC1DoorFix => ModKey.MakeFormKey(0x9a0);
            public static FormKey WEDL06LetrushCleanupTrigger => ModKey.MakeFormKey(0x99d);
            public static FormKey TG09DoorOverrideFixTrigger => ModKey.MakeFormKey(0x80e);
            public static FormKey dunDA14PortalDisableTrigger => ModKey.MakeFormKey(0x80c);
            public static FormKey C05RepairTrigger => ModKey.MakeFormKey(0x800);
        }
    }
}
