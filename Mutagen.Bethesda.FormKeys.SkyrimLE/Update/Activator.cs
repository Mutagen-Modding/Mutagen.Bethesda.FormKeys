namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Activator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey Patch1_8DLC1DoorFix => ModKey.MakeFormKey(0x9a0);
            public static FormKey WEDL06LetrushCleanupTrigger => ModKey.MakeFormKey(0x99d);
            public static FormKey TG09DoorOverrideFixTrigger => ModKey.MakeFormKey(0x80e);
            public static FormKey dunDA14PortalDisableTrigger => ModKey.MakeFormKey(0x80c);
            public static FormKey C05RepairTrigger => ModKey.MakeFormKey(0x800);
        }
    }
}
