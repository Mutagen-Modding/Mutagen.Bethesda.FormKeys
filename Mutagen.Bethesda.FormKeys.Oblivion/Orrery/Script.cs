namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Script
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey DLCOrreryDwarvenCog1Script => ModKey.MakeFormKey(0x11e63f);
            public static FormKey DLCOrreryDwarvenCog2Script => ModKey.MakeFormKey(0x11e640);
            public static FormKey DLCOrreryDwarvenCohererScript => ModKey.MakeFormKey(0x11e641);
            public static FormKey DLCOrreryDwarvenCylinderScript => ModKey.MakeFormKey(0x11e642);
            public static FormKey DLCOrreryDwarvenTubeScript => ModKey.MakeFormKey(0x11e643);
            public static FormKey DLCOrreryQuestScript => ModKey.MakeFormKey(0x11b9fc);
            public static FormKey DLCOrreryConsoleScript => ModKey.MakeFormKey(0x11d290);
        }
    }
}
